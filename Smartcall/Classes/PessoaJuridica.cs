using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartcall.Classes
{
    class PessoaJuridica : Pessoa
    {
        private string cnpj;
        private string razaoSocial;
        private string nomeResponsavel;
        private string emailResponsavel;
        private string telefoneResponsavel;
        private string inscricaoEstadual;
        private string inscricaoMunicipal;

        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string RazaoSocial { get => razaoSocial; set => razaoSocial = value; }
        public string NomeResponsavel { get => nomeResponsavel; set => nomeResponsavel = value; }
        public string EmailResponsavel { get => emailResponsavel; set => emailResponsavel = value; }
        public string TelefoneResponsavel { get => telefoneResponsavel; set => telefoneResponsavel = value; }
        public string InscricaoEstadual { get => inscricaoEstadual; set => inscricaoEstadual = value; }
        public string InscricaoMunicipal { get => inscricaoMunicipal; set => inscricaoMunicipal = value; }
    }
}
