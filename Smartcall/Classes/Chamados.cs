using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartcall.Classes
{
    class Chamados
    {
        private int codigo;
        private string assunto;
        private string descricao;
        private bool status;
        private string prioridade;
        private DateTime dtAbertuda;
        private DateTime dtFechamento;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Assunto { get => assunto; set => assunto = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public bool Status { get => status; set => status = value; }
        public string Prioridade { get => prioridade; set => prioridade = value; }
        public DateTime DtAbertuda { get => dtAbertuda; set => dtAbertuda = value; }
        public DateTime DtFechamento { get => dtFechamento; set => dtFechamento = value; }
    }
}
