using System;
using System.Collections.Generic;

public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Ano { get; set; }
    public string Genero { get; set; }
    public string Resumo { get; set; }
    public int Quantidade { get; set; }

    public Livro(string titulo, string autor, int ano, string genero, string resumo, int quantidade)
    {
        Titulo = titulo;
        Autor = autor;
        Ano = ano;
        Genero = genero;
        Resumo = resumo;
        Quantidade = quantidade;
    }
}

class Program
{
    static void Main()
    {
        List<Livro> livros = new List<Livro>();
        int escolha;
        int opcao = 0;

    returnGeral:
        do
        {
            Console.Clear();
            Console.WriteLine("Você é:");
            Console.WriteLine("1) Administrador");
            Console.WriteLine("2) Usuário");
            Console.WriteLine("3) Sair");
            if (!int.TryParse(Console.ReadLine(), out escolha) || (escolha < 1 || escolha > 3))
            {
                Console.WriteLine("\nNúmero inválido!");
            }
        }
        while (escolha < 1 || escolha > 3);

        switch (escolha)
        {
            case 1:
                goto returnADM;
            case 2:
                goto returnUsuario;
            case 3:
                Console.WriteLine("Saindo...");
                return;
        }

    returnADM:
        do
        {
            Console.Clear();
            Console.WriteLine("O que deseja fazer: ");
            Console.WriteLine("1) Catálogo");
            Console.WriteLine("2) Cadastrar livro");
            Console.WriteLine("3) Remover livro");
            Console.WriteLine("4) Sair");
            if (!int.TryParse(Console.ReadLine(), out opcao) || (opcao < 1 || opcao > 3))
            {
                Console.WriteLine("\nNúmero inválido!");
            }
        }
        while (opcao < 1 || opcao > 3);

        switch (opcao)
        {
            case 1:
            int continuar;
                do
                {
                    if (livros.Count <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Nenhum livro disponível no catálogo.");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\nLivros cadastrados:");
                        foreach (var livro in livros)
                        {
                            Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Ano: {livro.Ano}, Gênero: {livro.Genero}, Quantidade: {livro.Quantidade}");
                            Console.WriteLine($"Resumo: {livro.Resumo}.\n\n");
                        }
                    }

                    Console.WriteLine("\n\nDeseja sair?");
                    Console.WriteLine("1) Sim");
                    Console.WriteLine("2) Não");
                    int.TryParse(Console.ReadLine(), out continuar);
                }
                while (continuar != 1);
                goto returnADM;
            case 2:
                int continuar;
                do
                {
                    Console.Write("Digite o título do livro: ");
                    string titulo = Console.ReadLine();
                    Console.Write("Digite o autor do livro: ");
                    string autor = Console.ReadLine();
                    Console.Write("Digite o ano de publicação: ");
                    int ano = int.TryParse(Console.ReadLine(), out int anoResultado) ? anoResultado : 0;
                    Console.WriteLine($"Digite o gênero do livro {titulo}:");
                    string genero = Console.ReadLine();
                    Console.WriteLine($"Digite o resumo do livro {titulo}:");
                    string resumo = Console.ReadLine();
                    Console.Write("Digite a quantidade de livros disponíveis: ");
                    int quantidade = int.TryParse(Console.ReadLine(), out int quantidadeResultado) ? quantidadeResultado : 0;
                    livros.Add(new Livro(titulo, autor, ano, genero, resumo, quantidade));
                    Console.WriteLine("Você deseja adicionar outro livro?");
                    Console.WriteLine("1) Sim");
                    Console.WriteLine("2) Não");
                    int.TryParse(Console.ReadLine(), out continuar);
                }
                while (continuar == 1);
                Console.WriteLine("\nLivros cadastrados:");
                foreach (var livro in livros)
                {
                    Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Ano: {livro.Ano}, Gênero: {livro.Genero}, Quantidade: {livro.Quantidade}");
                    Console.WriteLine($"Resumo: {livro.Resumo}.\n\n");
                }
                goto returnADM;
            case 3:
                if (livros.Count > 0)
                {
                    Console.WriteLine("\nLivros disponíveis:");
                    for (int i = 0; i < livros.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}) Título: {livros[i].Titulo}, Autor: {livros[i].Autor}, Ano: {livros[i].Ano}, GÊnero: {livros[i].Genero}, Quantidade: {livros[i].Quantidade}");
                    }

