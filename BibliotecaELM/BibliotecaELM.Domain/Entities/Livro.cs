namespace BibliotecaELM.Domain.Entities;

public class Livro
{
    public long id_livro { get; private set; }
    public string nome_livro { get; private set; }
    public decimal preco { get; private set; }
    public DateTime lancamento { get; private set; }
    public long id_autor { get; private set; }
}