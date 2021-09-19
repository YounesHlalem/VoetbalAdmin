using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using VoetbalAdmin.BLL.Logic;
using VoetbalAdmin.DataContracts.DTO;

namespace VoetbalAdmin.Service.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SeizoenController : Controller
    {
        private readonly SeizoenLogic logic;
        public SeizoenController()
        {
            logic = new SeizoenLogic();
        }

        [HttpPost]
        public async Task<HttpResponseMessage> PostSeizoenAsync([FromBody] SeizoenDTO seizoen)
        {
            try
            {
                await logic.Create(seizoen);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
        }

        [HttpGet]
        public async Task<List<SeizoenDTO>> GetSeizoenenAsync()
        {
            var result = await logic.GetAllAsync();
            return result;
        }

        [HttpGet("{id}")]
        public async Task<SeizoenDTO> GetSeizoenAsync(int id)
        {
            var result = await logic.GetById(id);
            return result;
        }

        [HttpPut]
        public async Task<HttpResponseMessage> UpdateSeizoenAsync([FromBody] SeizoenDTO seizoen)
        {
            try
            {
                await logic.UpdateEntity(seizoen);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
        }

        [HttpDelete("{id}")]
        public async Task<HttpResponseMessage> DeleteSeizoenAsync(int id)
        {
            try
            {
                await logic.DeleteById(id);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
        }
    }
}
