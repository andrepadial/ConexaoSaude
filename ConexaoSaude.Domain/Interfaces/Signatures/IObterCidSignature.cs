using System;
using System.Collections.Generic;
using System.Text;

namespace ConexaoSaude.Domain.Interfaces.Signatures
{
    public interface IObterCidSignature
    {
        string Codigo { get; set; }
        string Descricao { get; set; }
    }
}
