using System;

class Program3
{
    static void Main()
    {
        Console.Write("Digite uma string: ");
        string texto = Console.ReadLine();

        string textoCodificado = CodificarCesar(texto, 3);

        Console.WriteLine("Nova string codificada: " + textoCodificado);
    }

    static string CodificarCesar(string texto, int deslocamento)
    {
        string textoCodificado = "";

        foreach (char caracter in texto)
        {
            if (char.IsLetter(caracter))
            {
                char caracterCodificado = (char)(caracter + deslocamento);

                if (!char.IsLetter(caracterCodificado))
                {
                    caracterCodificado = (char)(caracterCodificado - 26);
                }

                textoCodificado += caracterCodificado;
            }
            else
            {
                textoCodificado += caracter;
            }
        }

        return textoCodificado;
    }
}
