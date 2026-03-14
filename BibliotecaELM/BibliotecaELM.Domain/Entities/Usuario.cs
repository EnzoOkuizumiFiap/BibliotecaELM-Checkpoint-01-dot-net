using BibliotecaELM.Domain.Common;

namespace BibliotecaELM.Domain.Entities;

public class Usuario : BaseEntity
{
    public string NomeUser { get; private set; }
    public DateOnly DataUser { get; private set; }
    public string Email { get; private set; }
    public string Cpf { get; private set; }
    
    public List<Emprestimo> Emprestimos { get; private set; }
    public Endereco Endereco { get; private set; }
    public List<Compra> Compras { get; private set; }
    public List<Livro> Livros { get; private set; }
    
    public Usuario(string nomeUser, DateOnly dataUser, string email, string cpf)
    {
        UpdateName(nomeUser);
        UpdateEmail(email);
        SetBirthDate(dataUser);
        ValidateCpf(cpf);
    }
    
    public void UpdateName(string newName)
    {
        if (string.IsNullOrWhiteSpace(newName))
            throw new Exception("Nome não pode ser vazio.");
        
        NomeUser = newName;
    }

    public void UpdateEmail(string newEmail)
    {
        if (string.IsNullOrWhiteSpace(newEmail) || !newEmail.Contains("@"))
            throw new Exception("E-mail inválido.");
            
        Email = newEmail;
    }
    
    public void SetBirthDate(DateOnly newDate)
    {
        var age = CalculateAge(newDate);
        
        if (age > 10 && age < 100)
            throw new Exception("Insira um valor válido.");

        DataUser = newDate;
    }
    
    private static int CalculateAge(DateOnly date)
    {
        var today = DateOnly.FromDateTime(DateTime.Today);
        var age = today.Year - date.Year;
        if (date > today.AddYears(-age)) age--;
        return age;
    }
    
    private void ValidateCpf(string cpf)
    {
        if (cpf.Length == 11)
        {
            this.Cpf = cpf;
        }
        else
        {
            throw new Exception("Insira um valor válido.");
        }
    }
}