using System;

class Program1
{
    static void Main()
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();

        int contadorEspacos = 0;
        foreach (char caracter in frase)
        {
            if (caracter == ' ')
            {
                contadorEspacos++;
            }
        }

        Console.WriteLine("Número de espaços em branco na frase: " + contadorEspacos);
    }
}
