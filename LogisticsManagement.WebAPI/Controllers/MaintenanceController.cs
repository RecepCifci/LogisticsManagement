using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LogisticsManagement.BusinessLayer.Abstract;
using LogisticsManagement.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LogisticsManagement.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaintenanceController : ControllerBase
    {
        private IMaintenanceService _maintenanceService;

        public MaintenanceController(IMaintenanceService maintenanceService)
        {
            _maintenanceService = maintenanceService;
        }
     
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _maintenanceService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _maintenanceService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Maintenance maintenance)
        {
            var result = _maintenanceService.Add(maintenance);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(Maintenance maintenance)
        {
            var result = _maintenanceService.Update(maintenance);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Maintenance maintenance)
        {
            var result = _maintenanceService.Delete(maintenance);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}
