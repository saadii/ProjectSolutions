using System;

namespace FindPi
{
    /// <summary>
    /// * Find PI to the Nth Digit *
    ///     Enter a number and have the program generate PI up to that many decimal places.
    ///     Keep a limit to how far the program will go.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string value;

            do
            {
                Console.WriteLine("Find Pi to the Nth Digit");
                Console.WriteLine("Enter value for how many decimals to display - Limit is 14");
                value = Console.ReadLine();
            } while (IsDigitsOnly(value) == false);

            //If the string value is greater than the limit (14), set the value in Math.Round to 14.
            //Otherwise Convert string value to integer as normal
            Console.WriteLine(Convert.ToInt16(value) >= 15
                ? Math.Round(Math.PI, 14)
                : Math.Round(Math.PI, Convert.ToInt16(value)));

            Console.ReadKey();
        }

        /// <summary>
        /// If value is numerical.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsDigitsOnly(string value)
        {
            foreach (char c in value)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
    }
}
