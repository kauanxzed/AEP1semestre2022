using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aep.Profiles
{
    public class Endereco
    {
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }

        public Endereco(string cidade, string estado, string rua, string bairro, string numero, string complemento)
        {
            Cidade = cidade;
            Estado = estado;
            Rua = rua;
            Bairro = bairro;
            Numero = numero;
            Complemento = complemento;
        }
    }
}
