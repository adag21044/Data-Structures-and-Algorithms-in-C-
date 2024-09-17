using System;

public class InsertionSort
{
    public static void Main(string[] args)
    {
        int[] arr = { 4, 9, 1, 5 };

        // Print the array before sorting
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
        
        // Perform the sorting
        InsertionSortF(arr);
        Console.WriteLine("");

        // Print the sorted array
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
    }

    public static void InsertionSortF(int[] arr)
    {
        // Start from the 1st element (index 1)
        for (int i = 1; i < arr.Length; i++)
        {
            int key = arr[i];  // Element to be inserted in the correct position
            int j = i - 1;

            // Shift elements that are greater than key to the right
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];  // Shift the element to the right
                j--;
            }
            
            arr[j + 1] = key;  // Place the key in its correct position
        }
    }
}
