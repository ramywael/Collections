namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(myList[1]);

            Console.WriteLine(myList.Count); //9
            Console.WriteLine(myList.Capacity); //16
            myList.TrimExcess(); //It removes the extra space
            Console.WriteLine(myList.Capacity); //9 The real Capacity
        }
    }
}
