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
    public class ReeksController : Controller
    {
        private readonly ReeksLogic logic;
        public ReeksController()
        {
            logic = new ReeksLogic();
        }

        [HttpPost]
        public async Task<HttpResponseMessage> PostReeksAsync([FromBody] ReeksDTO reeks)
        {
            try
            {
                await logic.Create(reeks);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
        }

        [HttpGet]
        public async Task<List<ReeksDTO>> GetReeksenAsync()
        {
            var result = await logic.GetAllAsync();
            return result;
        }

        [HttpGet("{id}")]
        public async Task<ReeksDTO> GetReeksAsync(int id)
        {
            var result = await logic.GetById(id);
            return result;
        }

        [HttpPut]
        public async Task<HttpResponseMessage> UpdateReeksAsync([FromBody] ReeksDTO reeks)
        {
            try
            {
                await logic.UpdateEntity(reeks);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
        }

        [HttpDelete("{id}")]
        public async Task<HttpResponseMessage> DeleteReeksAsync(int id)
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
