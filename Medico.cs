using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova4b.Classes
{
    internal class Medico: Funcionario
    {
       public string RegistroCo { get; set; }
        public double HoraExtra { get; set; }
        public string Especialidade { get; set; }

        public Medico(string registroCo, double horaExtra, string especialidade): base()
        {
            RegistroCo = registroCo;
            HoraExtra = horaExtra;
            Especialidade = especialidade;

            Salario = Salario + ((Salario * 0.20)/100) + horaExtra;
        }

        public Medico()
        {

        }
    }
}
