using BankSE;
using BankSE.Conta;
using BankSE.Titular;

try
{
    ContaCorrente conta1 = new ContaCorrente(278, "1234-d");
    conta1.Sacar(50);
    Console.WriteLine(conta1.GetSaldo());
    conta1.Sacar(150);
    Console.WriteLine(conta1.GetSaldo());



}
catch (ArgumentException ex)
{
    Console.WriteLine("Parametro com erro: " + ex.ParamName);
    Console.WriteLine("Não é possivel criar uma conta com o número 0.");
    Console.WriteLine(ex.Message);
}
catch(SaldoInsuficienteException ex)
{
    Console.WriteLine("Saldo insuficiente.");
    Console.WriteLine(ex.Message);
}


