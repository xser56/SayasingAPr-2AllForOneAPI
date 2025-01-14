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
    public class AddingTwoNumbersController : ControllerBase
    {
        private readonly AddingTwoNumbersServices _addingTwoNumbersServices;
        public AddingTwoNumbersController(AddingTwoNumbersServices addingTwoNumbersServices)
        {
            _addingTwoNumbersServices = addingTwoNumbersServices;
        }

        [HttpPost]
        [Route("AddTwo")]
        public string AddTwoNumbers(int num1, int num2)
        {
            return _addingTwoNumbersServices.NumberToAdd(num1, num2);
        }
    
    }
}