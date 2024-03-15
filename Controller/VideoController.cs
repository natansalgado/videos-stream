using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using videos_steam.Dtos;
using videos_steam.Exceptions;
using videos_steam.Models;
using videos_steam.Services.Interfaces;


namespace videos_steam.Controller
{
    [Route("api/[controller]")]
    public class VideoController : ControllerBase
    {
        private readonly IVideoService _service;
        private readonly string ServerErrorMessage = "Erro ao tentar acessar o servidor.";

        public VideoController(IVideoService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<VideoModel>> GetAll()
        {
            try
            {
                List<VideoModel> videos = _service.GetAll();

                return Ok(videos);
            }
            catch (Exception)
            {
                return BadRequest(ServerErrorMessage);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<VideoModel> GetById(int id)
        {
            try
            {
                VideoModel video = _service.GetById(id);

                return Ok(video);
            }
            catch (VSException ex)
            {
                return StatusCode(ex.StatusCode, ex.Message);
            }
            catch (Exception)
            {
                return BadRequest(ServerErrorMessage);
            }
        }

        [HttpPost]
        public ActionResult<VideoModel> Create([FromBody] VideoDto videoDto)
        {
            try
            {
                VideoModel video = _service.Create(videoDto);

                return Ok(video);
            }
            catch (VSException ex)
            {
                return StatusCode(ex.StatusCode, ex.Message);
            }
            catch (Exception)
            {
                return BadRequest(ServerErrorMessage);
            }
        }

        [HttpPatch("{id}")]
        public ActionResult<VideoModel> Update(int id, [FromBody] VideoDto videoDto)
        {
            try
            {
                VideoModel video = _service.Update(id, videoDto);

                return Ok(video);
            }
            catch (VSException ex)
            {
                return StatusCode(ex.StatusCode, ex.Message);
            }
            catch (Exception)
            {
                return BadRequest(ServerErrorMessage);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<VideoModel> Delete(int id)
        {
            try
            {
                _service.Delete(id);

                return Ok();
            }
            catch (VSException ex)
            {
                return StatusCode(ex.StatusCode, ex.Message);
            }
            catch (Exception)
            {
                return BadRequest(ServerErrorMessage);
            }
        }
    }
}