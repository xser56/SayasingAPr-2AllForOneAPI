using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SayasingAPr_2.Services
{
    public class AddingTwoNumbersServices
    {
        public string NumberToAdd(int firstNum, int secondNum) 
        {
            int sum = firstNum + secondNum;
            string result = $"{firstNum} and {secondNum} = {sum}";
            return result;
        }
    }
}