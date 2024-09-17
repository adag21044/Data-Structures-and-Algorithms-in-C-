using System;
using System.Collections.Generic; 

public class DynamicArray
{
    public static void Main(string[] args)
    {
        // Dynamic arrays in C# are implemented using List<T>, which allows
        // the size of the array to grow or shrink dynamically as elements
        // are added or removed. This is different from traditional arrays
        // which have a fixed size once declared.
      
        // Integers list
        List<int> numbers = new List<int>();

        //Adding element to the list
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);

        foreach(int i in numbers)
        {
            Console.WriteLine(i);
        }

        List<string> games = new List<string>();
        games.Add("RDR 2");
        games.Add("GTA V");
        games.Add("Zelda");

        // Inserting an element and shifting the elements that come after it
        games.Insert(1,"Mafia DE");

        foreach(string game in games)
        {
            Console.WriteLine(game);
        }

        Console.WriteLine("");

        //Element deletion
        games.Remove("Zelda");

        foreach(string game in games)
        {
            Console.WriteLine(game);
        }

        games.RemoveAt(1);

        Console.WriteLine("");

        foreach(string game in games)
        {
            Console.WriteLine(game);
        }

        Console.WriteLine("The list has "+ games.Count+" elements"+"\n");


        //Lists with capacity

        List<string> names = new List<string>(6);

        names.Add("Joe");
        names.Add("Hilary");
        names.Add("Kamala");
        names.Add("Donald");
        

        foreach(string name in names)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine();
        Console.WriteLine(names.Capacity);

        // Reduce capacity with TrimExcess
        names.TrimExcess();

        Console.WriteLine(names.Capacity);
        
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

    }
}