                    Console.Write("Digite o número do livro que deseja retirar uma unidade: ");
                    if (int.TryParse(Console.ReadLine(), out int indice) && indice > 0 && indice <= livros.Count)
                    {
                        if (livros[indice - 1].Quantidade > 0)
                        {
                            livros[indice - 1].Quantidade--;
                            Console.WriteLine("Uma unidade do livro foi retirada com sucesso.");
                        }
                        else
                        {
                            Console.WriteLine("Não há unidades disponíveis para retirar.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Número inválido.");
                    }
                }
                else
                {
                    Console.WriteLine("Nenhum livro disponível para remoção.");
                }
                goto returnADM;
            case 4:
                Console.WriteLine("Saindo...");
                goto returnGeral;
            default:
                Console.WriteLine("Opção inválida!");
                goto returnGeral;
        }

    returnUsuario:
        do
        {
            Console.Clear();
            Console.WriteLine("1) Catálogo");
            Console.WriteLine("2) Empréstimo");
            Console.WriteLine("3) Devolução");
            Console.WriteLine("9) Sair");
            if (!int.TryParse(Console.ReadLine(), out opcao) || (opcao < 1 && opcao != 9))
            {
                Console.WriteLine("\nNúmero inválido!");
            }
        }
        while (opcao < 1 && opcao != 9);

        switch (opcao)
        {
            case 1:
                int continuar;
                do
                {
                    if (livros.Count <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Nenhum livro disponível no catálogo.");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\nLivros cadastrados:");
                        foreach (var livro in livros)
                        {
                            Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Ano: {livro.Ano}, Gênero: {livro.Genero}, Quantidade: {livro.Quantidade}");
                            Console.WriteLine($"Resumo: {livro.Resumo}.\n\n");
                        }
                    }

                    Console.WriteLine("\n\nDeseja sair?");
                    Console.WriteLine("1) Sim");
                    Console.WriteLine("2) Não");
                    int.TryParse(Console.ReadLine(), out continuar);
                }
                while (continuar != 1);
                goto returnUsuario;
            case 2:
                if (livros.Count > 0)
                {
                    Console.WriteLine("\nLivros disponíveis para empréstimo:");
                    for (int i = 0; i < livros.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}) Título: {livros[i].Titulo}, Quantidade: {livros[i].Quantidade}");
                    }

                    Console.Write("Digite o número do livro que deseja pegar emprestado: ");
                    if (int.TryParse(Console.ReadLine(), out int indice) && indice > 0 && indice <= livros.Count)
                    {
                        if (livros[indice - 1].Quantidade > 0)
                        {
                            livros[indice - 1].Quantidade--;
                            Console.WriteLine("Empréstimo realizado.");
                        }
                        else
                        {
                            Console.WriteLine("Livro indisponível para empréstimo.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Número inválido.");
                    }
                }
                else
                {
                    Console.WriteLine("Nenhum livro disponível para empréstimo.");
                }
                goto returnUsuario;
            case 3:
                if (livros.Count > 0)
                {
                    Console.WriteLine("\nLivros emprestados:");
                    for (int i = 0; i < livros.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}) Título: {livros[i].Titulo}, Quantidade emprestada: {livros[i].Quantidade}");
                    }

                    Console.Write("Digite o número do livro que deseja devolver: ");
                    if (int.TryParse(Console.ReadLine(), out int indice) && indice > 0 && indice <= livros.Count)
                    {
                        livros[indice - 1].Quantidade++;
                        Console.WriteLine("Devolução realizada.");
                    }
                    else
                    {
                        Console.WriteLine("Número inválido.");
                    }
                }
                else
                {
                    Console.WriteLine("Nenhum livro disponível para devolução.");
                }
                goto returnUsuario;
            case 9:
                Console.WriteLine("Saindo...");
                goto returnGeral;
            default:
                Console.WriteLine("Opção inválida!");
                goto returnGeral;
        }
    }
}
