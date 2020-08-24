using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LogisticsManagement.BusinessLayer.Abstract;
using LogisticsManagement.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LogisticsManagement.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PictureGroupController : ControllerBase
    {
        private IPictureGroupService _pictureGroupService;

        public PictureGroupController(IPictureGroupService pictureGroupService)
        {
            _pictureGroupService = pictureGroupService;
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _pictureGroupService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _pictureGroupService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(PictureGroup pictureGroup)
        {
            var result = _pictureGroupService.Add(pictureGroup);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(PictureGroup pictureGroup)
        {
            var result = _pictureGroupService.Update(pictureGroup);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(PictureGroup pictureGroup)
        {
            var result = _pictureGroupService.Delete(pictureGroup);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}
