using HomeLoanApi.Models;
using HomeLoanApi.Models.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HomeLoanApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ApplicationFormController : ControllerBase
    {
        private readonly HomeLoanContext _dbcontext;

        public ApplicationFormController(HomeLoanContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApplicationForm>>> GetApplicationForms()
        {
            if (_dbcontext.ApplicationForms == null)
            {
                return NotFound();
            }
            return await _dbcontext.ApplicationForms.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ApplicationForm>> GetApplicationFrom(int id)
        {
            if (_dbcontext.ApplicationForms == null)
            {
                return NotFound();
            }
            var applicationform = await _dbcontext.ApplicationForms.FindAsync(id);
            if (applicationform == null)
            {
                return NotFound();
            }
            return applicationform;

        }



        [HttpPost]
        public async Task<ActionResult<ApplicationForm>> PostApplicationForm(ApplicationForm applicationForm)
        {
            _dbcontext.ApplicationForms.Add(applicationForm);
            await _dbcontext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetApplicationFrom), new { id = applicationForm.Application_Id }, applicationForm);
        }

        [HttpPut]
        public async Task<IActionResult> PutApplicationForm(int Application_Id, ApplicationForm applicationForm)
        {
            if (Application_Id != applicationForm.Application_Id)
            {
                return BadRequest();
            }

            _dbcontext.Entry(applicationForm).State = EntityState.Modified;
            try
            {
                await _dbcontext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (ApplicationFormAvailable(Application_Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Ok();
        }

        private bool ApplicationFormAvailable(int id)
        {
            return (_dbcontext.ApplicationForms?.Any(x => x.Application_Id == id)).GetValueOrDefault();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApplicationForm(int id)
        {
            if (_dbcontext.ApplicationForms == null)
            {
                return NotFound();
            }

            var applicationform = await _dbcontext.ApplicationForms.FindAsync(id);
            if (applicationform == null)
            {
                return NotFound();
            }

            _dbcontext.ApplicationForms.Remove(applicationform);

            await _dbcontext.SaveChangesAsync();
            return Ok();
        }
    } 
}

