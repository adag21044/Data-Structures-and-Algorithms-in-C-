using System;

public class QuickSort
{
    public static void Main(string[] args)
    {
        int[] arr = { 4, 9, 1, 5, 2, 8 };

        // Print the array before sorting
        Console.WriteLine("Before sorting:");
        PrintArray(arr);
        
        // Perform QuickSort
        QuickSortF(arr, 0, arr.Length - 1);
        
        // Print the sorted array
        Console.WriteLine("After sorting:");
        PrintArray(arr);
    }

    // QuickSort function
    public static void QuickSortF(int[] arr, int low, int high)
    {
        if (low < high)
        {
            // Find the pivot index
            int pivotIndex = Partition(arr, low, high);
            
            // Recursively sort elements before and after the pivot
            QuickSortF(arr, low, pivotIndex - 1);
            QuickSortF(arr, pivotIndex + 1, high);
        }
    }

    // Partition function: this is where we rearrange the array
    public static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];  // Choosing the last element as the pivot
        int i = low - 1;  // Pointer for the smaller element
        
        // Rearrange elements based on the pivot
        for (int j = low; j < high; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                Swap(arr, i, j);  // Swap if element is smaller than or equal to the pivot
            }
        }
        
        // Place the pivot in its correct position
        Swap(arr, i + 1, high);
        return i + 1;
    }

    // Swap function: swaps two elements in the array
    public static void Swap(int[] arr, int a, int b)
    {
        int temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }

    // Helper function to print the array
    public static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}
