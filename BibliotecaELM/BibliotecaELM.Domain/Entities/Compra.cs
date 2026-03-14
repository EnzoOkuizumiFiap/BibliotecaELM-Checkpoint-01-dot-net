namespace BibliotecaELM.Domain.Entities;

public class Compra
{
    public long id_compra  { get; private set; }
    public string forma_compra { get; private set; }
    public DateTime data_compra { get; private set; }
    public long id_user { get; private set; }
}