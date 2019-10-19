using System;
using System.IO;  

class investimentos
{
  public double ativos_fisicos;
  public string tesouro_direto;
  public string acoes;
  public string poupanca;

  public void Recomendacao_Inicial(carteira b) {
    if (b.GetSaldo_inicial() <= 0){
      Console.WriteLine();
      Console.WriteLine("OK, não tem problema!");
      Console.WriteLine("Podemos te explicar um pouco sobre finanças, o que acha?");
      Console.WriteLine();
      Console.WriteLine("No Menu Principal você pode escolher a opção EDUCAÇÃO FINANCEIRA");
      Console.WriteLine();
      Console.WriteLine();
      Menu_De_Investimentos();
    }
    if (b.GetSaldo_inicial() > 0){
      Menu_De_Investimentos();
    }
  }

  public void Menu_De_Investimentos(){
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine();
    Console.WriteLine("1 - Ativos físicos");
    Console.WriteLine("2 - Tesouro direto");
    Console.WriteLine("3 - Ações");
    Console.WriteLine("4 - Poupança");
    Console.WriteLine("5 - IR PARA ABA DE EDUCAÇÃO FINANCEIRA");
    Console.WriteLine("6 - Fazer SIMULAÇÕS de investimentos");
    string lerresposta = Console.ReadLine();

      if (lerresposta == "1"){
        AtivosFisicos();
      }
      if (lerresposta == "2"){
        Tesouro();
      }
      if (lerresposta == "3"){
        SetAcoes();
      }
      if (lerresposta == "5"){
        Educacao();
      }
      if (lerresposta == "6"){
        Simulacao();
      }
  }

  public void Educacao(){
   Console.WriteLine("calma, ja te ajudo.");
  }

  public void Tesouro(){
   Console.WriteLine("calma, ja te ajudo.");
  }

  public void SetAcoes(){
   Console.WriteLine("calma, ja te ajudo.");
  }

  public void AtivosFisicos(){
    Console.WriteLine("Escolha uma Opção:");
    Console.WriteLine();
    Console.WriteLine("1 - Adicionar um investimentos em   ativos físicos");
    Console.WriteLine("2 - Explicação e fatos relevantes sobre Ativos Fisicos");
    string ler1 = Console.ReadLine();
    if(ler1 == "1"){
    Console.WriteLine("Digite o valor que queira adicionar");
    double add1 = double.Parse(Console.ReadLine());
    ativos_fisicos = ativos_fisicos+add1;
    }
    if(ler1 == "2"){
    // EM CONSTRUÇÃO
    
    }
  }

  public void Simulacao(){
   Console.WriteLine("calma, ja te ajudo.");
   }
  





}
