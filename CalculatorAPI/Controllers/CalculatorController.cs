using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CalculatorLibrary;

namespace CalculatorApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculator _calculator = new Calculate();
        private readonly ILogger<CalculatorController> _logger;
        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("/addition/{num1}/{num2}")]
        public IActionResult Addition(int num1, int num2)
        {
            var result = _calculator.Add(num1, num2);

            return Ok(new CalculationResult
            {
                Result = result,
                Message = "Cool"
            });
        }

        [HttpGet]
        [Route("/subtraction/{num1}/{num2}")]
        public IActionResult Subtraction(int num1, int num2)
        {
            var result = _calculator.Subtract(num1, num2);

            return Ok(new CalculationResult
            {
                Result = result,
                Message = "Cool"
            });
        }

        [HttpGet]
        [Route("/multiplication/{num1}/{num2}")]
        public IActionResult Multiplication(int num1, int num2)
        {
            var result = _calculator.Multiply(num1, num2);

            return Ok(new CalculationResult
            {
                Result = result,
                Message = "Cool"
            });
        }

        [HttpGet]
        [Route("/division/{num1}/{num2}")]
        public IActionResult Division(int num1, int num2)
        {
            var result = _calculator.Divide(num1, num2);

            return Ok(new CalculationResult
            {
                Result2 = result,
                Message = "Cool"
            });
        }

        [HttpGet]
        [Route("/percentage/{num1}/{num2}")]
        public IActionResult Percentage(int num1, int num2)
        {
            var result = _calculator.Percentage(num1, num2);

            return Ok(new CalculationResult
            {
                Result3 = result,
                Message = "Cool"
            });
        }
    }
}
