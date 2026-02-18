using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api_with_entity_framework.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpPost("{name}/{birthDate}")]
        public IActionResult Post(string name, DateTime birthDate)
        {
            if (birthDate > DateTime.Today)
                return BadRequest("A data de nascimento não pode ser futura.");

            var today = DateTime.Today;

            int years = today.Year - birthDate.Year;
            int months = today.Month - birthDate.Month;
            int days = today.Day - birthDate.Day;

            if (days < 0)
            {
                months--;
                var previousMonth = today.AddMonths(-1);
                days += DateTime.DaysInMonth(previousMonth.Year, previousMonth.Month);
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }

            string message = $"{name} tem {years} anos, {months} meses e {days} dias!";

            var data = new
            {
                name,
                birthday = birthDate.ToLongDateString(),
                currentDate = DateTime.Now.ToLongDateString(),
                currentHour = DateTime.Now.ToShortTimeString(),
                message
            };

            return Ok(data);
        }
    }
}