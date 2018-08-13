using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using awesome_feedback_be.core;
using awesome_feedback_be.DAL;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace awesome_feedback_be.Controllers
{
    [Route("api/[controller]")]
    public class FeedbackController : Controller
    {
        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Feedback value)
        {
        var repo = new FeedbackRepo();
        repo.Create(value);
        }
    }
}
