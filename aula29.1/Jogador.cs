using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula29._1
{
    internal class Jogador
    {
        public int energia = 100;

        public bool vivo = true;

        public string nome;

        public Jogador(string n)
        {
            energia = 100;
            vivo = true;
            nome = n;
        }
    }
}
