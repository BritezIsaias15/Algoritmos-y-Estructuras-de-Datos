using System;
class HelloWorld {
  static void Main() {
      var texto = new stack<string>();
      
      while (true)
      {
          Console.WriteLine("Seleccione una opción \n 1.Escribir \t 2.Deshacer \t 3.Mostrar");
          string input = Console.ReadLine();
          
          switch(input)
          {
              case 1:
              Escribir();
          }
      }
      
  }
  public string Escribir()
  {
      Console.WriteLine("Ingrese el texto.")
      texto.Push(Console.ReadLine());
  }
  
}
