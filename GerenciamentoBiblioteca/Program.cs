using System;
using System.Collections.Generic;

public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Ano { get; set; }
    public string Resumo { get; set; }
    public int Quantidade { get; set; }

    public Livro(string titulo, string autor, int ano, string resumo, int quantidade)
    {
        Titulo = titulo;
        Autor = autor;
        Ano = ano;
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
                if (!int.TryParse(Console.ReadLine(), out escolha))
                {
                    Console.WriteLine("\nNúmero inválido!");
                }
            }
            while (escolha != 1 && escolha != 2);
        switch (escolha)
        {
            case 1:
                returnADM:
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("O que deseja fazer: ");
                        Console.WriteLine("1) Cadastrar livro");
                        Console.WriteLine("2) Remover livro");
                        Console.WriteLine("3) Sair");
                        if (!int.TryParse(Console.ReadLine(), out opcao))
                        {
                            Console.WriteLine("\nNúmero inválido!");
                        }
                    }
                    while (opcao < 1 && opcao > 3);
                switch (opcao)
                {
                    case 1:
                        int continuar;
                        do
                        {
                            Console.Write("Digite o título do livro: ");
                            string titulo = Console.ReadLine();
                            Console.Write("Digite o autor do livro: ");
                            string autor = Console.ReadLine();
                            Console.Write("Digite o ano de publicação: ");
                            int ano = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Digite o resumo do livro {titulo}:");
                            string resumo = Console.ReadLine();
                            Console.Write("Digite a quantidade de livros disponíveis: ");
                            int quantidade = int.Parse(Console.ReadLine());
                            livros.Add(new Livro(titulo, autor, ano, resumo, quantidade));
                            Console.WriteLine("Você deseja adicionar outro livro?");
                            Console.WriteLine("1) Sim");
                            Console.WriteLine("2) Não");
                            int.TryParse(Console.ReadLine(), out continuar);
                        }
                        while (continuar == 1);
                        Console.WriteLine("\nLivros cadastrados:");
                        foreach (var livro in livros)
                        {
                            Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Ano: {livro.Ano}, Quantidade: {livro.Quantidade}");
                        }

                        goto returnADM;
                    case 2:
                        if (livros.Count > 0)
                        {
                            Console.WriteLine("\nLivros disponíveis:");
                            for (int i = 0; i < livros.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}) Título: {livros[i].Titulo}, Autor: {livros[i].Autor}, Ano: {livros[i].Ano}");
                            }

                            Console.Write("Digite o número do livro que deseja remover: ");
                            int indice;
                            if (int.TryParse(Console.ReadLine(), out indice) && indice > 0 && indice <= livros.Count)
                            {
                                livros.RemoveAt(indice - 1);
                                Console.WriteLine("Livro removido com sucesso.");
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
                    case 3:
                        Console.WriteLine("Saindo...");
                        goto returnGeral;
                    default:
                        Console.WriteLine("Opção inválida!");
                        goto returnGeral;
                }

            case 2:
                returnUsuario:
                    Console.WriteLine("1) Catálogo");
                    Console.WriteLine("2) Empréstimo");
                    Console.WriteLine("3) Devolução");
                    Console.WriteLine("9) Sair");
                    if (!int.TryParse(Console.ReadLine(), out opcao))
                    {
                        Console.WriteLine("\nNúmero inválido!");
                    }

                switch (opcao)
                {
                    case 1:
                    if (livros.Count > 0)
                    {
                        Console.WriteLine("Nenhum livro disponível no catálogo.");
                    }
                    else
                    {
                        Console.WriteLine("\nLivros cadastrados:");
                        foreach (var livro in livros)
                        {
                            Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Ano: {livro.Ano}, Quantidade: {livro.Quantidade}");
                        }
                    }
                        goto returnUsuario;
                    case 9:
                        Console.WriteLine("saindo...");
                        goto returnGeral;
                }
            goto returnGeral;
            case 3: 
             Console.WriteLine("saindo...");
             break;  
        }
    }
}
