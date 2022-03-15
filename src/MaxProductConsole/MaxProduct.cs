namespace MaxProductConsole
{
    using System;

    public class MaxProduct
    {

        public MaxProduct(int[] arr)
        {
            this.Numbers = arr;
        }

        public int[] Numbers { get; }

        public int LengthPairs => Numbers.Length < 2 ? throw new ArgumentException("Cannot find product of a less two numbers in array") : Numbers.Length;


        public (int, int) Pairs => this.maxProduct(Numbers, LengthPairs);

        private (int, int) maxProduct(int[] arr, int n)
        {
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

            if (a * b % 3 != 0)
            {
                throw new Exception("it was not possible to find the maximum product in two numbers in the informed array.");
            }

            return (a, b);
        }
    }
}