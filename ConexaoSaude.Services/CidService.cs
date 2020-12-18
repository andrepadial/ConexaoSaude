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
    public class CidService : ICidService
    {

        private readonly ICidRepositorio _cidRepositorio;

        public CidService(ICidRepositorio cidRepositorio)
        {
            _cidRepositorio = cidRepositorio;
        }

        public async Task<ObterCidResult> ObterCID(IObterCidSignature signature)
        {
            return await _cidRepositorio.ObterCID(signature);
        }
    }
}
