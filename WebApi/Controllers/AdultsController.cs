using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Data;
using WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers {
[ApiController]
[Route("[controller]")]
public class AdultsController : ControllerBase {
    private IGetFamilies getFamilies;
    public AdultsController(IGetFamilies getFamilies) {
        this.getFamilies = getFamilies;
    }

    [HttpGet]
    public async Task<ActionResult<IList<Adult>>> GetAdults() {
        try {
            IList<Adult> adults = await getFamilies.allAdultsAsync();
            return Ok(adults);
        } catch (Exception e) {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }

    [HttpDelete]
    [Route("{id:int}")]
    public async Task<ActionResult> DeleteAdult([FromRoute] int id) {
        try {
            await getFamilies.RemoveAdultAsync(id);
            return Ok();
        } catch (Exception e) {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }

   [HttpPost]
    public async Task<ActionResult<Adult>> AddAdult([FromBody] Adult adult) {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        try {
            await getFamilies.addNewAdultAsync(adult);
            return Ok(); 
        } catch (Exception e) {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }

    [HttpPatch]
    [Route("{id:int}")]
    public async Task<ActionResult<Adult>> UpdateAdult([FromBody] Adult adult) {
        try {
            await getFamilies.UpdateAdultAsync(adult);
            return Ok(); 
        } catch (Exception e) {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }

    
}
}