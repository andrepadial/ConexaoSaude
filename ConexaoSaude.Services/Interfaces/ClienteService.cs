using ConexaoSaude.Domain.Interfaces.Results;
using ConexaoSaude.Domain.Interfaces.Signatures;
using ConexaoSaude.Domain.Models.Results;
using ConexaoSaude.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoSaude.Services.Interfaces
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteService(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public async Task<IObterClienteResult> ObterCliente(IObterClienteSignature signature)
        {
            return await _clienteRepositorio.ObterCliente(signature);
        }

        //public ObterClienteResult ObterCliente(IObterClienteSignature signature)
        //{
        //    return _clienteRepositorio.ObterCliente(signature);
        //}
    }
}
