using IntegrationApi.Service;
using IntegrationApi.Service.Interfaces;
using IntegrationApi.Service.Model;
using IntegrationApi.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IntegrationApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransformerController : ControllerBase
    {
        private readonly ITransfrom _transfrom;
        public TransformerController(ITransfrom transfrom)
        {
            _transfrom = transfrom;
        }

        [HttpPost]
        public async Task<IActionResult> TransformToCsv([FromBody]Patient patient)
        { 
            await _transfrom.TransformToCsv(patient);

            return Ok();
        }
    }
}
