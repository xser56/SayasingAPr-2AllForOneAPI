using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SayasingAPr_2.Services
{
    public class Magic8BallServices
    {
        public string Magic8Ball(string AskAQuestion)
        {
            string response = "";
            // Validation
            if (!AskAQuestion.Trim().EndsWith("?"))
            {
                return "Please enter a question with a '?' at the end of your sentence.";
            }

            // Grab 
            Random rng = new Random();
            int check = rng.Next(1, 9); 

            switch (check)
            {
                case 1:
                    response = "Yes.";
                    break;

                case 2:
                    response = "Maybe.";
                    break;

                case 3:
                    response = "No.";
                    break;

                case 4:
                    response = "I don't know. Ask me again.";
                    break;

                case 5:
                    response = "Stop asking me questions. I don't care.";
                    break;

                case 6:
                    response = "Have you tried asking a human being instead?";
                    break;

                case 7:
                    response = "I can answer that, but I'd rather not.";
                    break;

                case 8:
                    response = "Most likely.";
                    break;
            }
            return response;
        }
    }
}