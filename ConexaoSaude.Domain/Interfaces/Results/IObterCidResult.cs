using ConexaoSaude.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConexaoSaude.Domain.Interfaces.Results
{
    public interface IObterCidResult
    {
        int Id { get; set; }
        string Codigo { get; set; }
        string Descricao { get; set; }
        IList<SubCategoriaCid> SubCategorias { get; set; }
    }
}
