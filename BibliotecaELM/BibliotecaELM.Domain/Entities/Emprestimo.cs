namespace BibliotecaELM.Domain.Entities;

public class Emprestimo
{
    public long idEmprestimo { get; private set; }
    public DateTime dataEmprestimo { get; private set; }
    public DateTime dataDevolucao { get; private set; }
    public long idUser { get; private set; }
    public long idLivro { get; private set; }
}