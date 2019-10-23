using System;
using System.IO;  

class investimentos
{
  private double ativos_fisicos;
  public string tesouro_direto;
  public string acoes;
  public string poupanca;
  private double TaxaIPCA = 3.59;

  public double GetIPCA(){
    return TaxaIPCA;
  }

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
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("******************************************");
    Console.WriteLine("************* MENU PRINCIPAL**************");
    Console.WriteLine("******************************************");
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine();
    Console.WriteLine("1 - Ativos físicos");
    Console.WriteLine("2 - Tesouro direto");
    Console.WriteLine("3 - Ações");
    Console.WriteLine("4 - Poupança");
    Console.WriteLine("5 - MENU DE EDUCAÇÃO FINANCEIRA");
    Console.WriteLine("6 - Fazer SIMULAÇÕS de investimentos");
    Console.WriteLine("7 - SAIR DO PROGRAMA");
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
       if (lerresposta == "7"){
        Environment.Exit(0);
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
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("*****Adicionar um investimentos em ativos físicos***");
    Console.WriteLine("Digite o Valor que você deseja adicionar em ativos físicos: ");
    double ler1 = double.Parse(Console.ReadLine());
    ativos_fisicos = ativos_fisicos + ler1;
    Console.WriteLine("****ADICIONADO COM SUCESSO A SUA CARTEIRA*****");
    Menu_De_Investimentos();
  }

  public void Simulacao(){
   Console.WriteLine("Qual o tipo de investimento você deseja simular? ");
   Console.WriteLine("1 - Poupança");
   Console.WriteLine("2 - CDB");
   Console.WriteLine("3 - Tesouro Direto");
   Console.WriteLine("4 - TODOS");

   string escolha = Console.ReadLine();
    if(escolha == "1"){
      Console.WriteLine("Digite o valor que você quer fazerma simulação:");
      double valor = double.Parse(Console.ReadLine());
      Console.WriteLine("Por quanto tempo ( EM MESES ) você pretende deixar o seu dinheiro investido");
      double meses = double.Parse(Console.ReadLine());
      double result = (0.0037*valor*meses);
      Console.WriteLine("O SEU RENDIMENTO NA POUPANÇA SERA: "+ result + " REAIS!");
      Console.WriteLine("***************************");
      Console.WriteLine("ATENÇÃO!! AS TAXAS MUDAM, ESTAMOS LEVANDO EM CONTA TAXAS DE SETEMBRO DE 2019");
      Console.WriteLine("***************************");
      // Com base na TAXA SELIC do dia 21/10/2019
    }
    if(escolha == "2"){
      Console.WriteLine("Digite o valor que você quer fazer a simulação:");
      double valor = double.Parse(Console.ReadLine());
      Console.WriteLine("Por quanto tempo ( EM MESES ) você pretende deixar o seu dinheiro investido");
      double meses = double.Parse(Console.ReadLine());
      double result = 0.00458*meses*valor;
      Console.WriteLine("O SEU RENDIMENTO NA SERA: "+ result + " REAIS!");
      Console.WriteLine("***************************");
      Console.WriteLine("ATENÇÃO!! AS TAXAS MUDAM, ESTAMOS LEVANDO EM CONTA TAXAS DE SETEMBRO DE 2019");
      Console.WriteLine("***************************");
      //Com base na TAXA SELIC e CDI do dia 21/10/2019
    }

    if(escolha == "3"){
      Console.WriteLine("USAREMOS O TESOURO SELIC COMO REFERENCIA MÉDIA!!");
      Console.WriteLine("Digite o valor que você quer fazer a simulação:");
      double valor = double.Parse(Console.ReadLine());
      Console.WriteLine("Por quanto tempo ( EM MESES ) você pretende deixar o seu dinheiro investido");
      double meses = double.Parse(Console.ReadLine());
      double result = 0.0047*meses*valor;
      Console.WriteLine("O SEU RENDIMENTO NA SERA: "+ result + " REAIS!");
      Console.WriteLine("***************************");
      Console.WriteLine("ATENÇÃO!! AS TAXAS MUDAM, ESTAMOS LEVANDO EM CONTA TAXAS DE SETEMBRO DE 2019");
      Console.WriteLine("***************************");
     // SELIC referente a setembro de 2019
    }
    if(escolha == "4"){
      Console.WriteLine("Digite o valor que você quer fazer a simulação:");
      double valor = double.Parse(Console.ReadLine());
      Console.WriteLine("Por quanto tempo ( EM MESES ) você pretende deixar o seu dinheiro investido");
      double meses = double.Parse(Console.ReadLine());
      double poupresult = (0.0037*valor*meses);
      Console.WriteLine("O SEU RENDIMENTO NA POUPANÇA SERA: "+ poupresult + " REAIS!");
      double cdbresult = 0.00458*meses*valor;
      Console.WriteLine("O SEU RENDIMENTO NO CDB ( 100% CDI) SERA: "+ cdbresult + " REAIS!");
      double tesouroresult = 0.0047*meses*valor;
      Console.WriteLine("O SEU RENDIMENTO NO TESOURO SELIC SERA: "+ tesouroresult + " REAIS!");
      Console.WriteLine("***************************");
      Console.WriteLine("ATENÇÃO!! AS TAXAS MUDAM, ESTAMOS LEVANDO EM CONTA TAXAS DE SETEMBRO DE 2019");
      Console.WriteLine("***************************");



     // SELIC referente a setembro de 2019
    }
      Console.WriteLine("Aperte qualquer tecla para continuar");
      Console.ReadKey();
    Menu_De_Investimentos();
   }

    public void TitulosTesouro(){
      Console.WriteLine("ESCOLHA A SUA OPÇÃO DO TESOURO DIRETO:");
      Console.WriteLine();
      Console.WriteLine("1 - Tesouro IPCA+ 2024	-	IPCA + 2,27% a.a");
      Console.WriteLine("2 - Tesouro IPCA+ 2035	-	IPCA + 3,17% a.a");
      Console.WriteLine("3 - Tesouro IPCA+ com Juros Semestrais 2026	-	IPCA + 2,52% a.a");
      Console.WriteLine("4 - Tesouro IPCA+ com Juros Semestrais 2035 -	IPCA + 3,03% a.a");
      Console.WriteLine("5 - Tesouro Prefixado 2025	- 6,19%     a.a");
      Console.WriteLine("6 - Tesouro Prefixado com Juros  Semestrais 2029	-	6,56% a.a");
      Console.WriteLine("7 -  Tesouro Selic 2025 -	Selic + 0,  02 a.a");
      string escolha = Console.ReadLine();
      if(escolha == "1"){
      }
      if(escolha == "2"){

      }
      if(escolha == "3"){

      }
      if(escolha == "4"){

      }
      if(escolha == "5"){

      }
      if(escolha == "6"){

      }
      if(escolha == "7"){

      }


    }
    





}
