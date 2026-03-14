using BibliotecaELM.Domain.Common;

namespace BibliotecaELM.Domain.Entities;

public class Livro: BaseEntity
{
    public string nomeLivro { get; private set; }
    public decimal Preco { get; private set; }
    public DateOnly Lancamento { get; private set; }
    public Autor Autor { get; private set; }

    public Livro(string nome_livro, decimal preco, DateOnly lancamento, Autor autor)
    {
        this.nomeLivro = nome_livro;
        validatePreco(preco);
        validateLancamento(lancamento);
        this.Autor = autor;
    }
    
    public void validatePreco(decimal valor)
    {
        if (valor > 0 && valor < 10000)
        {
            Preco = valor;
        }
        else
        {
            throw new Exception("Insira um valor valido");
        }
    }

    public void validateLancamento(DateOnly data)
    {
        if (data.Year < 2024)
        {
            Lancamento = data;
        }
        else
        {
            throw new Exception("Insira uma data valida");
        }
    }
}