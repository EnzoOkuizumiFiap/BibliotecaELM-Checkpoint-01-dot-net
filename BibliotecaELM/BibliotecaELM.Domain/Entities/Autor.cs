using System.Net.Mime;
using BibliotecaELM.Domain.Common;

namespace BibliotecaELM.Domain.Entities;

public class Autor : BaseEntity
{
    public string NomeAutor { get; private set; }
    public string descricao { get; private set; }
    public DateOnly Nascimento { get; private set; }
    
    public Autor(string nome, string descricao, DateOnly nascimento)
    {
        this.NomeAutor = nome;
        this.descricao = descricao;
        ValidateLancamento(nascimento);
    }

    public void ValidateLancamento(DateOnly data)
    {
        if (data.Year < 2015)
        {
            Nascimento = data;
        }
        else
        {
            throw new Exception("Insira um valor válido.");
        }
    }
}