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
    public class AskingQuestionsController : ControllerBase
    {
        private readonly AskingQuestionsServices _askingquestionsSerivce;
        public AskingQuestionsController(AskingQuestionsServices askingQuestionsServices)
        {
            _askingquestionsSerivce = askingQuestionsServices;
        }

        [HttpPost]
        [Route("WhoAreYou")]

        public string AskQuestion(string yourName, string yourWakeTime)
        {
            return _askingquestionsSerivce.WhoAreYou(yourName, yourWakeTime);
        }
    }
}