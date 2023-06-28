using System;
using System.IO;

class Program8
{
    static void Main()
    {
        Console.Write("Digite a quantidade de veículos da locadora: ");
        int quantidadeVeiculos = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o valor do aluguel por veículo: R$");
        double valorAluguel = Convert.ToDouble(Console.ReadLine());

        double faturamentoAnual = CalcularFaturamentoAnual(quantidadeVeiculos, valorAluguel);
        double valorMultasMensal = CalcularValorMultasMensal(quantidadeVeiculos, valorAluguel);
        double valorManutencaoAnual = CalcularValorManutencaoAnual(quantidadeVeiculos);

        GravarResultado(faturamentoAnual, valorMultasMensal, valorManutencaoAnual);

        Console.WriteLine("Faturamento Anual: R$" + faturamentoAnual.ToString("F2"));
        Console.WriteLine("Valor das Multas no Mês: R$" + valorMultasMensal.ToString("F2"));
        Console.WriteLine("Valor da Manutenção Anual: R$" + valorManutencaoAnual.ToString("F2"));
        Console.WriteLine("Resultados gravados no arquivo 'resultado.txt'");
    }

    static double CalcularFaturamentoAnual(int quantidadeVeiculos, double valorAluguel)
    {
        int veiculosAlugadosPorMes = quantidadeVeiculos / 3;
        int mesesAno = 12;

        double faturamentoAnual = veiculosAlugadosPorMes * valorAluguel * mesesAno;

        return faturamentoAnual;
    }

    static double CalcularValorMultasMensal(int quantidadeVeiculos, double valorAluguel)
    {
        int veiculosAlugadosPorMes = quantidadeVeiculos / 3;
        int veiculosDevolvidosAtrasados = veiculosAlugadosPorMes / 10;

        double valorMultasMensal = veiculosDevolvidosAtrasados * valorAluguel * 0.2;

        return valorMultasMensal;
    }

    static double CalcularValorManutencaoAnual(int quantidadeVeiculos)
    {
        int veiculosManutencaoAnual = quantidadeVeiculos * 2 / 100;
        double valorManutencao = 600.0;

        double valorManutencaoAnual = veiculosManutencaoAnual * valorManutencao;

        return valorManutencaoAnual;
    }

    static void GravarResultado(double faturamentoAnual, double valorMultasMensal, double valorManutencaoAnual)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter("resultado.txt"))
            {
                sw.WriteLine("Faturamento Anual: R$" + faturamentoAnual.ToString("F2"));
                sw.WriteLine("Valor das Multas no Mês: R$" + valorMultasMensal.ToString("F2"));
                sw.WriteLine("Valor da Manutenção Anual: R$" + valorManutencaoAnual.ToString("F2"));
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Ocorreu um erro ao gravar o arquivo: " + e.Message);
        }
    }
}
