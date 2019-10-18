  
using System;

class MainClass {
  public static void Main (string[] args) {
    string criar;
    string possui;
    usuario c = new usuario();

    Console.WriteLine(" Você já possui uma conta? (s = sim, n = Não)");
    possui = Console.ReadLine();
      if(possui == "n"){

    Console.WriteLine(" Deseja criar uma conta? (s = sim, n = Não)");
    criar= Console.ReadLine();
      if ( criar =="s"){
      c.criarconta();
      }
      if( criar != "s"){
        Console.WriteLine(" Espero que mude de ideia em breve! :)");
       Environment.Exit(0);
      }

      
    
    c.analise_de_perfil();

     

   }  
  }

}

// Em Teste
