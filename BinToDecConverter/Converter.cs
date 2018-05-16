using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinToDecConverter
{
    public class converter
    {
         public static int BinToDec(int length, int[] bin)
        {
            int dec = 0;
            for (int i = 0; i <= length-1; i++)
            {
                dec = dec + (bin[i] * (Convert.ToInt32(Math.Pow(2, length - i - 1))));

            }
            return dec;

        }
    }
}
