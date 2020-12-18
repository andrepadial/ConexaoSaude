using ConexaoSaude.Domain.Interfaces.Results;
using ConexaoSaude.Domain.Interfaces.Signatures;
using ConexaoSaude.Domain.Models.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoSaude.Repositorios.Interfaces
{
    public interface IOperadoraRepositorio
    {
        Task<IList<ListarOperadoraResult>> ListarOperadora(IListarOperadoraSignature signature);
    }

}
