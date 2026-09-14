namespace UrbanKicksMac;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Brand { get; set; } = "";
    public decimal Price { get; set; }
    public string Description { get; set; } = "";
    public string ImageUrl { get; set; } = "";
    public string ImageUrl2 { get; set; } = "";
}

public class CartItem
{
    public int ProductId { get; set; }
    public string Name { get; set; } = "";
    public string ImageUrl { get; set; } = "";
    public string Size { get; set; } = "";
    public decimal UnitPrice { get; set; }
    public int Quantity { get; set; }
    public decimal Total => UnitPrice * Quantity;
}

public static class ProductCatalog
{
    private static readonly List<Product> Products =
    [
        new() { Id = 1, Name = "LV Trainer Black & White Monogram", Brand = "Louis Vuitton", Price = 159900, Description = "Iconic low-top sneaker featuring black and white monogram denim panels and embossed detailing.", ImageUrl = "390M.jpg", ImageUrl2 = "390M.jpg" },
        new() { Id = 2, Name = "LV Skate Sneaker All-Black Rhinestone", Brand = "Louis Vuitton", Price = 159900, Description = "Chunky skate-inspired silhouette in full black with rhinestone embellishments and flower branding.", ImageUrl = "884M.jpg", ImageUrl2 = "884M.jpg" },
        new() { Id = 3, Name = "LV Skate Sneaker Triple Black", Brand = "Louis Vuitton", Price = 159900, Description = "Padded skate trainer with technical mesh, suede overlays, and signature lateral flower logo.", ImageUrl = "885M.jpg", ImageUrl2 = "885M.jpg" },
        new() { Id = 4, Name = "LV Trainer White Black Monogram", Brand = "Louis Vuitton", Price = 159900, Description = "Clean white leather basketball-inspired sneaker with subtle black trims and LV branding.", ImageUrl = "897M.jpg", ImageUrl2 = "897M.jpg" },
        new() { Id = 5, Name = "LV Trainer Beige & White Monogram", Brand = "Louis Vuitton", Price = 159900, Description = "Luxury low-top trainer designed in neutral beige denim accents over premium white leather.", ImageUrl = "898M.jpg", ImageUrl2 = "898M.jpg" },

        new() { Id = 6, Name = "Cloudmonster White & Pink", Brand = "On Cloud", Price = 10999, Description = "Zapatilla de amortiguación máxima con tecnología CloudTec en tono blanco con detalles rosa pastel.", ImageUrl = "12M.jpg", ImageUrl2 = "12M.jpg" },
        new() { Id = 7, Name = "Cloudmonster Navy Blue", Brand = "On Cloud", Price = 10999, Description = "Diseño de alto rendimiento para running y uso diario en azul marino con suela CloudTec blanca.", ImageUrl = "26M.jpg", ImageUrl2 = "26M.jpg" },
        new() { Id = 8, Name = "Cloudmonster Black & Mint", Brand = "On Cloud", Price = 10999, Description = "Silueta deportiva en malla transpirable color negro con sutiles acentos en verde menta.", ImageUrl = "30M.jpg", ImageUrl2 = "30M.jpg" },
        new() { Id = 9, Name = "Supermagma Off-White & Bronze", Brand = "Adidas", Price = 8999, Description = "Deportivo urbano con suela de máximo volumen en tono hueso con detalles bronce en el talón.", ImageUrl = "321M.jpg", ImageUrl2 = "321M.jpg" },
        new() { Id = 10, Name = "Cloudmonster White & Forest Green", Brand = "On Cloud", Price = 10999, Description = "Tenis ultraligeros en base blanca con elegantes detalles verde bosque y suela amortiguada.", ImageUrl = "535M.jpg", ImageUrl2 = "535M.jpg" },
        new() { Id = 11, Name = "Supernova Dreamstrike Cream & Orange", Brand = "Adidas", Price = 9499, Description = "Diseño de running moderno en tono crema con contornos naranja vibrante y suela gruesa.", ImageUrl = "633M.jpg", ImageUrl2 = "633M.jpg" },
        new() { Id = 12, Name = "Supernova Dreamstrike White & Light Blue", Brand = "Adidas", Price = 9499, Description = "Calzado deportivo de malla blanca ligera con las icónicas tres franjas en azul cielo.", ImageUrl = "635M.jpg", ImageUrl2 = "635M.jpg" },
        new() { Id = 13, Name = "Supernova Dreamstrike Black & White", Brand = "Adidas", Price = 9499, Description = "Estilo clásico deportivo en negro y blanco con tecnología de amortiguación Dreamstrike Glow.", ImageUrl = "640M.jpg", ImageUrl2 = "640M.jpg" },
        new() { Id = 14, Name = "LV Trainer Grey Monogram Denim", Brand = "Louis Vuitton", Price = 12999, Description = "Edición de lujo en cuero blanco y paneles de denim gris grabado con el patrón Monogram.", ImageUrl = "895A.jpg", ImageUrl2 = "895A.jpg" },

        
        new() { Id = 15, Name = "Go Run Max Cushioning Slip-Ins", Brand = "Skechers", Price = 7999, Description = "Zapatilla slip-on ultra cómoda en malla negra con suela alta perforada Max Cushioning.", ImageUrl = "918M.jpg", ImageUrl2 = "918M.jpg" },
        new() { Id = 16, Name = "LV Trainer Full Black Leather", Brand = "Louis Vuitton", Price = 12999, Description = "Diseño premium totalmente negro en cuero de alta calidad con cordones contrastantes y monograma grabado.", ImageUrl = "341A.jpg", ImageUrl2 = "341A.jpg" },
        new() { Id = 17, Name = "Air Jordan 1 Low Patent Black", Brand = "Nike", Price = 11999, Description = "Silueta clásica de perfil bajo confeccionada en charol negro brillante con costuras blancas acentuadas.", ImageUrl = "534A.jpg", ImageUrl2 = "534A.jpg" },
        new() { Id = 18, Name = "Supernova Dreamstrike Off-White & Black", Brand = "Adidas", Price = 9499, Description = "Calzado de running en tono crema claro con detalles en verde menta y las tres franjas en negro.", ImageUrl = "743M.jpg", ImageUrl2 = "743M.jpg" },
        new() { Id = 19, Name = "Air Force 1 Low Triple Black", Brand = "Nike", Price = 9999, Description = "El clásico de la cultura urbana en una versión totalmente negra de acabado mate y suela Air.", ImageUrl = "883M.jpg", ImageUrl2 = "883M.jpg" },
        new() { Id = 20, Name = "LV Trainer White & Black Classic", Brand = "Louis Vuitton", Price = 12999, Description = "Inspiración en el baloncesto retro con acabado en cuero blanco premium y detalles en negro.", ImageUrl = "894A.jpg", ImageUrl2 = "894A.jpg" },
        new() { Id = 21, Name = "Go Run Max Cushioning Dark Grey", Brand = "Skechers", Price = 7999, Description = "Zapatilla slip-in liviana en tejido mesh gris oscuro con suela de amortiguación Max Cushioning gris.", ImageUrl = "916M.jpg", ImageUrl2 = "916M.jpg" },
        new() { Id = 22, Name = "Go Run Max Cushioning Lavender", Brand = "Skechers", Price = 7999, Description = "Diseño deportivo de máximo confort en un llamativo color lavanda/púrpura con tecnología Glide-Step.", ImageUrl = "919M.jpg", ImageUrl2 = "919M.jpg" },
        new() { Id = 23, Name = "Go Run Max Cushioning Triple White", Brand = "Skechers", Price = 7999, Description = "Silueta ultraligera de entrenamiento en blanco total con malla respirable y ajuste sin cordones.", ImageUrl = "920M.jpg", ImageUrl2 = "920M.jpg" },
        new() { Id = 24, Name = "New Balance 740 Metallic Bronze", Brand = "New Balance", Price = 10999, Description = "Estilo retro-runner de los años 2000 con malla beige, superposiciones bronce metálico y amortiguación ABZORB.", ImageUrl = "4533.jpg", ImageUrl2 = "4533.jpg" },
        new() { Id = 26, Name = "Cloudmonster Dark Grey & White", Brand = "On Cloud", Price = 10999, Description = "Diseño de alto rendimiento en tono gris oscuro con suela gruesa CloudTec en contraste blanco.", ImageUrl = "7M.jpg", ImageUrl2 = "7M.jpg" },
        new() { Id = 27, Name = "Cloudmonster Sand & Berry", Brand = "On Cloud", Price = 10999, Description = "Silueta moderna en tono arena/beige con cordones en tono baya y suela CloudTec ultraligera.", ImageUrl = "294M.jpg", ImageUrl2 = "294M.jpg" },
        new() { Id = 28, Name = "Duramo Speed Navy & White", Brand = "Adidas", Price = 8999, Description = "Zapatilla de running ligera en azul marino con las tres franjas laterales en contraste blanco.", ImageUrl = "678A.jpg", ImageUrl2 = "678A.jpg" },
        new() { Id = 29, Name = "Duramo Speed Core Black", Brand = "Adidas", Price = 8999, Description = "Modelo deportivo en malla transpirable totalmente negra con detalles y suela en blanco puro.", ImageUrl = "679A.jpg", ImageUrl2 = "679A.jpg" },
        new() { Id = 30, Name = "Duramo Speed Black & Solar Orange", Brand = "Adidas", Price = 8999, Description = "Diseño dinámico en base negra con llamativos detalles y acentos en naranja vibrante.", ImageUrl = "892A.jpg", ImageUrl2 = "892A.jpg" },
        new() { Id = 31, Name = "Air Force 1 Low Black & Purple Stitch", Brand = "Nike", Price = 9999, Description = "Edición especial en cuero negro con costuras blancas acentuadas, forro interno morado y swoosh de charol.", ImageUrl = "3695.jpg", ImageUrl2 = "3695.jpg" }

    ];

    public static List<Product> GetAll() => Products;

    public static Product? GetById(int id) => Products.FirstOrDefault(p => p.Id == id);
}
