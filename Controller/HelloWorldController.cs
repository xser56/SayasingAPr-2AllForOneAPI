using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SayasingAPr_2.Services;

namespace SayasingAPr_2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController :ControllerBase
    {
        private readonly HelloWorldServices _helloWorldServices;
        public HelloWorldController(HelloWorldServices helloWorldServices)
        {
            _helloWorldServices = helloWorldServices;
        }

        [HttpPost]
        [Route("YourName")]
        public List<string> NameToAdd(string nameToAdd)
        {
            return _helloWorldServices.NameToAddList(nameToAdd);
        }
    }
}