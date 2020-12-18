using ConexaoSaude.App.Interfaces;
using ConexaoSaude.Domain.Interfaces.Results;
using ConexaoSaude.Domain.Interfaces.Signatures;
using ConexaoSaude.Domain.Models.Results;
using ConexaoSaude.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace ConexaoSaude.App
{
    public class OperadoraApp : IOperadoraApp
    {

        private readonly IOperadoraService _operadoraService;

        public OperadoraApp (IOperadoraService operadoraService)
        {
            _operadoraService = operadoraService;
        }

        public async Task<IList<ListarOperadoraResult>> ListarOperadora(IListarOperadoraSignature signature)
        {
            return await _operadoraService.ListarOperadora(signature);
        }
    }
}
