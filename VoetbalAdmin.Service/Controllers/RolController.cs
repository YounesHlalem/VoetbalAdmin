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
    public class RolController : Controller
    {
        private readonly RolLogic logic;
        public RolController()
        {
            logic = new RolLogic();
        }

        [HttpPost]
        public async Task<HttpResponseMessage> PostRolAsync([FromBody] RolDTO rol)
        {
            try
            {
                await logic.Create(rol);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
        }

        [HttpGet]
        public async Task<List<RolDTO>> GetRollenAsync()
        {
            var result = await logic.GetAllAsync();
            return result;
        }

        [HttpGet("{id}")]
        public async Task<RolDTO> GetRolAsync(int id)
        {
            var result = await logic.GetById(id);
            return result;
        }

        [HttpPut]
        public async Task<HttpResponseMessage> UpdateRolAsync([FromBody] RolDTO rol)
        {
            try
            {
                await logic.UpdateEntity(rol);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
        }

        [HttpDelete("{id}")]
        public async Task<HttpResponseMessage> DeleteRolAsync(int id)
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
