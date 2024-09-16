using System;

public class SelectionSort
{
    public static void Main(string[] args)
    {
        int[] arr = {8, 2, 0, 1, 4, 6, 9, 3, 5, 7};
        
       
        SelectionSort.SelectionSortF(arr);
        
        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
    
    public static void SelectionSortF(int[] arr)
    {   
        int i, j, minIndex;
        
        for(i = 0; i < arr.Length - 1; i++)
        {
            minIndex = i;
            for(j = i + 1; j < arr.Length; j++)
            {
                if(arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            
            // Swap the elements
            Swap(arr, i, minIndex);
        }
    }
    
    public static void Swap(int[] arr, int index1, int index2)
    {
        int temp = arr[index1];
        arr[index1] = arr[index2];
        arr[index2] = temp;
    }
}
