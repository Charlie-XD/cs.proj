using System;
public class demo{
    public string name;
    public int roll;
    
    public demo(){
        name = "Krishna";
        roll = 21;
    }
    
    // destructor (garbage collector)
    ~demo(){
        Console.WriteLine($"The name is {name} & roll is {roll}");
    }    
}

public class H4WK{
    public static void Main(string[] args){
        demo obj = new demo();
        
    }
}

