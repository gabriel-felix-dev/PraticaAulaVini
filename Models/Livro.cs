using PraticaPooAulaVini.Enums;

namespace PraticaPooAulaVini.Models;

public class Livro
{
    public Livro(string titulo, string autor, int anoPublicacao)
    {
        Id = Guid.NewGuid();
        Titulo = titulo;
        Autor = autor;
        AnoPublicacao = anoPublicacao;
        StatusLivro = StatusLivroEnum.Disponivel;
    }

    public Guid Id { get; }
    public string Titulo { get; private set; }
    public string Autor { get; private set; }
    public int AnoPublicacao { get; private set; }
    public StatusLivroEnum StatusLivro { get; private set; }

    public void AlterarTitulo(string titulo) => Titulo = titulo;

    public void Deletar() => StatusLivro = StatusLivroEnum.Indisponivel;    

    public override string ToString() => $"Id: {Id} | Titulo: {Titulo} | Autor: {Autor} | Ano Punlicação {AnoPublicacao} | Status: {StatusLivro}";

}
