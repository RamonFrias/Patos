using Patos.Domains.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patos.Domains.Abstract
{
    public abstract class Pato
    {
        protected Padrao_Voaveis comportamento_pato;
        protected Corrida comportamento_pato_corrida;
        protected Maratona comportamento_pato_maratona;

        public abstract string Mostrar();

        public static string Nadar()
        {
            return "Pato Nadando";
        }

        public void SetCOmpartamento(Padrao_Voaveis padrao)
        {
            comportamento_pato = padrao;
        }

        public void SetCOmpartamento(Corrida padrao)
        {
            comportamento_pato_corrida = padrao;
        }

        public void SetCOmpartamento(Maratona padrao)
        {
            comportamento_pato_maratona = padrao;
        }

        public string Comportamento_pato()
        {
            return comportamento_pato.Voar();
        }
        public string Comportamento_pato_correr()
        {
            return comportamento_pato_corrida.Correr();
        }
        public string Comportamento_pato_maratonar()
        {
            return comportamento_pato_maratona.Correr();
        }
    }
}
