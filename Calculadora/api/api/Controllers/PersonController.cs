using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class PersonController : ControllerBase
	{
		private readonly ILogger<PersonController> _logger;

		public PersonController(ILogger<PersonController> logger)
		{
			_logger = logger;
		}

		[HttpGet("sum/{firstnumber}/{secondnumber}")]
		public IActionResult Get(String firstnumber, String secondnumber)
		{
			if(IsNumeric(firstnumber) && IsNumeric(secondnumber))
			{
				var sum = ConvertToDecimal(firstnumber) + ConvertToDecimal(secondnumber);
				return Ok(sum.ToString());
			}
			return BadRequest("Invalid input");
		}

		

		private bool IsNumeric(string strNumber)
		{
			double number;
			bool isNumber = double.TryParse(
				strNumber, 
				System.Globalization.NumberStyles.Any, 
				System.Globalization.NumberFormatInfo.InvariantInfo, 
				out number);
			return isNumber;
		}
		private decimal ConvertToDecimal(string strNumber)
		{
			decimal decimalValue;
			if(decimal.TryParse(strNumber, out decimalValue))
			{
				return decimalValue;
			}
			return 0;
		}

		
	}
}
