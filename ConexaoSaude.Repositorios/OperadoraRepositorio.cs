using ConexaoSaude.Domain.Interfaces.Results;
using ConexaoSaude.Domain.Interfaces.Signatures;
using ConexaoSaude.Domain.Models;
using ConexaoSaude.Domain.Models.Results;
using ConexaoSaude.Repositorios.Connections;
using ConexaoSaude.Repositorios.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoSaude.Repositorios
{
    public class OperadoraRepositorio : IOperadoraRepositorio
    {
        public async Task<IList<ListarOperadoraResult>> ListarOperadora(IListarOperadoraSignature signature)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionStringManager.Value))
            {
                try
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@Cnpj", signature.Cnpj);
                    parameters.Add("@RazaoSocial", signature.RazaoSocial);

                    var result = await conn.QueryAsync<ListarOperadoraResult>("GetOperadora", parameters, null, null, CommandType.StoredProcedure);
                    conn.Close();
                    return result.ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message.ToString());
                }
            }
        }
    }
}
