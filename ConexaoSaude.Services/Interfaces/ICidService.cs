using ConexaoSaude.Domain.Interfaces.Results;
using ConexaoSaude.Domain.Interfaces.Signatures;
using ConexaoSaude.Domain.Models.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoSaude.Services.Interfaces
{
    public interface ICidService
    {
        Task<ObterCidResult> ObterCID(IObterCidSignature signature);
    }
}
