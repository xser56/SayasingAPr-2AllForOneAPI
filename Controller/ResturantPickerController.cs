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
    public class ResturantPickerController
    {
        private readonly ResturantPickerServices _resturantSelect;
        public ResturantPickerController(ResturantPickerServices resturantSelect)
        {
            _resturantSelect = resturantSelect;
        }

        [HttpGet]
        [Route("Choose A Food: Asian, Mexican, Fast Food")]
        public string RestaurantPicker(string ChooseFood)
        {
            return _resturantSelect.PickRestaurant(ChooseFood);
        }
    }
}