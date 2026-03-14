namespace BibliotecaELM.Domain.Entities;
public class Endereco
{
    public long id_endereco { get; private set; }
    public int cep { get; private set; }
    public string estado { get; private set; }
    public string cidade { get; private set; }
    public string bairro { get; private set; }
    public string rua { get; private set; }
}