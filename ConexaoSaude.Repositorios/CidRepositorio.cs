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
    public class CidRepositorio : ICidRepositorio
    {
        public async Task<ObterCidResult> ObterCID(IObterCidSignature signature)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionStringManager.Value))
            {
                conn.Open();

                try
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@Codigo", signature.Codigo);
                    parameters.Add("@Descricao", signature.Descricao);

                    var result = await conn.QueryFirstOrDefaultAsync<ObterCidResult>("GetCid", parameters, null, null, CommandType.StoredProcedure);
                    

                    if (result != null)
                        result.SubCategorias = await ObterSubCategorias(result.Codigo);

                    conn.Close();
                    return result;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message.ToString());
                }
            }
        }

        private async Task<IList<SubCategoriaCid>> ObterSubCategorias(string codigoCID)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionStringManager.Value))
            {
                try
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@CodigoCid", codigoCID);                    

                    var result = await conn.QueryAsync<SubCategoriaCid>("GetSubCategoriasCid", parameters, null, null, CommandType.StoredProcedure);                     
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
