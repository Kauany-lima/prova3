using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova4b.Classes
{
    internal class Administrativo: Funcionario
    {
        public string Funcao { get;set; }

        public Administrativo(string funcao): base()
        {
            Funcao = funcao;

           Salario = (Salario + ((Salario * 0.15)/100)) + 150;

        }

        public Administrativo()
        {
        }

        
       
    }
}
