using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartcall.Classes
{
    class Funcionarios : PessoaFisica
    {
        private string user;
        private string password;
        private double salario;
        private string cargo;
        private string estadoCivil;
        private DateTime dataNasc;
        private bool sexo;

        public double Salario { get => salario; set => salario = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public DateTime DataNasc { get => dataNasc; set => dataNasc = value; }
        public bool Sexo { get => sexo; set => sexo = value; }
        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }
    }
}
