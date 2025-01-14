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
    public class GuessItController : ControllerBase
    {
        private readonly GuessItServices _guessItServices;
        public GuessItController(GuessItServices guessItServices)
        {
            _guessItServices = guessItServices;
        }

        [HttpGet]
        [Route("guessEasy")]
        public string GuessItEasy(string guessEasy)
        {
            return _guessItServices.GuessItEasy(guessEasy);
        }
        
        [HttpGet]
        [Route("guessMedium")]
        public string GuessItMedium(string guessMedium)
        {
            return _guessItServices.GuessItMedium(guessMedium);
        }

        [HttpGet]
        [Route("guessHard")]
        public string GuessItHard(string guessHard)
        {
            return _guessItServices.GuessItHard(guessHard);
        }
    }
}