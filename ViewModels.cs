using System.ComponentModel.DataAnnotations;

namespace UrbanKicksMac;

public record LoginViewModel(string Username, string Password);
public record RegisterViewModel(string Username, string Password, string FirstName, string LastName, string Email);

public class CheckoutViewModel
{
    [Required(ErrorMessage = "El nombre completo es obligatorio.")]
    public string CustomerName { get; set; } = string.Empty;

    [Required(ErrorMessage = "El teléfono es obligatorio.")]
    [Phone(ErrorMessage = "Ingresa un teléfono válido.")]
    public string PhoneNumber { get; set; } = string.Empty;

    [Required(ErrorMessage = "La dirección de envío es obligatoria.")]
    public string ShippingAddress { get; set; } = string.Empty;

    [Required(ErrorMessage = "La ciudad es obligatoria.")]
    public string City { get; set; } = string.Empty;

    [Required(ErrorMessage = "El método de pago es obligatorio.")]
    public string PaymentMethod { get; set; } = "Nequi";

    public string Notes { get; set; } = string.Empty;

    public string? WhatsAppUrl { get; set; }
}

public class WhatsAppSettings
{
    public string PhoneNumber { get; set; } = string.Empty;
}
