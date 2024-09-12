public class LinearSearch
{
    // linear search = iterate through a collection one element at a time

    public static void Main(string[] args)
    {
        int[] arr = new int[] { 5, 6, 3, 9, 7, 4, 1, 0, 2, 8 };


        Console.WriteLine(MyLinearSearch(arr, 5));
    }

    public static int MyLinearSearch(int[] arr, int num)
    {
        int index = -1;

        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == num) return i;
        }

        return -1;
        
    }
}
