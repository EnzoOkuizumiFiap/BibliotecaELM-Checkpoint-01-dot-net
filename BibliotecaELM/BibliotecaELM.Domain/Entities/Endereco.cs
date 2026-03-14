namespace BibliotecaELM.Domain.Entities;
public class Endereco
{
    public long IdEndereco { get; private set; }
    public int Cep { get; private set; }
    public string Estado { get; private set; }
    public string Cidade { get; private set; }
    public string Bairro { get; private set; }
    public string Rua { get; private set; }
}