namespace Loja_de_Instrumentos.Models;

public class Client : People
{
    public DateTime? Birthday { get; set; }
    public List<Order> Orders { get; set; }
}