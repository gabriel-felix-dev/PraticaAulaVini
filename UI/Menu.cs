using PraticaAulaVini.DTO;
using PraticaPooAulaVini.DTO;
using PraticaPooAulaVini.Models;

namespace PraticaPooAulaVini.UI;

public static class Menu
{
    public static int MostrarMenu()
    {
        int opcaoMenu;

        Console.WriteLine("\n1 - Cadastrar Livro");
        Console.WriteLine("2 - Listar Livros Cadastrados");
        Console.WriteLine("3 - Alterar Livro Cadastrados");
        Console.WriteLine("4 - Deletar Livro Cadastrados");
        Console.WriteLine("0 - Sair");
        Console.Write("\nDigite a opção desejada: ");

        while (!int.TryParse(Console.ReadLine(), out opcaoMenu) || opcaoMenu < 0 || opcaoMenu > 4)
            Console.Write("\nOpção inválida, digite novamente: ");

        return opcaoMenu;
    }

    public static LivroDTO CadastrarLivro()
    {
        string tituloLivro;
        string autorLivro;
        int anoPubicacaoLivro;

        Console.Write("\nDigite o titulo do livro: ");
        tituloLivro = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(tituloLivro))
        {
            Console.Write("O titulo do livro deve ser preenchido, digite novamente: ");
            tituloLivro = Console.ReadLine();
        }
        Console.Write("\nDigite o autor do livro: ");
        autorLivro = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(autorLivro))
        {
            Console.Write("O autor do livro deve ser preenchido, digite novamente: ");
            autorLivro = Console.ReadLine();
        }

        Console.Write("\nDigite o ano de publicação do livro: ");
        while (!int.TryParse(Console.ReadLine(), out anoPubicacaoLivro))
            Console.Write("O titulo do livro deve ser preenchido, digite novamente: ");

        return new LivroDTO(tituloLivro, autorLivro, anoPubicacaoLivro);
    }

    public static void ListarLivros(List<Livro> livro)
    {

        if (livro.Count == 0)
        {
            Console.WriteLine("\nNão há livros cadastrados.");
            return;
        }

        Console.WriteLine($"\nLista de livros cadastrados: \n");

        livro.ForEach(l => Console.WriteLine(l.ToString()));
    }

    public static LivroAtualizaTituloDTO AlterarLivro(List<Livro> livro)
    {
        ListarLivros(livro);

        if (livro.Count == 0)
            return null;

        Guid idLivro;
        string tituloLivro;
        // string autorLivro;
        // int anoPubicacaoLivro;

        Console.Write("\nDigite o id do livro: ");

        while (!Guid.TryParse(Console.ReadLine(), out idLivro))
            Console.WriteLine("\nO id está incorreto, digite novamente: ");


        Console.Write("\nDigite o novo titulo do livro: ");
        tituloLivro = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(tituloLivro))
        {
            Console.Write("O titulo do livro deve ser preenchido, digite novamente: ");
            tituloLivro = Console.ReadLine();
        }

        // Console.Write("\nDigite o novo autor do livro: ");
        // autorLivro = Console.ReadLine();

        // while (string.IsNullOrWhiteSpace(autorLivro))
        // {
        //     Console.Write("O autor do livro deve ser preenchido, digite novamente: ");
        //     autorLivro = Console.ReadLine();
        // }

        // Console.Write("\nDigite o novo ano de publicação do livro: ");
        // while (!int.TryParse(Console.ReadLine(), out anoPubicacaoLivro))
        //     Console.Write("O titulo do livro deve ser preenchido, digite novamente: ");

        return new LivroAtualizaTituloDTO(idLivro, tituloLivro);
    }

    public static LivroDeletaDTO DeletarLivro(List<Livro> livro)
    {
        ListarLivros(livro);

        if (livro.Count == 0)
            return null;

        Guid idLivro;

        Console.Write("\nInforme o Id do livro para deletar: ");

        while (!Guid.TryParse(Console.ReadLine(), out idLivro))
            Console.WriteLine("\nO id está incorreto, digite novamente: ");

        return new LivroDeletaDTO(idLivro);
    }

}
