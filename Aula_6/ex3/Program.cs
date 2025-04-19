using System;

class Program
{
    static string[] nomes = new string[5];
    static string[] poderes = new string[5];
    static int[] pontuacoes = new int[5];
    static string[] equipeNomes = new string[3];
    static string[] equipePoderes = new string[3];
    static int[] equipePontuacoes = new int[3];

    static void cadastrarHerois()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Cadastro do herói {i + 1}:");
            Console.Write("Nome: ");
            nomes[i] = Console.ReadLine();
            Console.Write("Poder: ");
            poderes[i] = Console.ReadLine();
            Console.Write("Pontuação: ");
            pontuacoes[i] = int.Parse(Console.ReadLine());
        }
    }

    static void selecionarEquipe()
    {
        Console.WriteLine("Seleção de equipe:");
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Escolha o número do herói (1 a 5): ");
            int escolha = int.Parse(Console.ReadLine()) - 1;
            if (escolha >= 0 && escolha < 5)
            {
                equipeNomes[i] = nomes[escolha];
                equipePoderes[i] = poderes[escolha];
                equipePontuacoes[i] = pontuacoes[escolha];
            }
            else
            {
                Console.WriteLine("Escolha inválida!");
                i--;
            }
        }
    }

    static int calcularPontuacaoTotal()
    {
        int total = 0;
        for (int i = 0; i < 3; i++)
        {
            total += equipePontuacoes[i];
        }
        return total;
    }

    static void exibirEquipe()
    {
        Console.WriteLine("Equipe selecionada:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{equipeNomes[i]} - {equipePoderes[i]} - Pontuação: {equipePontuacoes[i]}");
        }
    }

    static void exibirPontuacaoTotal()
    {
        int pontuacaoTotal = calcularPontuacaoTotal();
        Console.WriteLine($"Pontuação Total da Equipe: {pontuacaoTotal}");
    }

    static void menu()
    {
        int opcao;

        do
        {
            Console.WriteLine("1 - Cadastrar Heróis");
            Console.WriteLine("2 - Selecionar Equipe");
            Console.WriteLine("3 - Exibir Equipe");
            Console.WriteLine("4 - Exibir Pontuação Total da Equipe");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    cadastrarHerois();
                    break;
                case 2:
                    selecionarEquipe();
                    break;
                case 3:
                    exibirEquipe();
                    break;
                case 4:
                    exibirPontuacaoTotal();
                    break;
                case 5:
                    Console.WriteLine("Encerrando o programa.");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (opcao != 5);
    }

    static void Main()
    {
        menu();
    }
}