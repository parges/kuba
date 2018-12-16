using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using kubaapi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace kuba_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly PatientContext _context;

        public PatientController(PatientContext context)
        {
            _context = context;
            if (_context.Patients.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _context.Patients.Add(new Patient { Id = 0, Firstname = "Kleiner", Lastname = "Hase", Age = 5, Address = "Irgendwo 12", Description = "Ein ganz lieber Patient"});
                _context.SaveChanges();
            }
        }

        // GET: api/Patient
        [HttpGet]
        public ActionResult<List<Patient>> GetAll()
        {
             return _context.Patients.ToList();
        }

        // GET: api/Patient/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<Patient> Get(long id)
        {
            var item = _context.Patients.Find(id);
            if (item == null)
            {
                return NotFound();
            }

            return item;
        }

        // POST: api/Patient
        [HttpPost]
        public ActionResult CreatePatient([FromBody] Patient item)
        {
            _context.Patients.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("Get", new {id = item.Id}, item);
        }

        // PUT: api/Patient/5
        [HttpPut("{id}")]
        public ActionResult Update(long id, [FromBody] Patient item)
        {
            var patient = _context.Patients.Find(id);
            if (patient == null)
            {
                return NotFound();
            }

            patient.Firstname = item.Firstname;
            patient.Lastname= item.Lastname;
            patient.Address= item.Address;
            patient.Age= item.Age;
            patient.Description = item.Description;

            _context.Patients.Update(patient);
            _context.SaveChanges();
            return NoContent();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            var patient = _context.Patients.Find(id);
            if (patient == null)
            {
                return NotFound();
            }

            _context.Patients.Remove(patient);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
