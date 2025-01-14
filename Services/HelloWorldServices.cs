using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SayasingAPr_2.Services
{
    public class HelloWorldServices
    {
        public List<string> nameList = new();

        public List<string> NameToAddList(string nameToAdd) //Here
        {
            nameList.Add("Hello, " + nameToAdd);
            return nameList;
        }
    }
}