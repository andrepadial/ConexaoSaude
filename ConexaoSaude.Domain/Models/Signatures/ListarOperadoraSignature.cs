using ConexaoSaude.Domain.Interfaces.Signatures;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConexaoSaude.Domain.Models.Signatures
{
    public class ListarOperadoraSignature : IListarOperadoraSignature
    {
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
    }
}
