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
    public class WedstrijdResultaatController : Controller
    {
        private readonly WedstrijdResultaatLogic logic;
        public WedstrijdResultaatController()
        {
            logic = new WedstrijdResultaatLogic();
        }

        [HttpPost]
        public async Task<HttpResponseMessage> PostWedstrijdResultaatAsync([FromBody] WedstrijdResultaatDTO wedstrijdResultaat)
        {
            try
            {
                await logic.Create(wedstrijdResultaat);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
        }

        [HttpGet]
        public async Task<List<WedstrijdResultaatDTO>> GetWedstrijdResultatenAsync()
        {
            var result = await logic.GetAllAsync();
            return result;
        }

        [HttpGet("{id}")]
        public async Task<WedstrijdResultaatDTO> GetWedstrijdResultaatAsync(int id)
        {
            var result = await logic.GetById(id);
            return result;
        }

        [HttpPut]
        public async Task<HttpResponseMessage> UpdateWedstrijdResultaatAsync([FromBody] WedstrijdResultaatDTO wedstrijdResultaat)
        {
            try
            {
                await logic.UpdateEntity(wedstrijdResultaat);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
        }

        [HttpDelete("{id}")]
        public async Task<HttpResponseMessage> DeleteWedstrijdResultaatAsync(int id)
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
