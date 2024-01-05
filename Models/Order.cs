namespace Loja_de_Instrumentos.Models;

public class Order
{
    public int Id { get; set; }
    public float Price { get; set; }
    public List<Instrument> Instruments { get; set; }
}