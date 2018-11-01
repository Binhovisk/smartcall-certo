using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartcall.Classes
{
    class Pessoa
    {
        private string nome;
        private string logradouro;
        private int nro;
        private string cidade;
        private string estado;
        private string cep;
        private string telefone;
        private string email;

        public string Nome { get => nome; set => nome = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public int Nro { get => nro; set => nro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
    }
}
