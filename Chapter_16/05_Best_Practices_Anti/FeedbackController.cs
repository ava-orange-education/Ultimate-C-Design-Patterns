using Chapter_16._03_Practical_examples_Antipatterns;
using Chapter_16._03_Practical_examples_Antipatterns.Web_Example;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Chapter_16._05_Best_Practices_Anti
{
    internal class FeedbackController
    {
        private Logger _logger;
        private Database _db;

        [HttpPost]
        public IActionResult SubmitFeedback(FeedbackDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Message))
                return BadRequest("Message is required");

            var feedback = new Feedback { Message = dto.Message, Timestamp = DateTime.UtcNow };
            _db.Save(feedback);
            _logger.Log($"Feedback submitted: {dto.Message}");

            return Ok();
        }

        private IActionResult Ok()
        {
            throw new NotImplementedException();
        }

        private IActionResult BadRequest(string v)
        {
            throw new NotImplementedException();
        }
    }
}
