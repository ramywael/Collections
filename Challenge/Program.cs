namespace Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = new int[10];
            myArr[0] = 100;
            myArr[9] = 1000;
            Console.WriteLine(myArr[0]);
            Console.WriteLine(myArr[9]);
            myArr[^9] = 100;
            myArr[myArr.Length -1 ] = 1000;
            Console.WriteLine(myArr[^9]);
            Console.WriteLine(myArr[9]); 
            Console.WriteLine(myArr[4]);
        }
    }
}
