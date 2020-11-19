using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class RearrangeDigits
    {
        public static int Rearrange(int input)
        {
            string inputToStr = input.ToString();
            int[] digitsArray = new int[inputToStr.Length];

            for (int i = 0; i < digitsArray.Length; i++)
            {
                digitsArray[i] = int.Parse(inputToStr[i].ToString());                // перевожу число в массив цифр
            }

            int[] newDigitsArray = digitsArray.OrderByDescending(i => i).ToArray();  

            if (string.Join("", newDigitsArray) == string.Join("", digitsArray))
                return -1;

            int result = int.Parse(String.Join("", newDigitsArray));

            return result;
        }
    }
}
