using Microsoft.AspNetCore.Mvc;

using SecRecAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SecRecAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceiveController : ControllerBase
    {
        // GET: api/<ReceiveController>
        [HttpGet]
        public IEnumerable<ReceiveModel> Get()
        {
            List<ReceiveModel> receiveModelList = new List<ReceiveModel>();
            
            receiveModelList.Add(new ReceiveModel() { Id=1, MailId=1 });
            
            return receiveModelList;
            
        }

        // GET api/<ReceiveController>/5
        [HttpGet("{id}")]
        public ReceiveModel Get(int id)
        {
            ReceiveModel receiveModel = new ReceiveModel() { Id = 1, MailId = 1 };
            return receiveModel;
        }

        // POST api/<ReceiveController>
        [HttpPost("{mailid")]
        public void Post([FromBody] ReceiveModel receive)
        {
        }

        // PUT api/<ReceiveController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ReceiveModel receive)
        {
        }

        // DELETE api/<ReceiveController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
