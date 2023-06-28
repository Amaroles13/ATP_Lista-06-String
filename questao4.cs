using System;
using System.IO;

class Program4
{
    static void Main()
    {
        Console.Write("Digite o caminho do arquivo de texto: ");
        string caminhoArquivo = Console.ReadLine();

        int quantidadeCaracteresA = ContarCaracteresA(caminhoArquivo);

        Console.WriteLine("Quantidade de caracteres 'a' no arquivo: " + quantidadeCaracteresA);
    }

    static int ContarCaracteresA(string caminhoArquivo)
    {
        int quantidadeCaracteresA = 0;

        try
        {
            using (StreamReader sr = new StreamReader(caminhoArquivo))
            {
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    quantidadeCaracteresA += ContarCaracteresAEmLinha(linha);
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

        return quantidadeCaracteresA;
    }

    static int ContarCaracteresAEmLinha(string linha)
    {
        int quantidadeCaracteresA = 0;

        foreach (char caracter in linha)
        {
            if (caracter == 'a')
            {
                quantidadeCaracteresA++;
            }
        }

        return quantidadeCaracteresA;
    }
}
