using System;
using System.IO;

class Program5
{
    static void Main()
    {
        Console.Write("Digite o caminho do arquivo de texto: ");
        string caminhoArquivo = Console.ReadLine();

        int quantidadeLinhas = ImprimirConteudoArquivo(caminhoArquivo);

        Console.WriteLine("Quantidade de linhas no arquivo: " + quantidadeLinhas);
    }

    static int ImprimirConteudoArquivo(string caminhoArquivo)
    {
        int quantidadeLinhas = 0;

        try
        {
            using (StreamReader sr = new StreamReader(caminhoArquivo))
            {
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                    quantidadeLinhas++;
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

        return quantidadeLinhas;
    }
}
