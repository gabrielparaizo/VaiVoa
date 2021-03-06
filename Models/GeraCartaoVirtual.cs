using System.ComponentModel.DataAnnotations;
public class GeraCartaoVirtual
{
  [Key]
  // O e-mail é obrigatório e só poderá ser persistido no banco de dados um e-mail válido
  public long Id { get; set; }

  [Required]
  [EmailAddress]
  public string Email { get; set; }

  public string NumeroCartao { get; set; }
}
