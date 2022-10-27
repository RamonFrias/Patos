using Patos.Domains.Abstract;
using Patos.Domains.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patos.Domains
{
    public class Pato_Maratonista : Pato, Padrao_Grasnar
    {
        public Pato_Maratonista()
        {
            SetCOmpartamento(new Maratona());
        }

        public override string Mostrar()
        {
            return "Eu sou o Pato Corredor";
        }
        public string Grasnar()
        {
            return "Que-Que, Vamos maratonar";
        }
    }
}
