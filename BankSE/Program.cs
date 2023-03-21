using BankSE.Conta;
using BankSE.Titular;

try
{
    ContaCorrente conta1 = new ContaCorrente(0, "1234-d");

}
catch (ArgumentException ex)
{
    Console.WriteLine("Parametro com erro: " + ex.ParamName);
    Console.WriteLine("Não é possivel criar uma conta com o número 0.");
    Console.WriteLine(ex.Message);
}


