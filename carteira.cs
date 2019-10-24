using System;
using System.IO;  

class carteira
{
  public double lucro_prejuizo= 0;
  public double rentabilidade = 0;
  private double saldo_inicial = 0;
  public string saldo = "";

  public void SetSaldo_inicial() {
  Console.WriteLine("Quanto de saldo disponível você tem para investir?");
  saldo_inicial = double.Parse(Console.ReadLine());
  }
  public double GetSaldo_inicial(){
    return saldo_inicial;
  }
  
  public void menucarteira (){
    Console.WriteLine("*************************************");
    Console.WriteLine("************* CARTEIRA **************");
    Console.WriteLine("*************************************");
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine();
    Console.WriteLine("1 - SALDO");
    Console.WriteLine("2 - RENTABILIDADE");
    Console.WriteLine("3 - Ações");
    Console.WriteLine("4 - Poupança");
    Console.WriteLine("5 - Voltar para Menu de Investimentos");
    Console.WriteLine("6 - Sair");
  
  }


}
