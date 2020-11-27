using ConexaoSaude.Domain.Interfaces.Results;
using ConexaoSaude.Domain.Interfaces.Signatures;
using ConexaoSaude.Domain.Models.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoSaude.Services.Interfaces
{
    public interface IClienteService
    {
        Task<IObterClienteResult> ObterCliente(IObterClienteSignature signature);
    }
}
