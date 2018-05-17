using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinToDecConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            int bin;
            Console.Write("Enter binary number: ");
            bin = Int32.Parse(Console.ReadLine()); // или так: Int32.TryParse(Console.ReadLine(), out bin);
            int length = GetCountsOfDigits(bin);
            int binStory = bin;
            int[] temp = new int[length];
            int[] tempInt = new int[length];

            for (int i = 0; i <= length - 1; i++)
            {
                temp[length - 1 - i] = bin % 10;
                bin = bin/10;
                if (temp[i] > 1)
                Console.WriteLine("You can enter only Binary number! ");
            }

            int sum = 0;

            for (int i = 0; i <= length - 1; i++)
            {
                sum = sum + temp[i];
            }
            
            

            Console.Write("Digits in your number are: ");
            for (int i = 0; i <= length - 1; i++)
            {
                Console.Write(temp[i] + " ");
            }
            Console.WriteLine();
            int dec = (BinToDecConverter.converter.BinToDec(length, temp));
            Console.WriteLine(" Binary : " + binStory);
            Console.WriteLine(" Decimal: " + dec);
            Console.ReadKey();
        }

        public static int GetCountsOfDigits(int number)
        {
            return (number == 0) ? 1 : (int)Math.Ceiling(Math.Log10(Math.Abs(number) + 0.5));
        }

    }
}
