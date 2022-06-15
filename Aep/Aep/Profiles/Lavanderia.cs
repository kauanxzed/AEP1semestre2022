using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aep.Profiles
{
    public class Lavanderia
    {
        public string CNPJ { get; set; }
        public string Nome { get; set; }
        public Endereco Endereco{ get; set; }
        public string Telefone { get; set; }
        public Preco? Preco { get; set; }

        public Lavanderia(string cnpj, string nome, string telefone,
            string cidade, string estado, string rua, string bairro, string numero, string complemento)
        {
            CNPJ = cnpj;
            Nome = nome;
            Endereco = new Endereco(cidade, estado, rua, bairro, numero, complemento);
            Telefone = telefone;
        }

        public void SetPrecos(int roupasLeves, int roupasPesadas, int calcados, int roupasIntimas, int roupasCama)
        {
            Preco = new Preco(roupasLeves, roupasPesadas, calcados, roupasIntimas, roupasCama);
        }
    }
}
