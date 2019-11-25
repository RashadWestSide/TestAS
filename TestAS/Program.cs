using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] digits = new int[5];
            int sumOdd = 0;

            void ConvToMas(int num)
            {
                for (int i = 0; i<5; i++)
                {
                    digits[i] = num % 10;
                    num /= 10;
                }
                Array.Reverse(digits);
            }

            int ConvToDigit()
            {
                string temp = null;

                foreach (int di in digits)
                {
                    temp += di.ToString();
                }

                return int.Parse(temp);
            }

            void OpWithDigit (int num)
            {
                ConvToMas(num);
                for (int i = 0; i<digits.Length; i++)
                {
                    if ((i+1) % 2 == 0)
                    {
                        digits[i] = 0;
                    }
                    else
                    {
                        sumOdd += digits[i];
                    }
                }
                Console.WriteLine("Before operation: {0}", num);
                Console.WriteLine("After operation: {0}", ConvToDigit());
                Console.WriteLine("\nSum odd digits = {0}", sumOdd);
            }

            OpWithDigit(21414);
            Console.ReadKey();
        }
    }
}
