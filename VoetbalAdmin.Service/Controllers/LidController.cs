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
    public class LidController : Controller
    {
        private readonly LidLogic logic;
        public LidController()
        {
            logic = new LidLogic();
        }

        [HttpPost]
        public async Task<HttpResponseMessage> PostLidAsync([FromBody] LidDTO lid)
        {
            try
            {
                await logic.Create(lid);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
        }

        [HttpGet]
        public async Task<List<LidDTO>> GetLedenAsync()
        {
            var result = await logic.GetAllAsync();
            return result;
        }

        [HttpGet("{id}")]
        public async Task<LidDTO> GetLidAsync(int id)
        {
            var result = await logic.GetById(id);
            return result;
        }

        [HttpPut]
        public async Task<HttpResponseMessage> UpdateLidAsync([FromBody] LidDTO lid)
        {
            try
            {
                await logic.UpdateEntity(lid);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
        }

        [HttpDelete("{id}")]
        public async Task<HttpResponseMessage> DeleteLidAsync(int id)
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
