using System.Net.Mime;

namespace BibliotecaELM.Domain.Entities;

public class Autor
{
    public long id_autor { get; private set; }
    public string nome_autor { get; private set; }
    public DateTime nascimento { get; private set; }
}