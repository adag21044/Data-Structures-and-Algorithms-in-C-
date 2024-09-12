// mid = low + (high - low) / 2

public class BinarySearch
{
    public static void Main(string[] args)
    {
        int[] arr = new int[100];

        for (int i = 0; i < 100; i++ )
        {
            arr[i] = i;
        }

        int x = MyBinarySearch(arr, 9, 0, arr.Length - 1);

        Console.WriteLine(x);

    }

    public static int MyBinarySearch(int[] arr, int wanted, int low, int high)
    {
        
        if (low > high) return -1;

        int mid = low + (high - low) / 2;

        if (arr[mid] == wanted)
        {
            return mid; 
        }
        else if (arr[mid] < wanted)
        {
            return MyBinarySearch(arr, wanted, mid + 1, high);
        }
        else
        {
            return MyBinarySearch(arr, wanted, low, mid - 1);
        }
    }
}
