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
      /*tabliczka mnożenia
        for (int i=1; i<11; i++){
              for (int j=1; j<=11; j++){
                Console.Write(i*j+"\t");
              }
          Console.WriteLine();*/
      //gwiazdki
       int n = 0;
        for (int i=5; i>n; i--){
              for (int j=1; j<i+1; j++){
                Console.Write("*"+"\t");
              }
          Console.WriteLine();
        }
        
        
    }
}
