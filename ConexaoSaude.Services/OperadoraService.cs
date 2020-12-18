using ConexaoSaude.Domain.Interfaces.Results;
using ConexaoSaude.Domain.Interfaces.Signatures;
using ConexaoSaude.Domain.Models.Results;
using ConexaoSaude.Repositorios.Interfaces;
using ConexaoSaude.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace ConexaoSaude.Services
{
    public class OperadoraService : IOperadoraService
    {

        private readonly IOperadoraRepositorio _operadoraRepositorio;

        public OperadoraService (IOperadoraRepositorio operadoraRepositorio)
        {
            _operadoraRepositorio = operadoraRepositorio;
        }

        public async Task<IList<ListarOperadoraResult>> ListarOperadora(IListarOperadoraSignature signature)
        {
            return await _operadoraRepositorio.ListarOperadora(signature);
        }
    }
}
