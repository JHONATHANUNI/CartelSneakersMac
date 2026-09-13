using Microsoft.AspNetCore.Mvc;

namespace UrbanKicksMac;

public class HomeController : Controller
{
    public IActionResult Index(string? brand, string? sort)
    {
        var query = ProductCatalog.GetAll();

        if (!string.IsNullOrWhiteSpace(brand))
        {
            query = query.Where(p => p.Brand == brand).ToList();
        }

        query = sort == "low"
            ? query.OrderBy(p => p.Price).ToList()
            : sort == "high"
                ? query.OrderByDescending(p => p.Price).ToList()
                : query.OrderBy(p => p.Id).ToList();

        ViewBag.Brand = brand;
        ViewBag.Sort = sort;
        return View(query);
    }

    public IActionResult Product(int id)
    {
        var product = ProductCatalog.GetById(id);
        if (product is null) return NotFound();

        ViewBag.CartError = TempData["CartError"] as string;
        return View(product);
    }

    public IActionResult About() => View();
    public IActionResult Shipping() => View();
    public IActionResult Privacy() => View();
    public IActionResult Error() => View();
}

public class CartController : Controller
{
    public IActionResult Index() => View(HttpContext.Session.GetCart());

    [HttpPost]
    public IActionResult Add(int id, string size)
    {
        if (string.IsNullOrWhiteSpace(size))
        {
            TempData["CartError"] = "Selecciona una talla antes de agregar al carrito.";
            return RedirectToAction("Product", "Home", new { id });
        }

        var product = ProductCatalog.GetById(id);
        if (product is null) return NotFound();

        var cart = HttpContext.Session.GetCart();
        var item = cart.FirstOrDefault(x => x.ProductId == id && x.Size == size);

        if (item is null)
        {
            cart.Add(new CartItem
            {
                ProductId = id,
                Name = product.Name,
                ImageUrl = product.ImageUrl,
                Size = size,
                UnitPrice = product.Price,
                Quantity = 1
            });
        }
        else
        {
            item.Quantity++;
        }

        HttpContext.Session.SaveCart(cart);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public IActionResult Remove(int id, string size)
    {
        var cart = HttpContext.Session.GetCart();
        cart.RemoveAll(x => x.ProductId == id && x.Size == size);
        HttpContext.Session.SaveCart(cart);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public IActionResult Update(int id, string size, int quantity)
    {
        var cart = HttpContext.Session.GetCart();
        var item = cart.FirstOrDefault(x => x.ProductId == id && x.Size == size);
        if (item is not null) item.Quantity = Math.Clamp(quantity, 1, 20);
        HttpContext.Session.SaveCart(cart);
        return RedirectToAction(nameof(Index));
    }
}

public class CheckoutController(IWhatsAppMessageBuilder whatsAppMessageBuilder, Microsoft.Extensions.Options.IOptions<WhatsAppSettings> config) : Controller
{
    public IActionResult Index()
    {
        var cart = HttpContext.Session.GetCart();
        return cart.Count == 0 ? RedirectToAction("Index", "Cart") : View(new CheckoutViewModel { PaymentMethod = "Nequi" });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Index(CheckoutViewModel model)
    {
        var cart = HttpContext.Session.GetCart();
        if (cart.Count == 0) return RedirectToAction("Index", "Cart");

        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var message = whatsAppMessageBuilder.Build(cart, model);
        var url = whatsAppMessageBuilder.BuildWhatsAppUrl(config.Value.PhoneNumber, message);

        if (string.IsNullOrWhiteSpace(url))
        {
            ModelState.AddModelError(string.Empty, "No se pudo generar el enlace de WhatsApp.");
            return View(model);
        }

        HttpContext.Session.Clear();
        model.WhatsAppUrl = url;
        return View("OpenWhatsApp", model);
    }
}
