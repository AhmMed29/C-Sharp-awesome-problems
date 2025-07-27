// this is the interpolation search algorithm
namespace binarysearch;
class Program
{
    static void Main(string[] args)
    {
        int[] array = {1, 2, 3, 4, 5, 6, 7, 8};
        int index = interpolationsearch(array, 3);
        if(index != -1)
        {
            Console.WriteLine("Element found at "+ index);
        }
        else
        {
            Console.WriteLine("Element Not Found");
        }
    } 
    private static int interpolationsearch(int[] arr, int target)
    {
        int low = 0;
        int high = arr.Length - 1;
        while (target >= arr[low] && target <= arr[high] && low <= high)
        {
            //  probe تخمينه
            int probe = low + ((target - arr[low]) * (high - low)) / (arr[high] - arr[low]);
            // احنا بنخمن الاندكس للي ممكن يكون فيه العنصر
            if(target == arr[probe])
            {
                return probe;
            }
            else if (arr[probe] < target)
            {
                low = probe + 1;
            }
            else
            {
                high = probe - 1; 
            }
        }
        return -1;
    }
}