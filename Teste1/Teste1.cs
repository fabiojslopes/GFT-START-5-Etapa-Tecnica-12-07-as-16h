/*1. Utilizando laços de repetição crie uma aplicação que receba a idade e o peso de 10
    pessoas. Calcule e mostre as médias dos pesos das pessoas da mesma faixa etária.
    As faixas etárias são: de 1 a 10 anos, de 11 a 20 anos, de 21 a 30 anos e maiores de
    31 anos.(Vale 2 pontos)*/

internal class Teste1
{
    public Teste1(int v1, string v2, decimal v3)
    {
    }

    public object saldo { get; internal set; }

    private static void Main(string[] args)
    {
        double[] Idade = new double[10];
        double Media = 0;
        double Quantidade = 0;
        double percentual = 0;
        double[] Peso = new double[10];
        double[] Altura = new double[10];

        for (int i = 0; i < Idade.Length; i++)
        {
            Console.WriteLine($"Insira as idades da {i + 1}º pessoa:  ");
            Idade[i] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Insira as Peso da {i + 1}º pessoa:  ");
            Peso[i] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Insira as Altura da {i + 1}º pessoa:  ");
            Altura[i] = Convert.ToDouble(Console.ReadLine());

            Media = Media + Altura[i];

            if (Idade[i] >= 31)
            {
                Quantidade = Quantidade + 1;
            }


            if (Peso[i] <= 30)
            {

                Console.WriteLine($"Porcentual de peso, do {i + 1}º Individo(s) {percentual}% para o {Peso}Kg");

            }

            if (Idade[i] > 10 && Idade[i] < 20)
            {
                Media = Media / Idade.Length;
            }

        }

        Console.WriteLine($"Media da altura da pessoas entre 10 a 20 anos é {Media}");

        Console.WriteLine($"Existem {Quantidade} que são maiores de idade, ou apartir dos 31 anos");

        }

    internal object CalcularImposto()
    {
        throw new NotImplementedException();
    }

    internal void Rendimento(object saldo)
    {
        throw new NotImplementedException();
    }
}
