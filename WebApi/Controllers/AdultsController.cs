using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Db;

namespace WebApi.Controllers {
[ApiController]
[Route("[controller]")]
public class AdultsController : ControllerBase {
    private DataContext adultContext;
    private IDbService service;

    private IList<Adult> currentAdults;
    public AdultsController(IDbService service) {
        this.service = service;
        service.RunDbSetup();
        adultContext = new DataContext();
    }

    [HttpGet]
    public async Task<ActionResult<IList<Adult>>> GetAdults() {
        try {
            IList<Adult> adults = await service.getAllAdultAsync();
            currentAdults = adults;
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
            await service.removeAdultAsync(currentAdults.First(s => s.Id == id));
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
            Adult toAdded = await service.saveAdultAsync(adult);
            return Created($"/{toAdded.FirstName}",toAdded); 
        } catch (Exception e) {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }

    [HttpPatch]
    [Route("{id:int}")]
    public async Task<ActionResult<Adult>> UpdateAdult([FromBody] Adult adult) {
        try {
            await service.updateAdultAsync(adult);
            return Ok(); 
        } catch (Exception e) {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
}
}