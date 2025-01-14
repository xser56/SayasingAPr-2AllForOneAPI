using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SayasingAPr_2.Services
{
    public class GuessItServices
    {
        public string GuessItEasy(string easyInput)
        {
            int minRange = 1, maxRange = 10;
            Random rng = new Random();
            int numberToGuess = rng.Next(minRange, maxRange + 1);

            if (!int.TryParse(easyInput, out int easy))
            {
                return "Invalid input. Please enter a valid integer.";
            }

            if (easy < minRange || easy > maxRange)
            {
                return $"Please enter a number between {minRange} and {maxRange}.";
            }

            if (easy == numberToGuess)
            {
                return "Congratulations! You guessed the correct number!";
            }
            else if (easy < numberToGuess)
            {
                return "Your guess is too low. The number was " + numberToGuess;
            }
            else
            {
                return "Your guess is too high. The number was " + numberToGuess;
            }
        }


        public string GuessItMedium(string mediumInput)
        {
            int minRange = 1, maxRange = 50;
            Random rng = new Random();
            int numberToGuess = rng.Next(minRange, maxRange + 1);

            if (!int.TryParse(mediumInput, out int medium))
            {
                return "Invalid input. Please enter a valid integer.";
            }

            if (medium < minRange || medium > maxRange)
            {
                return $"Please enter a number between {minRange} and {maxRange}.";
            }

            if (medium == numberToGuess)
            {
                return "Congratulations! You guessed the correct number!";
            }
            else if (medium < numberToGuess)
            {
                return "Your guess is too low. The number was " + numberToGuess;
            }
            else
            {
                return "Your guess is too high. The number was " + numberToGuess;
            }
        }

        public string GuessItHard(string hardInput)
        {
            int minRange = 1, maxRange = 100;
            Random rng = new Random();
            int numberToGuess = rng.Next(minRange, maxRange + 1);

            if (!int.TryParse(hardInput, out int hard))
            {
                return "Invalid input. Please enter a valid integer.";
            }

            if (hard < minRange || hard > maxRange)
            {
                return $"Please enter a number between {minRange} and {maxRange}.";
            }

            if (hard == numberToGuess)
            {
                return "Congratulations! You guessed the correct number!";
            }
            else if (hard < numberToGuess)
            {
                return "Your guess is too low. The number was " + numberToGuess;
            }
            else
            {
                return "Your guess is too high. The number was " + numberToGuess;
            }
        }
    }
}