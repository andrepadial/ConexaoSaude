using ConexaoSaude.Domain.Interfaces.Results;
using ConexaoSaude.Domain.Interfaces.Signatures;
using ConexaoSaude.Domain.Models.Results;
using ConexaoSaude.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoSaude.App.Interfaces
{
    public class ClienteApp : IClienteApp
    {
        private readonly IClienteService _clienteService;

        public ClienteApp(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public async Task<IObterClienteResult> ObterCliente(IObterClienteSignature signature)
        {
            return await _clienteService.ObterCliente(signature);
        }
        //public ObterClienteResult ObterCliente(IObterClienteSignature signature)
        //{
        //    return _clienteService.ObterCliente(signature);
        //}
    }
}
