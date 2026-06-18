public class Program
{
    private static void ConverterRomanoParaDecimal()
    {
        string numeroRomano = "";
        do
        {
            Console.Clear();
            Console.WriteLine("Digite um número romano (I, V, X, L, C, D, M) para converter para decimal:");
            numeroRomano = Console.ReadLine() ?? "";
        } while (!ValidarNumeroRomano(numeroRomano));

        int numeroDecimal = ConversorDeNumerosRomanos(numeroRomano);
        Console.WriteLine($"O número decimal correspondente é: {numeroDecimal}");
    }

    private static bool ValidarNumeroRomano(string numeroRomano)
    {
        if (string.IsNullOrEmpty(numeroRomano))
            return false;

        foreach (char c in numeroRomano)
        {
            switch (c)
            {
                case 'I':
                case 'V':
                case 'X':
                case 'L':
                case 'C':
                case 'D':
                case 'M':
                    break;
                default:
                    return false;
            }
        }

        return true;
    }

    private static int ConversorDeNumerosRomanos(string numeroRomano)
    {
        int valorDecimal = 0;
        int valorAnterior = 0;

        for (int i = numeroRomano.Length - 1; i >= 0; i--)
        {
            char simbolo = numeroRomano[i];
            int valorAtual = ObterValorDecimal(simbolo);

            if (valorAtual < valorAnterior)
            {
                valorDecimal -= valorAtual;
            }
            else
            {
                valorDecimal += valorAtual;
            }

            valorAnterior = valorAtual;
        }

        return valorDecimal;
    }

    private static int ObterValorDecimal(char simbolo)
    {
        switch (simbolo)
        {
            case 'I':
                return 1;
            case 'V':
                return 5;
            case 'X':
                return 10;
            case 'L':
                return 50;
            case 'C':
                return 100;
            case 'D':
                return 500;
            case 'M':
                return 1000;
            default:
                throw new ArgumentException("Símbolo romano inválido");
        }
    }

    private static void ConverterDecimalParaRomano()
    {
        int numeroDecimal = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("Digite um número decimal inteiro entre 1 e 3999 para converter para romano:");
            numeroDecimal = int.Parse(Console.ReadLine() ?? "0");
        } while (numeroDecimal < 1 || numeroDecimal > 3999);

        string numeroRomano = ConversorDeNumeros(numeroDecimal);
        Console.WriteLine($"O número romano correspondente é: {numeroRomano}");
    }

    private static string ConversorDeNumeros(int numeroDecimal)
    {
        string[] unidades = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        string[] dezenas = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        string[] centenas = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        string[] milhares = { "", "M", "MM", "MMM" };

        string numeroRomano = milhares[numeroDecimal / 1000] +
                             centenas[(numeroDecimal % 1000) / 100] +
                             dezenas[(numeroDecimal % 100) / 10] +
                             unidades[numeroDecimal % 10];

        return numeroRomano;
    }

    public static void Main(string[] args)
    {
        int tentarNovamente = 0;
        do
        {
            int escolha = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Digite 1 para converter um número decimal para romano ou 2 para converter um número romano para decimal:");
                escolha = int.Parse(Console.ReadLine() ?? "0");
            }
            while (escolha != 1 && escolha != 2);

            switch (escolha)
            {
                case 1:
                    ConverterDecimalParaRomano();
                    break;
                case 2:
                    ConverterRomanoParaDecimal();
                    break;
            }

            do
            {
                Console.WriteLine("Digite 1 para tentar novamente ou 2 para sair:");
                tentarNovamente = int.Parse(Console.ReadLine() ?? "0");
            } while (tentarNovamente != 1 && tentarNovamente != 2);

        } while (tentarNovamente == 1);
    }
}