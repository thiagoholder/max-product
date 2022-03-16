namespace MaxProductConsole
{
    using System;
    using System.Linq;

    public class MaxProduct
    {

        public MaxProduct(int[] arr)
        {
            this.Numbers = arr;
            this.LengthPairs = Numbers.Length < 2 ? throw new ArgumentException("Cannot find product of a less two numbers in array") : Numbers.Length;
        }

        public int[] Numbers { get; }

        public int LengthPairs {get; }


        public (int, int) Pairs => this.maxProduct(Numbers);

        private (int, int) maxProduct(int[] arr)
        {
            // Max product pair
            int firstMax = 0, secondMax = 0;

            var distinctList = arr.Distinct().ToArray();

            foreach (var num in distinctList)
            {
                if (num > firstMax)
                {
                    secondMax = firstMax; // previous firstMax goes to secondFirst
                    firstMax = num; // new max is in firstMax
                }
                else if (Math.Max(num, secondMax) * firstMax % 3 == 0)
                {
                    secondMax = Math.Max(num, secondMax);
                }
            }

            if (firstMax * secondMax % 3 != 0)
            {
                throw new Exception("it was not possible to find the maximum product in two numbers in the informed array.");
            }

            return (firstMax, secondMax);
        }
    }
}