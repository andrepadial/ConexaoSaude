using ConexaoSaude.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConexaoSaude.Domain.Interfaces.Results
{
    public interface IObterSubCategoriasCidResult
    {
        IList<SubCategoriaCid> SubCategorias { get; set; }
    }
}
