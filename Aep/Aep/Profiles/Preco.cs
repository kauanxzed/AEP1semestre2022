using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aep.Profiles
{
    public class Preco
    {
        public int RoupasLeves { get; set; }
        public int RoupasPesadas { get; set; }
        public int Calcados { get; set; }
        public int RoupasIntimas { get; set; }
        public int RoupasCama { get; set; }

        public Preco(int roupasLeves, int roupasPesadas, int calcados, int roupasIntimas, int roupasCama)
        {
            RoupasLeves = roupasLeves;
            RoupasPesadas = roupasPesadas;
            Calcados = calcados;
            RoupasIntimas = roupasIntimas;
            RoupasCama = roupasCama;
        }
    }
}
