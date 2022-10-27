using Patos.Domains.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Patos.Domains
{
    public class Maratona : Padrao_Correr
    {
        private readonly double velocidade;
        public Maratona()
        {
            velocidade = 18;
        }
        public string Correr()
        {
            return $"Esse pato é maratonista. Distancia: {GetVelocidade()} km";
        }
        public double GetVelocidade()
        {
            return velocidade;
        }
    }
}
