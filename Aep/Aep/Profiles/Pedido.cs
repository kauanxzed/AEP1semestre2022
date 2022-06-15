using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aep.Profiles
{
    public class Pedido
    {
        public static int PedidoCod { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public int Quant_RL { get; set; }
        public int Quant_RP { get; set; }
        public int Quant_CAl { get; set; }
        public int Quant_RI { get; set; }
        public int Quant_RC { get; set; }

        public Pedido(string cpf, string cnpj, int quant_RL, int quant_RP, int quant_CAl, int quant_RI, int quant_RC)
        {
            PedidoCod++;
            CPF = cpf;
            CNPJ = cnpj;
            Quant_RL = quant_RL;
            Quant_RP = quant_RP;
            Quant_CAl = quant_CAl;
            Quant_RI = quant_RI;
            Quant_RC = quant_RC;
        }
    }
}
