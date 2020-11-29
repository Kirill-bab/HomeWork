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

            int[] newDigitsArray = new int[digitsArray.Length];
            Array.Copy(digitsArray, newDigitsArray, digitsArray.Length);
            
            for (int i = newDigitsArray.Length - 1; i > 0; i--)
            {
                if (newDigitsArray[i] > newDigitsArray[i - 1])
                {
                    int temp = newDigitsArray[i];
                    newDigitsArray[i] = newDigitsArray[i - 1];
                    newDigitsArray[i - 1] = temp;
                    break;
                }
            }  

            if (string.Join("", newDigitsArray) == string.Join("", digitsArray))
                return -1;

            int result = int.Parse(String.Join("", newDigitsArray));

            return result;
        }
    }
}
