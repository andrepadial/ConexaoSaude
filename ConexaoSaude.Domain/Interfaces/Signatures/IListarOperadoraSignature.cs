using System;
using System.Collections.Generic;
using System.Text;

namespace ConexaoSaude.Domain.Interfaces.Signatures
{
    public interface IListarOperadoraSignature
    {
        string Cnpj { get; set; }
        string RazaoSocial { get; set; }        

    }
}
