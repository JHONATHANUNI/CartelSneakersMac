using System.Text.Json;

namespace UrbanKicksMac;

public static class CartExtensions
{
    public static List<CartItem> GetCart(this ISession session) =>
        JsonSerializer.Deserialize<List<CartItem>>(session.GetString("cart") ?? "[]") ?? [];

    public static void SaveCart(this ISession session, List<CartItem> cart) =>
        session.SetString("cart", JsonSerializer.Serialize(cart));
}
