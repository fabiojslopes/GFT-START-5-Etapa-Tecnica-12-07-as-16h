/*2. Considerando os conceitos de Orientação a Objetos, crie uma classe abstrata Pai de
nome Conta com os seguintes atributos (número, titular e saldo) e mais duas classes
Filhas (ContaCorrente e ContaPoupanca). Na classe Conta deve existir um método
de nome rendimento que retorna o rendimento mensal da conta, nas classes filhas
deve existir o mesmo método rendimento, porém com as seguintes regras:
⦁ Para ContaCorrente, o método rendimento deve retornar o saldo * 0.03;
⦁ Para ContaPoupanca, o método rendimento deve retornar o saldo * 0.05;
Por fim, criar uma classe principal que instancie objetos de ContaCorrente e
ContaPoupanca, adicione no mínimo um valor para cada atributo e imprima cada
conta (ContaCorrente e ContaPoupanca) com seus devidos rendimentos.
Obs: Encapsular atributos das classes.*/

internal class Teste2
{
    private static void Main(string[] args)
    {
        Teste1 conta1 = new(1, "Carlos", 1000.00m);

        conta1.Rendimento(conta1.saldo);

        ContaPoupanca conta2 = new(2, "João", 1000.00m);

        conta2.Rendimento(conta2.saldo);

        List<Conta> contas = new();
 
        contas.Add(conta1);
        contas.Add(conta2);

        contas.ForEach(conta => Console.WriteLine($@"O dono da conta, que é {conta.Name}(número : {conta.numero}), 
        chama-se {conta.titular}. A conta possui rendimento de R${conta.rendimento:0.00} mensais"));

        Console.WriteLine($"A conta de número 1 pagará {conta1.CalcularImposto():0.00} de impostos");
        Console.WriteLine($"A conta de numero 2 pagará {conta2.CalcularImposto():0.00} de impostos");
    }
}
