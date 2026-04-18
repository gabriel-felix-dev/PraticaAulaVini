using PraticaAulaVini.DTO;
using PraticaPooAulaVini.DTO;
using PraticaPooAulaVini.Repositories;
using PraticaPooAulaVini.Services;
using PraticaPooAulaVini.UI;

LivroRepository livroRepository = new LivroRepository();
LivroService livroService = new LivroService(livroRepository);

Console.WriteLine("##### - Biblioteca Leia Mais - #####");

while (true)
{
    int opcaoMenu = Menu.MostrarMenu();

    switch (opcaoMenu)
    {
        case 1:
            LivroDTO livroDTO = Menu.CadastrarLivro();
            livroService.CadastrarLivro(livroDTO);
            break;
        case 2:
            Menu.ListarLivros(livroService.ListarLivros());
            break;
        case 3:
            LivroAtualizaTituloDTO livroAtualizaTituloDTO = Menu.AlterarLivro(livroService.ListarLivros());
            livroService.AlterarLivro(livroAtualizaTituloDTO);
            break;
        case 4:
            LivroDeletaDTO livroDeletaDTO = Menu.DeletarLivro(livroService.ListarLivros());
            livroService.DeletarLivro(livroDeletaDTO);
            break;
        default:
            Console.WriteLine("\nSistema encerrado");
            Thread.Sleep(500);
            Environment.Exit(0);
            break;
    }
}