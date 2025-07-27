namespace binarysearch;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This will show the value you search for");
        int[] array = new int[100];
        for(int i=0;i<array.Length;i++)
        {
            array[i] = i;
        }
        Console.WriteLine(BinarySearch(array, 45));
    } 
    private static int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] == target)
            {
                return mid; // Target found
            }
            else if (arr[mid] < target)
            {
                left = mid + 1; // Search in the right half
            }
            else
            {
                right = mid - 1; // Search in the left half
            }
        }
        return -1; // Target not found
    }
}