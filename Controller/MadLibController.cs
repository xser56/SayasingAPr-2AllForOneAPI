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
    public class MadLibController : ControllerBase
    {
        private readonly MadLibServices _madLibServices;
        public MadLibController(MadLibServices madLibServices)
        {
            _madLibServices = madLibServices;
        }
        
        
        [HttpPost]
        [Route("MadLib/{YourName}/{animal}/{name2}/{place}/{adjective}/{noun}/{emotion}/{adjective2}")]
        public string MadLib(string YourName, string animal, string name2, string place, string adjective, string noun, string emotion, string adjective2, string adjective3, string emotion2)
        {
            return _madLibServices.MadLib(YourName, animal, name2, place, adjective, noun, emotion, adjective2, adjective3, emotion2);
        }
    }
}