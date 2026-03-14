using BibliotecaELM.Domain.Common;

namespace BibliotecaELM.Domain.Entities;

public class Emprestimo : BaseEntity
{
    public DateTime DataEmprestimo { get; private set; }
    public DateTime DataDevolucao { get; private set; }
    
    // Propriedades de navegação
    public Usuario Usuario { get; private set; }
    public Livro Livro { get; private set; }
    public Endereco Endereco { get; private set; }
    
    public Emprestimo(DateTime dataEmprestimo, DateTime dataDevolucao, Usuario usuario, Livro livro, Endereco endereco)
    {
        if (dataDevolucao < dataEmprestimo) throw new ArgumentException("A data de devolução não pode ser anterior à data de empréstimo.");
        DataEmprestimo = dataEmprestimo;
        DataDevolucao = dataDevolucao;
        
        Usuario = usuario ?? throw new ArgumentNullException(nameof(usuario), "O usuário não pode ser nulo.");
        Livro = livro ?? throw new ArgumentNullException(nameof(livro), "O livro não pode ser nulo.");
        Endereco = endereco ?? throw new ArgumentNullException(nameof(endereco), "O endereço não pode ser nulo.");
    }
}