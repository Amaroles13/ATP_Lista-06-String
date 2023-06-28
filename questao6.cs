using System;
using System.IO;

class Program6
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        int somaDivisores = 0;
        string divisores = "";

        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                somaDivisores += i;
                divisores += i + " ";
            }
        }

        Console.WriteLine("Divisores de " + numero + ": " + divisores);
        Console.WriteLine("Soma total dos divisores: " + somaDivisores);

        SalvarSomaDivisoresEmArquivo(somaDivisores);
    }

    static void SalvarSomaDivisoresEmArquivo(int somaDivisores)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter("soma_divisores.txt"))
            {
                sw.WriteLine("Soma total dos divisores: " + somaDivisores);
            }

            Console.WriteLine("Soma dos divisores salva no arquivo 'soma_divisores.txt'.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Ocorreu um erro ao salvar no arquivo: " + e.Message);
        }
    }
}
