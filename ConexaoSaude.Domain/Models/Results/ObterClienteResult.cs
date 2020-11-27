using ConexaoSaude.Domain.Interfaces.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConexaoSaude.Domain.Models.Results
{
    public class ObterClienteResult : IObterClienteResult
    {
        public int Id { get; set; }
        public string CpfCnpj { get; set; }
        public string RG { get; set; }
        public string OrgaoExpedidor { get; set; }
        public string Nome { get; set; }
        public string Mae { get; set; }
        public DateTime? DataNascimento { get; set; }
        public DateTime? DataExpedicao { get; set; }
    }
}
