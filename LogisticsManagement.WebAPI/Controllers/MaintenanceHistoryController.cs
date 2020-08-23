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
    public class MaintenanceHistoryController : ControllerBase
    {
        private IMaintenanceHistoryService _maintenanceHistoryService;

        public MaintenanceHistoryController(IMaintenanceHistoryService maintenanceHistoryService)
        {
            _maintenanceHistoryService = maintenanceHistoryService;
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _maintenanceHistoryService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _maintenanceHistoryService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(MaintenanceHistory maintenanceHistory)
        {
            var result = _maintenanceHistoryService.Add(maintenanceHistory);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(MaintenanceHistory maintenanceHistory)
        {
            var result = _maintenanceHistoryService.Update(maintenanceHistory);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(MaintenanceHistory maintenanceHistory)
        {
            var result = _maintenanceHistoryService.Delete(maintenanceHistory);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}
