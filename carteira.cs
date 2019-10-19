using System;
using System.IO;  

class carteira
{
  public double lucro_prejuizov= 0;
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


}
  


}
