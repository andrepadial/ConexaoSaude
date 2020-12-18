using System;
using System.Collections.Generic;
using System.Text;

namespace ConexaoSaude.Domain.Models
{
    public class CategoriaCid
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public IList<SubCategoriaCid> SubCategorias { get; set; }
    }
}
