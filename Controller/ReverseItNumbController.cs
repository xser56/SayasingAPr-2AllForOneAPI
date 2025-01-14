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
    public class ReverseItNumbController : ControllerBase
    {
        private readonly ReverseItNumbServices _reverseNumberServices;
        public ReverseItNumbController(ReverseItNumbServices reverseNumberServices)
        {
            _reverseNumberServices = reverseNumberServices;
        }
        
        [HttpPost]
        [Route("Reverse/{EnterSequenceOfNumbersHere}")]
        public string ReverseNumbers(int EnterSequenceOfNumbersHere)
        {
            return _reverseNumberServices.ReverseNumbers(EnterSequenceOfNumbersHere);
        }
    }
}