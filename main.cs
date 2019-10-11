using System;

class MainClass {
  public static void Main (string[] args) {
    usuario c = new usuario();
    c.idade = 21;
    c.nome= "crysthian";
    c.cpf = "14334599737";
    c.Perfil_Risco = "moderado";

    Console.WriteLine ( " você tem ("+ c.Perfil_Risco + ")como perfil de risco");
    
  }
}
