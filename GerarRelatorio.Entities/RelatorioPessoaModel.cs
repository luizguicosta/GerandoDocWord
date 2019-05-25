using System;
using System.Collections.Generic;
using System.Text;

namespace GerarRelatorio.Entities
{
    public class RelatorioPessoaModel
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime DataPromocao { get; set; }
        public string Descricao { get; set; }

        public Dictionary<string, string> PropriedadesPessoa()
        {
            var dicPessoa = new Dictionary<string, string>();

            dicPessoa.Add("Nome", this.Nome);
            dicPessoa.Add("Sobrenome", this.Sobrenome);
            dicPessoa.Add("Idade", this.Idade.ToString());
            dicPessoa.Add("DataNascimento", this.DataNascimento.ToShortDateString());
            dicPessoa.Add("DataPromocao", this.DataNascimento.ToShortDateString());
            dicPessoa.Add("DataAdmissao", this.DataNascimento.ToShortDateString());
            dicPessoa.Add("Descricao", this.Descricao);
            
            return dicPessoa;
        }
    }
}
