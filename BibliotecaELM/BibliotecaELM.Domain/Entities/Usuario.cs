using BibliotecaELM.Domain.Common;

namespace BibliotecaELM.Domain.Entities;

public class Usuario : BaseEntity
{
    public string NomeUsuario { get; private set; }
    public DateOnly Nascimento { get; private set; }
    public string Email { get; private set; }
    public string Cpf { get; private set; }
    
    // Propriedades de navegação
    public List<Emprestimo> Emprestimos { get; private set; } = new List<Emprestimo>();
    public List<Compra> Compras { get; private set; } = new List<Compra>();
    public Endereco? Endereco { get; private set; }
    
    public Usuario(string nome, DateOnly nascimento, string email, string cpf)
    {
        if (string.IsNullOrWhiteSpace(nome)) throw new ArgumentException("O nome não pode ser vazio ou nulo.", nameof(nome));
        NomeUsuario = nome;
        
        int age = CalculateAge(nascimento);
        if (age is < 10 or > 100) throw new ArgumentOutOfRangeException(nameof(nascimento), "O usuário deve ter entre 10 e 100 anos.");
        Nascimento = nascimento;
        
        if (string.IsNullOrWhiteSpace(email) || !email.Contains("@")) throw new ArgumentException("E-mail inválido. Deve conter '@'.", nameof(email));
        Email = email;
        
        if (string.IsNullOrWhiteSpace(cpf) || cpf.Length != 11) throw new ArgumentException("CPF inválido. Deve conter exatamente 11 caracteres.", nameof(cpf));
        Cpf = cpf;
    }
    
    private static int CalculateAge(DateOnly date)
    {
        var today = DateOnly.FromDateTime(DateTime.Today);
        var age = today.Year - date.Year;
        if (date > today.AddYears(-age)) age--;
        return age;
    }
}