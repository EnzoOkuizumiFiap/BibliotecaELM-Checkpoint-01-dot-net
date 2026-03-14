namespace BibliotecaELM.Domain.Entities;

public class Compra
{
    public string FormaCompra { get; private set; }
    public DateOnly DataCompra { get; private set; }
    public Usuario Usuario { get; private set; }

    public Compra(string formaCompra, DateOnly dataCompra, Usuario usuario)
    {
        validateFormaCompra(formaCompra);
        validateDataCompra(dataCompra);
        this.Usuario = usuario;
    }

    public void validateFormaCompra(string forma)
    {
        if (forma.ToLower() == "debito" || forma.ToLower() == "credito" || forma.ToLower() == "dinheiro" ||
            forma.ToLower() == "pix")
        {
            FormaCompra = forma;
        }
        else
        {
            throw new Exception("Insira um valor válido.");
        }
    }

    public void validateDataCompra(DateOnly data)
    {
        if (data.Year < 1900 && data.Year > DateTime.Now.Year)
        {
            throw new Exception("Insira uma data válida.");
        }
        else
        {
            DataCompra = data;
        }
    }
}