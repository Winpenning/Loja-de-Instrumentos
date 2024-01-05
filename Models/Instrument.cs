namespace Loja_de_Instrumentos.Models;

public class Instrument
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Brand { get; set; }
    public float Price { get; set; }
    
    public List<string> Materials { get; set; }
}