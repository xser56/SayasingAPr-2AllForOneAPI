using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SayasingAPr_2.Services
{
    public class MadLibServices
    {
         public string MadLib(string YourName, string animal, string name2, string place, string adjective, string noun, string emotion, string adjective2, string adjective3, string emotion2)
        {
            string story = $"Hello, {YourName}. You and your pet {animal} {name2}, decided to go to the {place}. You and {name2} ran into a {adjective} {noun}. The {adjective} {noun} made you {emotion}, so you and your {animal} decided to {adjective2} the {noun}. The three of you where {adjective2} ferocously but unfortunatly you and your {animal} ended up {adjective3} eachother. It was a {emotion2} day!";

            return story;
        }
    }
}