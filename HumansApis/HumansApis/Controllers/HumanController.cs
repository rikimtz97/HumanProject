using HumansApis.Models.Domain;
using HumansApis.Models.DTO;
using HumansApis.Repositories;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace HumansApis.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HumanController : Controller
    {
        private readonly IHumansRepository repository;

        public HumanController(IHumansRepository repository)
        {
            this.repository = repository;
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody]HumansDTO human)
        {
            var NewHuman = new humans()
            {
                Name = human.Name,
                Age = human.Age,
                Gender = human.Gender,
                Height = human.Height,
                Weight = human.Weight
            };
            NewHuman = await repository.AddHuman(NewHuman);
            return Ok(NewHuman);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllHumans() 
        {
            var Human = await repository.GetAll();
            return Ok(Human);
        }
        [HttpGet]
        [Route("{Id:guid}")]
        public async Task<IActionResult> GetOneHuman([FromRoute] Guid Id)
        {
            var Human = await repository.GetHumanById(Id);
            if(Human== null)
            {
                return NotFound();
            }
            return Ok(Human);
        }
        [HttpPut]
        [Route("{Id:guid}")]

        public async Task<IActionResult> UpdateHuman([FromRoute] Guid Id, [FromBody] HumansDTO human) 
        {
            var NewHuman = new humans()
            {
                Id = Id,
                Name = human.Name,
                Age = human.Age,
                Gender = human.Gender,
                Height = human.Height,
                Weight = human.Weight
            };
            NewHuman = await repository.UpdateHuman(NewHuman);
            if (NewHuman == null)
            {
                return BadRequest();
            }
            return Ok(human);
        }

    }
}
