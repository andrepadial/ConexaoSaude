using ConexaoSaude.Domain.Interfaces.Signatures;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConexaoSaude.Domain.Models.Signatures
{
    public class ObterCidSignature : IObterCidSignature
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
    }
}
