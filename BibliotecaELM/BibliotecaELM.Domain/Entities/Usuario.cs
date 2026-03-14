namespace BibliotecaELM.Domain.Entities;

public class Usuario
{
    public long id_user { get; private set; }
    public string nome_user { get; private set; }
    public DateTime data_user { get; private set; }
    public string email { get; private set; }
    public int cpf { get; private set; }
    
    public List<Emprestimo> emprestimos { get; private set; }
    public Endereco endereco { get; private set; }
    public List<Compra> compras { get; private set; }
    public List<Livro> livros { get; private set; }
    
    public Usuario(long id_user, string nome_user, DateTime data_user, string email, int cpf)
    {
        UpdateName(nome_user);
        UpdateEmail(email);
        SetBirthDate(dateBorn);
        ChangePassword(rawPassword);
    }
    
    public void UpdateName(string newName)
    {
        if (string.IsNullOrWhiteSpace(newName))
            throw new Exception("Nome não pode ser vazio.");
        
        nome_user = newName;
    }

    public void UpdateEmail(string newEmail)
    {
        if (string.IsNullOrWhiteSpace(newEmail) || !newEmail.Contains("@"))
            throw new Exception("E-mail inválido.");
            
        email = newEmail;
    }
}