using System;

class Program {
    static void Main(string[] args) 
    { /*zad 1
        int n;
        Console.WriteLine("podaj n: ");
        n = int.Parse(Console.ReadLine());
        for (int i=1; i<=n; i++){
              Console.Write("*-|");
        }
        */
      //tabliczka mnożenia
        for (int i=1; i<11; i++){
              for (int j=1; j<=11; j++){
                Console.Write(i*j+"\t");
              }
          Console.WriteLine();
        }
        
    }
}
