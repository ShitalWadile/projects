using HomeLoanApi.Models;
using HomeLoanApi.Models.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HomeLoanApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class LoanDetailsController : ControllerBase
    {
        private readonly ILoanDetailsRepo _DbContext;

        public LoanDetailsController(ILoanDetailsRepo DbContext)
        {
            _DbContext = DbContext ??
                throw new ArgumentNullException(nameof(DbContext));
        }

        [HttpGet]
        [Route("GetDetails")]
        public async Task<IActionResult> GetDetails()
        {
            return Ok(await _DbContext.GetDetails());
        }

        [HttpGet]
        [Route("GetDetailsByID/{Id}")]

        public async Task<IActionResult> GetDetailsById(int Id)
        {
            return Ok(await _DbContext.GetDetailsByID(Id));
        }

        [HttpPost]
        [Route("AddLoanDetails")]
        public async Task<IActionResult> Post(LoanDetails det)
        {
            var result = await _DbContext.InsertDetails(det);
            if (result.Application_Id == 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something Went Wrong");
            }
            return Ok("Added Successfully");
        }


        [HttpPut]
        [Route("UpdateLoanDetails")]
        public async Task<IActionResult> Put(LoanDetails det)
        {
            await _DbContext.InsertDetails(det);
            return Ok("Updated Successfully");
        }

        [HttpDelete]
        //[HttpDelete("{id}")]
        [Route("DeleteLoanDetails")]
        public JsonResult Delete(int id)
        {
            _DbContext.DeleteDetails(id);
            return new JsonResult("Deleted Successfully");
        }
    }
}
