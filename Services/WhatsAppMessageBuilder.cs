using System.Text;

namespace UrbanKicksMac;

public interface IWhatsAppMessageBuilder
{
    string Build(List<CartItem> cart, CheckoutViewModel model);
    string BuildWhatsAppUrl(string phoneNumber, string message);
}

public class WhatsAppMessageBuilder : IWhatsAppMessageBuilder
{
    public string Build(List<CartItem> cart, CheckoutViewModel model)
    {
        var details = cart.Select(item =>
            $"• {item.Name} | Talla: {item.Size} | Cant: {item.Quantity} - ${item.Total:N0}").ToList();

        var message = new StringBuilder();
        message.AppendLine("🔥 *¡NUEVO PEDIDO - CARTEL SNEAKERS!* 🔥");
        message.AppendLine("----------------------------------------");
        message.AppendLine($"👤 *Cliente:* {model.CustomerName}");
        message.AppendLine($"📞 *Teléfono:* {model.PhoneNumber}");
        message.AppendLine($"📍 *Envío a:* {model.ShippingAddress}, {model.City}");
        message.AppendLine($"💳 *Método de Pago:* {model.PaymentMethod}");
        message.AppendLine();
        message.AppendLine("🛒 *DETALLE DEL PEDIDO:*");
        foreach (var detail in details)
        {
            message.AppendLine(detail);
        }
        message.AppendLine("----------------------------------------");
        message.AppendLine($"💰 *TOTAL A PAGAR:* ${cart.Sum(x => x.Total):N0}");
        message.AppendLine();

        var notes = string.IsNullOrWhiteSpace(model.Notes) ? "Sin notas adicionales" : model.Notes;
        message.AppendLine($"📝 *Notas:* {notes}");

        return message.ToString();
    }

    public string BuildWhatsAppUrl(string phoneNumber, string message)
    {
        var normalized = new string((phoneNumber ?? string.Empty)
            .Where(ch => char.IsDigit(ch) || ch == '+')
            .ToArray());

        if (normalized.StartsWith('+'))
        {
            normalized = normalized.TrimStart('+');
        }

        return $"https://wa.me/{normalized}?text={Uri.EscapeDataString(message)}";
    }
}
