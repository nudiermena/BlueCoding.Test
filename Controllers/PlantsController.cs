using BlueCoding.Test.Models;
using BlueCoding.Test.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueCoding.Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlantsController : ControllerBase
    {

        private readonly ILogger<PlantsController> _logger;

        readonly IPlantRepository _plantRepository;

        public PlantsController(ILogger<PlantsController> logger, IPlantRepository plantRepository)
        {
            _logger = logger;
            _plantRepository = plantRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _plantRepository.Get();
            return Ok(result);
        }
    }
}
