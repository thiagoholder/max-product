namespace MaxProductProgram
{
    using System;

    public static class MaxProduct
    {
        public static (int, int) maxProduct(int[] arr, int n)
        {
            if (n < 2)
            {
                throw new ArgumentException("Cannot find product of a less two numbers in array");
            }

            // Max product pair
            int a = arr[0], b = arr[1];

            //  Keep track of max product not the same and divisible with 3
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] != arr[j] && arr[i] * arr[j] > a * b && arr[i] * arr[j] % 3 == 0)
                    {
                        a = arr[i];
                        b = arr[j];
                    }
                }
            }

            if(a * b % 3 != 0)
            {
                throw new Exception("it was not possible to find the maximum product in two numbers in the informed array.");
            }

            return (a, b);
        }

        // Driver Code
        public static void Main()
        {
            try
            {
                int[] arr = { 1,2,3 };
                int n = arr.Length;
                (int, int) maxPair = maxProduct(arr, n);
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