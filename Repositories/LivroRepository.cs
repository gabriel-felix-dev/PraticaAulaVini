using PraticaPooAulaVini.Models;

namespace PraticaPooAulaVini.Repositories;

public class LivroRepository
{
    private readonly List<Livro> _livros = [];

    public void AdicionarLivro(Livro livro) => _livros.Add(livro);

    public List<Livro> RetornaLivros() => _livros;
}
