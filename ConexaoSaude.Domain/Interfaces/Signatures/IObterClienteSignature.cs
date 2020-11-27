using System;
using System.Collections.Generic;
using System.Text;

namespace ConexaoSaude.Domain.Interfaces.Signatures
{
    public interface IObterClienteSignature
    {
        string CpfCnpj { set; get; }
    }
}
