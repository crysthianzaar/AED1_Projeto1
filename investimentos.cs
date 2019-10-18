using System;
class investimentos
{
  public string ativos_fisicos = "";
  public string tesouro_direto= "";
  public string acoes= "";
  public string poupanca= "";

  public void Educacao_Financeira(carteira b) {
    if (b.GetSaldo_inicial() <= 0){
      Console.WriteLine();
      Console.WriteLine("OK, não tem problema!");
      Console.WriteLine("Podemos te explicar um pouco sobre finanças, o que acha?");
      Console.WriteLine("1 - Opa! quero aprender!");
      Console.WriteLine("2 - Melhor deixar para depois");
      string escolha = Console.ReadLine();
        if(escolha == "1"){
          // criar texto para educação financeira
        }
        if(escolha == "2"){
          // voltar para o menu depois de entrar
        }
      



    }
  }



  
}
