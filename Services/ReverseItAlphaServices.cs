using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SayasingAPr_2.Services
{
    public class ReverseItAlphaServices
    {
        public string ReverseSequence(string sequence)
        {
            string originalSequence = sequence;
            string reversed = "";

            for (int i = sequence.Length - 1; i >= 0; i--)
            {
                reversed += sequence[i];
            }
            return $"Your sequence is {originalSequence}. Your reversed sequence is {reversed}";
        }
    }
}