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
        new() { Id = 1, Name = "Air Jordan 1 Retro", Brand = "Nike", Price = 12999, Description = "Iconic streetwear classic with timeless style.", ImageUrl = "NikeAirJordan1.jpg", ImageUrl2 = "NikeAirJordan2.jpg" },
        new() { Id = 2, Name = "Dunk Low Smoke", Brand = "Nike", Price = 9999, Description = "Clean low-top silhouette for everyday rotation.", ImageUrl = "NikeDunkLowSmoke1.jpg", ImageUrl2 = "NikeDunkLowSmoke2.jpg" },
        new() { Id = 3, Name = "Samba OG", Brand = "Adidas", Price = 8999, Description = "A terrace legend reimagined for the city.", ImageUrl = "AdidasSamba1.jpg", ImageUrl2 = "AdidasSamba2.jpg" },
        new() { Id = 4, Name = "Gel-Kayano", Brand = "Asics", Price = 10999, Description = "Technical comfort with a bold running profile.", ImageUrl = "AsicsGelKinetic1.jpg", ImageUrl2 = "AsicsGelKinetic2.jpg" },
        new() { Id = 5, Name = "Chuck 70", Brand = "Converse", Price = 6999, Description = "The high-top icon with premium canvas.", ImageUrl = "ConverseChuck70_1.jpg", ImageUrl2 = "ConverseChuck70_2.jpg" }
    ];

    public static List<Product> GetAll() => Products;

    public static Product? GetById(int id) => Products.FirstOrDefault(p => p.Id == id);
}
