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
            string binString;


            bin = Int32.Parse(Console.ReadLine()); // или так: Int32.TryParse(Console.ReadLine(), out bin);
            binString = Convert.ToString(bin);
            //int binary = bin;
            int length = GetCountsOfDigits(bin);
            //int length = binString.Length; // ради узнавания длины числа
            int[] temp = new int[length];
            int[] tempInt = new int[length];

            for (int i = 0; i <= length - 1; i++)
            {
                temp[i] = bin / (Convert.ToInt32(Math.Pow(10, length - i - 1)));
                bin = bin - temp[i] * (Convert.ToInt32(Math.Pow(10, length - i - 1)));
            }

            for (int i = 0; i <= length - 1; i++)
            {
                tempInt[i] = Convert.ToInt32(temp[i]);
            }

            for (int i = 0; i <= length - 1; i++)
            {
                Console.Write(temp[i] + " ");
            }
            int dec = (BinToDecConverter.converter.BinToDec(length, tempInt));
            Console.WriteLine(" Binary : " + bin);
            Console.WriteLine( " Decimal: " + dec);
            Console.ReadKey();



        }
        


        public static int GetCountsOfDigits(int number)
        {
            return (number == 0) ? 1 : (int)Math.Ceiling(Math.Log10(Math.Abs(number) + 0.5));
        }

    }
}
