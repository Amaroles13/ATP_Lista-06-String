using System;
using System.IO;

class Program9
{
    static void Main()
    {
        Console.WriteLine("Programa de Cadastro de Alunos");

        while (true)
        {
            Console.WriteLine("\nOpções:");
            Console.WriteLine("1. Inserir dados de alunos");
            Console.WriteLine("2. Ler dados de alunos de um arquivo");
            Console.WriteLine("3. Sair");
            Console.Write("Digite a opção desejada: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    InserirDadosAlunos();
                    break;
                case "2":
                    LerDadosAlunos();
                    break;
                case "3":
                    Console.WriteLine("Encerrando o programa...");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void InserirDadosAlunos()
    {
        try
        {
            using (StreamWriter sw = new StreamWriter("alunos.txt", true))
            {
                Console.WriteLine("\nInserção de Dados de Alunos");
                Console.WriteLine("Pressione Enter em branco para encerrar a inserção de dados.");

                while (true)
                {
                    Console.Write("\nDigite a Matrícula do Aluno: ");
                    string matricula = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(matricula))
                    {
                        Console.WriteLine("Inserção de dados concluída.");
                        break;
                    }

                    Console.Write("Digite o Telefone do Aluno: ");
                    string telefone = Console.ReadLine();

                    sw.WriteLine(matricula + "," + telefone);
                }
            }

            Console.WriteLine("Dados de alunos armazenados com sucesso no arquivo 'alunos.txt'.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Ocorreu um erro ao escrever no arquivo: " + e.Message);
        }
    }

    static void LerDadosAlunos()
    {
        try
        {
            using (StreamReader sr = new StreamReader("alunos.txt"))
            {
                Console.WriteLine("\nDados de Alunos");

                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    string[] dados = linha.Split(',');

                    string matricula = dados[0];
                    string telefone = dados[1];

                    Console.WriteLine("Matrícula: " + matricula + ", Telefone: " + telefone);
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Arquivo não encontrado.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Ocorreu um erro ao ler o arquivo: " + e.Message);
        }
    }
}
