public class Teste3
{
    public static void Teste()
    {
        ContaCorrente conta1 = new(1, "Carlos", 1000.00m);

        conta1.Rendimento(conta1.saldo);

        ContaPoupanca conta2 = new(2, "João", 1000.00m);

        conta2.Rendimento(conta2.saldo);

        List<Conta> contas = new();
 
        contas.Add(conta1);
        contas.Add(conta2);

        contas.ForEach(conta => Console.WriteLine($"O dono da conta, que é {conta.Name}(número : {conta.numero}), chama-se {conta.titular}. A conta possui rendimento de R${conta.rendimento:0.00} mensais"));

        Console.WriteLine($"A conta de número 1 pagará {conta1.CalcularImposto():0.00} de impostos");
        Console.WriteLine($"A conta de numero 2 pagará {conta2.CalcularImposto():0.00} de impostos");
    }
}
