  
using System;

class MainClass {
  public static void Main (string[] args) {
    string criar;
    usuario c = new usuario();
    Console.WriteLine(" Deseja criar uma conta? ( S = sim, N = Não");
    criar= Console.ReadLine();
      if (criar == "S"){
    

      Console.WriteLine("Digite seu nome: ");
      c.nome= Console.ReadLine();
      Console.WriteLine("Digite sua idade: ");
      c.idade= int.Parse(Console.ReadLine());
      Console.WriteLine("Digite seu cpf: ");
      c.cpf= Console.ReadLine();
      c.criarconta(c.nome,c.cpf, c.idade);
      Console.WriteLine("Conta Criada com sucesso");
    }
    

    
  }
}

// Em Teste
