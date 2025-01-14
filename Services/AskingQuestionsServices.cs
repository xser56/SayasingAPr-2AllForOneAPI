using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SayasingAPr_2.Services
{
    public class AskingQuestionsServices
    {
        public string WhoAreYou(string Name, string WakeUp)
        {
            bool valid = int.TryParse(WakeUp, out int number);

            if (valid && number <= 12 && number >= 1)
            {
            string results = $"So your name is {Name}, and you wake up at {WakeUp} o'clock?";
            return results;

            } else
            {
                return "Please enter a valid wake up time between 1 and 12!";
            }

        }
    }
}