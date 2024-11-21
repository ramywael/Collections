namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1, 2, 3, 4, 5}; // initialize and declartion
            arr[0]=Convert.ToInt32(Console.ReadLine()); // re-declartion
            Console.WriteLine(arr[0]); // access
            Console.WriteLine(arr[arr.Length -1]); // 5
            Console.WriteLine(arr[^1]); // 5 Prints the last element

        }
    }
}
