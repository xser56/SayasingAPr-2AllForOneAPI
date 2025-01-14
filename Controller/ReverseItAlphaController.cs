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
    public class ReverseItAlphaController : ControllerBase
    {
        private readonly ReverseItAlphaServices _reverseItAlphaservices;
        public ReverseItAlphaController(ReverseItAlphaServices reverseItAlphaservices)
        {
            _reverseItAlphaservices = reverseItAlphaservices;
        }

        [HttpPost]
        [Route("ReverseAlpha/{EnterSequenceHere}")]
        public string ReverseNumbers(string EnterSequenceHere)
        {
            return _reverseItAlphaservices.ReverseSequence(EnterSequenceHere);
        }
    }
}