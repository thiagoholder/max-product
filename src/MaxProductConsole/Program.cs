using System;

namespace MaxProductConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = { 1,2 };
                int n = arr.Length;
                var maxProduct = new MaxProduct(arr);
                (int, int) maxPair = maxProduct.Pairs;
                int productPair = maxPair.Item1 * maxPair.Item2;
                Console.WriteLine($"Max product pair is {maxPair.Item1} * {maxPair.Item2} = {productPair}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
