using System;

class Program2
{
    static void Main()
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();

        string fraseSemVogais = RemoverVogais(frase);

        Console.WriteLine("Frase sem as vogais: " + fraseSemVogais);
    }

    static string RemoverVogais(string frase)
    {
        string vogais = "aeiouAEIOU";
        string fraseSemVogais = "";

        foreach (char caracter in frase)
        {
            if (!vogais.Contains(caracter.ToString()))
            {
                fraseSemVogais += caracter;
            }
        }

        return fraseSemVogais;
    }
}
