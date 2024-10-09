using System;
using System.Collections.Generic;

public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Ano { get; set; }

    public Livro(string titulo, string autor, int ano)
    {
        Titulo = titulo;
        Autor = autor;
        Ano = ano;
    }
}

class Program
{
    static void Main()
    {
        List<Livro> livros = new List<Livro>();
        int escolha;
        int opcao = 0; 
        do
        {
            Console.Clear();
            Console.WriteLine("Você é:");
            Console.WriteLine("1) Administrador");
            Console.WriteLine("2) Usuário");
            if (!int.TryParse(Console.ReadLine(), out escolha))
            {
                Console.WriteLine("\nNúmero inválido!");
            }
        }
        while (escolha != 1 && escolha != 2); 

        switch (escolha)
        {
            case 1:
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
                                livros.Add(new Livro(titulo, autor, ano));

                                Console.WriteLine("Você deseja adicionar outro livro?");
                                Console.WriteLine("1) Sim");
                                Console.WriteLine("2) Não");
                                int.TryParse(Console.ReadLine(), out continuar);
                            }
                            while (continuar == 1);

                            Console.WriteLine("\nLivros cadastrados:");
                            foreach (var livro in livros)
                            {
                                Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Ano: {livro.Ano}");
                            }
                            break;

                        case 2: 
                            if (livros.Count > 0)
                            {
                                Console.WriteLine("\nLivros disponíveis para remoção:");
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
                            break;

                        case 3: 
                            Console.WriteLine("Saindo...");
                            break;

                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                }
                while (opcao != 3);
                break;

            case 2:
                Console.WriteLine("Você é um usuário. Função em construção.");
                break;
        }
    }
}
