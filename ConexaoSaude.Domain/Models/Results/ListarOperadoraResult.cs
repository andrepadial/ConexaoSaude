using ConexaoSaude.Domain.Interfaces.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConexaoSaude.Domain.Models.Results
{
    public class ListarOperadoraResult : IListarOperadoraResult
    {
        public int Id { get; set; }
        public string CodigoANS { get; set; }
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Modalidade { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public float? Cep { get; set; }
        public float? Ddd { get; set; }
        public float? Telefone { get; set; }
        public string Email { get; set; }
        public string Representante { get; set; }
        public string CargoRepresentante { get; set; }
    }
}
