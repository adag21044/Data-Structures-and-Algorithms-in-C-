using System;

public class BubbleSort
{
    public int[] arr = {4, 9, 3, 2, 1, 0, 7, 8, 5, 6};
    
    public static void Main(string[] args)
    {
        BubbleSort bs = new BubbleSort();
        
        
        Console.WriteLine("Before sorting:");
        for (int i = 0; i < bs.arr.Length; i++)
        {
            Console.Write(bs.arr[i] + " ");
        }
        
        
        bs.BubbleSortF(bs.arr);
        
        
        Console.WriteLine();
        Console.WriteLine("After sorting:");
        for (int i = 0; i < bs.arr.Length; i++)
        {
            Console.Write(bs.arr[i] + " ");
        }
    }
    
    public void BubbleSortF(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    Swap(ref arr[j], ref arr[j + 1]);
                }
            }
        }
    }
    
    public void Swap(ref int n1, ref int n2)
    {
        int temp = n1;
        n1 = n2;
        n2 = temp;
    }
}
