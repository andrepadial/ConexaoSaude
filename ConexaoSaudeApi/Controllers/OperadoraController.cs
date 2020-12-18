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
    public class OperadoraController : ControllerBase
    {
        private readonly IOperadoraApp _operadoraApp;

        public OperadoraController(IOperadoraApp operadoraApp)
        {
            _operadoraApp = operadoraApp;
        }

        [HttpPost]
        [Route("ListarOperadora")]
        [ProducesResponseType(typeof(ListarOperadoraResult), (int)HttpStatusCode.OK)]
        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Post))]
        public async Task<IActionResult> ListarOperadora(IListarOperadoraSignature signature)
        {
            try
            {
                var result = await _operadoraApp.ListarOperadora(signature);

                if (result == null)
                    return null;

                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


    }
}
