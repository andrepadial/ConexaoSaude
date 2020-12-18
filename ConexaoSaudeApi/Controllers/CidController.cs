using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using ConexaoSaude.App.Interfaces;
using ConexaoSaude.Domain.Interfaces.Results;
using ConexaoSaude.Domain.Interfaces.Signatures;
using ConexaoSaude.Domain.Models.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace ConexaoSaudeApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CidController : ControllerBase
    {
        private readonly ICidApp _cidApp;

        public CidController(ICidApp cidApp)
        {
            _cidApp = cidApp;
        }


        [HttpPost]
        [Route("ObterCid")]
        [ProducesResponseType(typeof(IObterCidResult), (int)HttpStatusCode.OK)]
        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Post))]
        public async Task<IActionResult> ObterCid(IObterCidSignature signature)
        {
            try
            {
                var result = await _cidApp.ObterCID(signature);

                if (result == null)
                    result = new ObterCidResult();

                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


    }
}
