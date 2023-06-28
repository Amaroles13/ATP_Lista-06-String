using System;
using System.IO;

class Program7
{
    static void Main()
    {
        Console.Write("Digite a quantidade de letras a serem inseridas: ");
        int quantidadeLetras = Convert.ToInt32(Console.ReadLine());

        InserirLetrasEmArquivo(quantidadeLetras);

        int quantidadeVogais = CalcularQuantidadeVogais();

        Console.WriteLine("Quantidade de vogais no arquivo: " + quantidadeVogais);
    }

    static void InserirLetrasEmArquivo(int quantidadeLetras)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter("letras.txt"))
            {
                for (int i = 0; i < quantidadeLetras; i++)
                {
                    Console.Write("Digite a letra #{0}: ", i + 1);
                    char letra = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    sw.WriteLine(letra);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Ocorreu um erro ao escrever no arquivo: " + e.Message);
        }
    }

    static int CalcularQuantidadeVogais()
    {
        int quantidadeVogais = 0;

        try
        {
            using (StreamReader sr = new StreamReader("letras.txt"))
            {
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    foreach (char caracter in linha)
                    {
                        if (IsVogal(caracter))
                        {
                            quantidadeVogais++;
                        }
                    }
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

        return quantidadeVogais;
    }

    static bool IsVogal(char letra)
    {
        letra = char.ToLower(letra);

        return letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u';
    }
}
 