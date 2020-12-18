using ConexaoSaude.Domain.Interfaces.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConexaoSaude.Domain.Models.Results
{
    public class ObterCidResult : IObterCidResult
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public IList<SubCategoriaCid> SubCategorias { get; set; }
    }
}
