using System;

public class Recursion
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Factorial(5));
    }
    
    public static int Factorial(int num)
    {
       if(num <= 1) return 1;
       else return num * Factorial(num - 1); 
    }
}
