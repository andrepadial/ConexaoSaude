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
    public class CidApp : ICidApp
    {
        private readonly ICidService _cidService;

        public CidApp(ICidService cidService)
        {
            _cidService = cidService;
        }

        public async Task<ObterCidResult> ObterCID(IObterCidSignature signature)
        {
            return await _cidService.ObterCID(signature);
        }
    }
}
