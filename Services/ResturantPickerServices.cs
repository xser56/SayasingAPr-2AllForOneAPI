using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SayasingAPr_2.Services
{
    public class ResturantPickerServices
    {
        public string PickRestaurant(string chosenFoodType)
        {
            Random rng = new();

            if (chosenFoodType == "Asian" || chosenFoodType == "asian")
            {
                string[] asian = { "Noodle Hut R' Us", "Pho Man", "Number 1 China Buffet", "Suzie's Sushi", "The Dog House",
                                   "Saigon Bay", "Green Papaya", "Bobby's Fish", "The Asian", "My Pork's Belly" };
                int randomIndex = rng.Next(asian.Length);
                return $"You chose a asian! How about you eat at [{asian[randomIndex]}]";
            }
            else if (chosenFoodType == "Mexican" || chosenFoodType == "mexican")
            {
                string[] mexican = { "Tacos Chapala", "La Kora", "Me gusta Tacos!", "Don Rafa's", "Taco Shop",
                                     "Cancun la casa", "Authentic Mayan Cuisine", "Jesus' Burrito", "Jacko's Tacos", "A taste of Mexico" };
                int randomIndex = rng.Next(mexican.Length);
                return $"You chose mexican! How about you eat at [{mexican[randomIndex]}]";
            }
            else if (chosenFoodType == "Fast Food" || chosenFoodType == "fast food" || chosenFoodType == "Fast food")
            {
                string[] fastFood = { "Taco Bell", "McDonalds", "Subway", "Burger King", "Popeyes",
                                      "Panda Express", "Church's Chicken", "Canes", "Five Guys", "Jack in the Box" };
                int randomIndex = rng.Next(fastFood.Length);
                return $"You chose fast Food! How about you eat at [{fastFood[randomIndex]}]";
            }
            else
            {
                return "Invalid food type! Please choose from Asian, Mexican, or Fast Food.";
            }
        }
    }
}