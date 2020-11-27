using ConexaoSaude.Domain.Interfaces.Signatures;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConexaoSaude.Domain.Models.Signatures
{
    public class ObterClienteSignature : IObterClienteSignature
    {
        public string CpfCnpj { get; set; }
    }
}
