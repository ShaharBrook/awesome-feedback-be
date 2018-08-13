using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using awesome_feedback_be.core;
using awesome_feedback_be.DAL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace awesome_feedback_be.Controllers
{
    [Route("api/[controller]")]
    public class FormController : Controller
    {
        // GET: api/<controller>
        [HttpGet("{appName}")]
        public IEnumerable<Form> Get(string appName)
        {
            var formRepo = new FormRepo();
            return formRepo.GetAll(appName);
        }

        // POST api/<controller>
        [HttpPost]
        public Guid Post([FromBody]Form form)
        {
            var formRepo = new FormRepo();
            return formRepo.Create(form);
        }

    }
}
