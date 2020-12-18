using System;
using System.Collections.Generic;
using System.Text;

namespace ConexaoSaude.Domain.Interfaces.Results
{
    public interface IListarOperadoraResult
    {
        int Id { get; set; }
        string CodigoANS { get; set; }
        string Cnpj { get; set; }
        string RazaoSocial { get; set; }
        string NomeFantasia { get; set; }
        string Modalidade { get; set; }
        string Endereco { get; set; }
        string Numero { get; set; }
        string Complemento { get; set; }
        string Bairro { get; set; }
        string Cidade { get; set; }
        string Uf { get; set; }
        float? Cep { get; set; }
        float? Ddd { get; set; }
        float? Telefone { get; set; }
        string Email { get; set; }
        string Representante { get; set; }
        string CargoRepresentante { get; set; }
    }
}
