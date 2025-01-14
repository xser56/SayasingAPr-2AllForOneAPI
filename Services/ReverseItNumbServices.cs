using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SayasingAPr_2.Services
{
    public class ReverseItNumbServices
    {
        public string ReverseNumbers(int num)
        {
            int reverse = 0;
            int originalNum = num;
            bool valid = true;

            if (valid == true)
            {
                while (num > 0)
                {
                    int modulate = num % 10;
                    reverse = (reverse * 10) + modulate;
                    num /= 10;
                }
                string response = $"Your original sequence of numbers is {originalNum}. Your sequence reversed is {reverse}";
                return response;
            }
            else
            {
                return "Invalid input please enter a number";
            }
        }
    }
}