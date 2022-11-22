using System;
using System.Linq;
using System.Text;

namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        public static int GetFactorial(int n)
        {
            //int factorial = n;

            //for (int i = n; i > 1; i--)
            //{
            //    factorial = factorial * (i - 1);
            //}

            //return factorial;


            if (n < 2)
                return n;

            return n * GetFactorial(n - 1);
        }

        public static string FormatSeparators(params string[] items)
        {
            if (items == null)
                throw new ArgumentNullException(nameof(items));

            if (items.Length == 0)
                return string.Empty;

            if (items.Length == 1)
                return items[0];

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < items.Length; i++)
            {
                if (i == items.Length - 1)
                    sb.Append("and " + items[i]);
                else if (i == items.Length - 2)
                    sb.Append(items[i] + " ");
                else
                    sb.Append(items[i] + ", ");
            }

            return sb.ToString();
        }
    }
}