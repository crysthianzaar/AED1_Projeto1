using System;

class MainClass {
  public static void Main (string[] args) {
    usuario c = new usuario();
    Console.WriteLine("Digite seu nome: ");
    c.nome= Console.ReadLine();
    c.idade = 21;
    c.cpf = "14334599737";
    c.Perfil_Risco = "moderado";

    Console.WriteLine ( c.nome +" você tem ("+ c.Perfil_Risco + ")como perfil de risco");
    
  }
}

// Em Teste
