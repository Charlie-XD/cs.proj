using System;
public class Sum{
   public int Add(int a, int b){
     return a + b;
   }

   public double Add(double a, double b){
    return a + b;
   }

   public int Add(int a, int b, int c){
    return a + b + c;
   }

}

public class Project{
    public static void Main(){

        Sum add = new Sum();

        Console.WriteLine(add.Add(10, 15));
        Console.WriteLine(add.Add(7, 8, 9));
        Console.WriteLine(add.Add(95.3, 12.94));

    }

}