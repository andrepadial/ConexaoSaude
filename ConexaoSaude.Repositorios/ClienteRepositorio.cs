using ConexaoSaude.Domain.Interfaces.Results;
using ConexaoSaude.Domain.Interfaces.Signatures;
using ConexaoSaude.Domain.Models.Results;
using ConexaoSaude.Repositorios.Connections;
using ConexaoSaude.Repositorios.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoSaude.Repositorios
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        public async Task<ObterClienteResult> ObterCliente(IObterClienteSignature signature)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionStringManager.Value))
            {
                conn.Open();
                var result = await conn.QueryFirstOrDefaultAsync<ObterClienteResult>("GetCliente", new { CpfCnpj = signature.CpfCnpj });
                conn.Close();
                return result;
            }
        }
    }
}
