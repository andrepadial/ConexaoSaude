using ConexaoSaude.Domain.Interfaces.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConexaoSaude.Domain.Models.Results
{
    public class ObterSubCategoriaCidResult : IObterSubCategoriasCidResult
    {
        public IList<SubCategoriaCid> SubCategorias { get; set; }
    }
}
