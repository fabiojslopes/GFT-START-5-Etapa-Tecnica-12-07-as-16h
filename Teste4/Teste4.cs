/*4. A idade permitida para doar sangue é entre 18 e 67 anos. Faça um aplicativo que
pergunte a idade de uma pessoa e diga se ela pode doar sangue ou não. Use alguns
dos operadores lógicos OU (||) e E (&&).*/

Console.WriteLine("Por favor digite sua idade");
int Idade = 0;
Int32.TryParse(Console.ReadLine(), out Idade);
if (Idade < 18 || Idade > 67 )
{
    Console.WriteLine("Desculpe, você não pode doar sangue");
}
else
{
    Console.WriteLine("Você foi selecionado para doar sangue");
}
