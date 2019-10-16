  
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
    c.idade = 21;
    c.cpf = "14334599737";
    c.Perfil_Risco = "moderado";
    c.criarconta(c.nome,c.cpf, c.idade);
    Console.WriteLine("Conta Criada");



    Console.WriteLine ( c.nome +" você tem ("+ c.Perfil_Risco + ")como perfil de risco");
      }

    
  }
}

// Em Teste
