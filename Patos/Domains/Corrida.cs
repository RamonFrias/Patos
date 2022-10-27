using Patos.Domains.Interface;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patos.Domains
{
    public class Corrida : Padrao_Correr
    {
        private readonly double velocidade;
        public Corrida()
        {
            velocidade = 10;
        }
        public string Correr()
        {
            return $"Esse pato corre. Velociade: {GetVelocidade()} km/h";
        }
        public double GetVelocidade()
        {
            return velocidade;
        }
    }
}
