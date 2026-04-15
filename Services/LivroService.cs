using PraticaPooAulaVini.DTO;
using PraticaPooAulaVini.Models;
using PraticaPooAulaVini.Repositories;

namespace PraticaPooAulaVini.Services;

public class LivroService
{
    public LivroService(LivroRepository livroRepository)
    {
        _livroRepository = livroRepository;
    }

    private LivroRepository _livroRepository;

    public void CadastrarLivro(LivroDTO livroDTO)
    {
        Livro livro = new Livro(livroDTO.TituloLivro, livroDTO.AutorLivro, livroDTO.AnoPubicacaoLivro);

        _livroRepository.AdicionarLivro(livro);
    }

    public List<Livro> ListarLivros() => _livroRepository.RetornaLivros();

    public void AlterarLivro(Guid idLivro)
    {
        var livro = _livroRepository.RetornaLivros();

        var posicao = livro.IndexOf(livro.FirstOrDefault(l => l.Id.Equals(idLivro)));

        //livro[posicao] = ;

    }
}
