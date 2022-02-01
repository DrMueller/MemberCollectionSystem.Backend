using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mmu.MemberCollectionSystem.Areas.MemberAddresses.Dtos;
using System.Diagnostics;

namespace Mmu.MemberCollectionSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MemberAddressesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IReadOnlyCollection<MemberAddressDto>> Get()
        {
            Debug.WriteLine("In Get");

            var dtos = Enumerable.Range(1, 5).Select(index => new MemberAddressDto
            {
Id = index,
HouseNumber = 10 + index,
StreetName = "Street " + index
            }).ToList();

            return Ok(dtos);
        }

        [HttpGet("{id:int}")]
        public ActionResult<MemberAddressDto> Get([FromRoute] int id)
        {
            Debug.WriteLine("In Get by ID");

            var dto = new MemberAddressDto
            {
                Id = id,
                HouseNumber = 25,
                StreetName = "Street " + id
            };

            return Ok(dto);
        }

        [HttpPut]
        public ActionResult<MemberAddressDto> Upsert([FromBody] MemberAddressDto dto)
        {
            Debug.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(dto));

            return Ok(
                new MemberAddressDto
                {
                    StreetName = dto.StreetName + " Updated",
                    HouseNumber = dto.HouseNumber + 100,
                    Id = 50
                });
        }
    }
}
