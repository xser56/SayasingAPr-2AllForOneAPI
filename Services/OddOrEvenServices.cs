using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SayasingAPr_2.Services
{
    public class OddOrEvenServices
    {
        public string OddOrEven(string input)
    {
        string result;
        bool valid = int.TryParse(input, out int number);

        if (!valid)
        {
            return "Invalid input. Please enter a valid number.";
        }

        if (number % 2 == 0)
        {
            result = "even";
        }
        else
        {
            result = "odd";
        }

        return $"The number {number} is {result}.";
    }
    }
}