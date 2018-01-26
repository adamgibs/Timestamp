using System;
using System.Collections.Generic;
using System.Collections;
using Microsoft.AspNetCore.Mvc;
using Timestamp.Data;



namespace Timestamp.Controllers
{
    [Route("api/[controller]")]
    public class TimestampController : Controller
    {

        private readonly TimestampContext _context;

        public TimestampController(TimestampContext context)
        {
            _context = context;

      
        }

        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("{dateQuery}")]
        public IActionResult GetResult(string dateQuery)
        {
            DateTime date;

            Models.Timestamp time = new Models.Timestamp();

            IList output = new List<object>();

            if (DateTime.TryParse(dateQuery, out date))
            {
                long result = time.GetUnixTimestamp(date);
                string dateString = date.Date.ToString("d");

                output.Add(new { NaturalDate = dateString, UnixTime = result });

                return new JsonResult(output);
            }
            else
            {
                long unixTime = Convert.ToInt32(dateQuery);
                String result = time.GetDate(unixTime);

                output.Add(new { NaturalDate = result, UnixTime = unixTime });

                return new JsonResult(output);
            }
        }


        
                

    }
}
