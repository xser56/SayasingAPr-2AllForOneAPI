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
    public class OddOrEvenController : ControllerBase
    {
        private readonly OddOrEvenServices _oddOrEvenServices;
        public OddOrEvenController(OddOrEvenServices oddOrEvenService)
        {
            _oddOrEvenServices = oddOrEvenService;
        }
        
        [HttpPost]
        [Route("OddOrEven/{EnterNumber}")]
        public string OddOrEven(string EnterNumber)
        {
            return _oddOrEvenServices.OddOrEven(EnterNumber);
        }
    }
}