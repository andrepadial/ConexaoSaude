using System;
using System.Collections.Generic;
using System.Text;

namespace ConexaoSaude.Domain.Interfaces.Results
{
    public interface IObterClienteResult
    {
        int Id { get; set; }
        string CpfCnpj { get; set; }
        string RG { get; set; }
        string OrgaoExpedidor { get; set; }
        string Nome { get; set; }
        string Mae { get; set; }
        DateTime? DataNascimento { get; set; }
        DateTime? DataExpedicao { get; set; }

    }
}
