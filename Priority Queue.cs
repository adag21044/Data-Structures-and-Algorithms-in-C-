using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var priortyQueue = new PriorityQueue<float, int>();
        
        
        priortyQueue.Enqueue(4f, 4);
        priortyQueue.Enqueue(3f, 3);
        priortyQueue.Enqueue(2f, 2);
        priortyQueue.Enqueue(1f, 1);
        
        int length = priortyQueue.Count;
        
        
        for(int i = 0; i < length; i++)
        {
            var gpa = priortyQueue.Dequeue(); 
            Console.WriteLine(gpa); 
        }
    }
}
