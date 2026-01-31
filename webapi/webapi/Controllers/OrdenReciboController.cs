using Microsoft.AspNetCore.Mvc;
using webapi.Interface;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdenReciboController : ControllerBase
    {
        private readonly IOrdenRecibo _ior;
        public OrdenReciboController(IOrdenRecibo ior) 
        {
            _ior = ior;
        }

        // GET: api/<OrdenReciboController>
        [HttpGet]
        public IActionResult GetORRevisadas()
        {
            return Ok(_ior.ConsultaOrdenesRevisadas);
        }

        // GET api/<OrdenReciboController>/5
        [HttpGet("{numrecibo}")]
        public IActionResult GetObject(string numrecibo)
        {
            return Ok(_ior.ConsultaOrdenesRevisadaObjet(numrecibo));
        }

        // POST api/<OrdenReciboController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<OrdenReciboController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrdenReciboController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
