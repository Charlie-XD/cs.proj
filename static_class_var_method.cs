using System;
// static class
public static class Kaido{
    
    // static variables
    public static int age = 57;
    public static double balance = 4999.96;
    public static int attack = 100;
    
    // static methods
    public static int damage(int Dmg){
        return attack = Dmg;
    }
    
    public static void Show(){
        Console.WriteLine($"Age : {age} , Cash : {balance}");
    }
    
}

public class H4WK{
    public static void Main(string[] args){
       
        // only changable by class, not object
        // We can't create object in a static class
    
        Console.WriteLine("Old Age, $Cash : " + Kaido.age + ", $" + Kaido.balance);
           
        Kaido.age = 60;
        Kaido.balance = 3333.33;
        
        Console.WriteLine("New Age, $Cash : " + Kaido.age + ", $" + Kaido.balance);
        
        Console.WriteLine("Old Damage = " + Kaido.attack);
        Console.WriteLine("New Damage = " + Kaido.damage(444));
        
    }
}

