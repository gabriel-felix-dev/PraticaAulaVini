using PraticaPooAulaVini.DTO;
using PraticaPooAulaVini.Repositories;
using PraticaPooAulaVini.Services;
using PraticaPooAulaVini.UI;

LivroRepository livroRepository = new LivroRepository();
LivroService livroService = new LivroService(livroRepository);

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
            Menu.AlterarLivro(livroService.ListarLivros());
            break;
        case 4:
            //Menu.ListarLivros(livroService.ListarLivros());
            break;
        default:
            Console.WriteLine("Sistema encerrado");
            Thread.Sleep(1000);
            Environment.Exit(0);
            break;
    }
}