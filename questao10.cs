using System;
using System.IO;
using System.Linq;

class Program10
{
    static void Main()
    {
        try
        {
            string nomeArquivo = "numeros.txt";
            double[] numeros = LerNumerosDoArquivo(nomeArquivo);

            if (numeros.Length > 0)
            {
                double valorMaximo = numeros.Max();
                double valorMinimo = numeros.Min();
                double media = numeros.Average();

                Console.WriteLine("Valor máximo: " + valorMaximo);
                Console.WriteLine("Valor mínimo: " + valorMinimo);
                Console.WriteLine("Média: " + media);
            }
            else
            {
                Console.WriteLine("O arquivo está vazio. Não há números para calcular.");
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Arquivo não encontrado.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Ocorreu um erro: " + e.Message);
        }
    }

    static double[] LerNumerosDoArquivo(string nomeArquivo)
    {
        string[] linhas = File.ReadAllLines(nomeArquivo);

        double[] numeros = new double[linhas.Length];

        for (int i = 0; i < linhas.Length; i++)
        {
            if (double.TryParse(linhas[i], out double numero))
            {
                numeros[i] = numero;
            }
            else
            {
                Console.WriteLine("Linha inválida: " + linhas[i]);
            }
        }

        return numeros;
    }
}
