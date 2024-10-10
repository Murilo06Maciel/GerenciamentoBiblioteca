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
        List<Livro> livros = new List<Livro>()
        {
            new Livro("A Divina Comédia", "Dante Alighieri", 1320, "Poema épico", "Dividido em três partes — Inferno, Purgatório e Paraíso — A Divina Comédia narra a jornada de Dante através do além. Ele é guiado por Virgílio no Inferno e no Purgatório e por Beatriz no Paraíso. Cada canto revela as almas de diferentes pecadores e virtuosos, refletindo a moralidade, a justiça divina e a busca por salvação. A obra é uma profunda meditação sobre a vida, a morte e a espiritualidade.", 10),
            new Livro("Hamlet", "William Shakespeare", 1603, "Tragédia", "Hamlet é a história do Príncipe da Dinamarca, que busca vingar a morte de seu pai, assassinado pelo tio, que agora ocupa o trono e se casou com a mãe de Hamlet. A peça explora a complexidade das emoções humanas, incluindo amor, traição, loucura e dúvida existencial. O famoso monólogo Ser ou não ser reflete as profundas questões sobre a vida e a morte que Hamlet enfrenta.", 10),
            new Livro("Dom Quixote", "Miguel de Cervantes", 1605, "Romance", "Dom Quixote segue as aventuras de um fidalgo, Alonso Quixano, que, obcecado por romances de cavalaria, decide se tornar um cavaleiro andante. Com seu fiel escudeiro Sancho Pança, ele luta contra moinhos de vento que confunde com gigantes e busca restaurar a justiça. A obra é uma crítica à sociedade da época e à linha entre realidade e ilusão, questionando os ideais de heroísmo e sanidade.", 10),
            new Livro("Fausto", "Johann Wolfgang von Goethe", 1808, "Tragédia", "Dom Quixote segue as aventuras de um fidalgo, Alonso Quixano, que, obcecado por romances de cavalaria, decide se tornar um cavaleiro andante. Com seu fiel escudeiro Sancho Pança, ele luta contra moinhos de vento que confunde com gigantes e busca restaurar a justiça. A obra é uma crítica à sociedade da época e à linha entre realidade e ilusão, questionando os ideais de heroísmo e sanidade.", 10),
            new Livro("Orgulho e Preconceito", "Jane Austen", 1813, "Romance", "A história segue Elizabeth Bennet, uma jovem inteligente e forte, que navega as complexidades das relações sociais e amorosas no início do século XIX. Ao conhecer Mr. Darcy, um homem orgulhoso, Elizabeth enfrenta seus próprios preconceitos e descobre verdades sobre classe, moralidade e amor. A obra é uma crítica social envolta em humor e romance.", 10),
            new Livro("Frankenstein", "Mary Shelley", 1818, "Ficção Científica, Gótico", "Victor Frankenstein, um jovem cientista, cria um ser a partir de partes de cadáveres. Ao perceber que sua criação é monstruosa e rejeitada pela sociedade, o monstro busca aceitação, mas é constantemente perseguido pelo desprezo. A história aborda temas de criação, responsabilidade e as consequências da ambição desenfreada, questionando o que significa ser humano.", 10),
            new Livro("Os Três Mosqueteiros", "Alexandre Dumas", 1844, "Aventura, Romance", "A história segue d'Artagnan, um jovem que se junta aos mosqueteiros do rei da França. Ele se une a Athos, Porthos e Aramis em aventuras cheias de intrigas políticas e batalhas, enquanto luta contra o cardeal Richelieu e seus planos. O romance explora a amizade, a lealdade e o heroísmo, ao mesmo tempo em que oferece uma crítica à política da época.", 10),
            new Livro("O Corvo", "Edgar Allan Poe", 1845, "Poesia, Gótico", "Este poema narrativo conta a história de um homem que, em um momento de luto pela perda de sua amada Lenore, é visitado por um corvo que fala. A presença do corvo simboliza a morte e a desesperança, enquanto o protagonista luta com sua dor e a inevitabilidade da perda. O poema é um exemplo do estilo gótico de Poe, explorando o desespero e a loucura.", 10),
            new Livro("Moby Dick", "Herman Melville", 1851, "Ficção, Aventura", "A história gira em torno do Capitão Ahab, que busca vingar-se da baleia branca Moby Dick, que lhe arrancou a perna. A obra é uma profunda meditação sobre a natureza, a obsessão e a condição humana, explorando as complexidades do ser humano frente à força da natureza e o destino. A narrativa é rica em simbolismo e filosofia.", 10),
            new Livro("Madame Bovary", "Gustave Flaubert", 1856, "Romance", "A vida de Emma Bovary, uma mulher insatisfeita com seu casamento e que busca a felicidade através de romances extraconjugais, culminando em tragédia. A obra critica a vida burguesa, a busca por ideais românticos e as consequências da insatisfação. Flaubert utiliza uma prosa detalhada para explorar os desejos e frustrações de sua protagonista.", 10),
            new Livro("As Flores do Mal", "Charles Baudelaire", 1857, "Poesia", "Esta coleção de poemas é um marco do simbolismo e explora a dualidade da beleza e da decadência. Baudelaire investiga a experiência moderna, a vida urbana e os contrastes entre a vida e a morte, o bem e o mal. Seus versos desafiam convenções e exploram os dilemas da alma humana, da sensualidade e da arte.", 10),
            new Livro("Os Miseráveis", "Victor Hugo", 1862, "Romance, Drama", "A história de Jean Valjean, um ex-prisioneiro que busca redenção e se depara com a injustiça social na França do século XIX. A narrativa interliga diversos personagens, como Fantine e Javert, em uma crítica ao sistema social e político da época. A obra explora temas de amor, sacrifício e a luta por justiça.", 10),
            new Livro("O Médico e o Monstro", "Robert Louis Stevenson", 1886, "Ficção Científica, Gótico", "A luta entre Dr. Jekyll e seu alter ego, Mr. Hyde, representa a dualidade da natureza humana. Jekyll, um médico respeitável, cria uma poção que libera sua parte sombria. A história explora temas de identidade, moralidade e a batalha entre o bem e o mal dentro de cada pessoa.", 10),
            new Livro("O Retrato de Dorian Gray", "Oscar Wilde", 1890, "Ficção, Gótico", "Dorian Gray, um jovem belo, faz um pacto para manter sua juventude e beleza, enquanto seu retrato envelhece. À medida que Dorian se entrega a excessos e depravações, a obra explora a moralidade, a estética e as consequências do hedonismo, questionando a natureza da beleza e do bem.", 10),
            new Livro("Em Busca do Tempo Perdido", "Marcel Proust", 1913, "Romance", "A obra se concentra nas memórias de Marcel, um narrador que reflete sobre sua vida, amores e a sociedade francesa. A narrativa é famosa por sua prosa introspectiva e detalhada, explorando a passagem do tempo, a memória involuntária e as complexidades das relações humanas. É uma meditação sobre a arte, a percepção e o significado da vida.", 10),
            new Livro("Ulisses", "James Joyce", 1922, "Ficção, Modernismo", "", 10),
            new Livro("Mrs. Dalloway", "Virginia Woolf", 1925, "Ficção, Modernismo", "", 10),
            new Livro("Admirável Mundo Novo", "Aldous Huxley", 1932, "Ficção Científica, Distopia", "", 10),
            new Livro("1984", "George Orwell", 1949, "Distopia, Ficção Científica", "", 10)
        };
        int escolha;
        int opcao = 0;

    returnGeral:
        do
        {
            Console.Clear();
            Console.WriteLine("|------ BIBLIOTECA ------|\n\n");
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
            if (!int.TryParse(Console.ReadLine(), out opcao) || (opcao < 1 || opcao > 4))
            {
                Console.WriteLine("\nNúmero inválido!");
            }
        }
        while (opcao < 1 || opcao > 4);

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
                            Console.WriteLine($"\nTítulo: {livro.Titulo};\nAutor: {livro.Autor};\nAno: {livro.Ano};\nGênero: {livro.Genero};\nQuantidade: {livro.Quantidade};");
                            Console.WriteLine($"\nResumo: {livro.Resumo};\n\n");
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
                    Console.WriteLine($"\nTítulo: {livro.Titulo};\nAutor: {livro.Autor};\nAno: {livro.Ano};\nGênero: {livro.Genero};\nQuantidade: {livro.Quantidade};");
                    Console.WriteLine($"\nResumo: {livro.Resumo};\n\n");
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
                            Console.WriteLine($"\nTítulo: {livro.Titulo};\nAutor: {livro.Autor};\nAno: {livro.Ano};\nGênero: {livro.Genero};\nQuantidade: {livro.Quantidade};");
                            Console.WriteLine($"\nResumo: {livro.Resumo};\n\n");
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
                int totalEmprestados = 0; 
                if (livros.Count > 0)
                {
                    do
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
                                if (totalEmprestados < 3) 
                                {
                                    livros[indice - 1].Quantidade--;
                                    totalEmprestados++;
                                    Console.WriteLine("Empréstimo realizado.");
                                }
                                else
                                {
                                    Console.WriteLine("Você já pegou o máximo de 3 livros emprestados.");
                                }
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

                        Console.WriteLine("\nDeseja pegar mais um livro emprestado?");
                        Console.WriteLine("1) Sim");
                        Console.WriteLine("2) Não");
                        if (int.TryParse(Console.ReadLine(), out continuar) && continuar == 2)
                        {
                            break;
                        }
                    }
                    while (true);
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