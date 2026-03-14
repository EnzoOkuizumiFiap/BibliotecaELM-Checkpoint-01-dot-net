namespace BibliotecaELM.Domain.Entities;

public class Emprestimo
{
    public long id_emprestimo { get; private set; }
    public DateTime data_emprestimo { get; private set; }
    public DateTime data_devolucao { get; private set; }
    public long id_user { get; private set; }
    public long id_livro { get; private set; }
}