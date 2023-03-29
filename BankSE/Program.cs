using BankSE;
using BankSE.Conta;
using BankSE.Titular;
using ByteBank;

LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt");

try
{
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();
    leitor.Dispose();

}
catch (IOException)
{
    Console.WriteLine("Leitura de arquivo interrompida.");
}
finally
{
    leitor.Dispose();
}


/*
try
{
    ContaCorrente conta1 = new ContaCorrente(0, "1234-d");
    /*
    conta1.Sacar(50);
    Console.WriteLine(conta1.GetSaldo());
    conta1.Sacar(150);
    Console.WriteLine(conta1.GetSaldo());
 


}
catch (ArgumentException ex)
{
    Console.WriteLine("Parametro com erro: " + ex.ParamName);
    Console.WriteLine("Não é possivel criar uma conta com o número 0.");
    Console.WriteLine(ex.StackTrace);

    Console.WriteLine(ex.Message);
}

catch(SaldoInsuficienteException ex)
{
    Console.WriteLine("Saldo insuficiente.");
    Console.WriteLine(ex.Message);
}
*/


