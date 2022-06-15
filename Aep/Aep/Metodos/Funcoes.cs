using Aep.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aep.Metodos
{
    public class Funcoes
    { 
        public Funcoes()
        {

        }
        public static string GetCampo(string nomeDoCampo)
        {
            Console.Write($"{nomeDoCampo}: ");
            var content = Console.ReadLine();
            if (content == null)
            {
                content = "";
            }
            return content;
        }

        public static int GetInt(string nomeDoCampo)
        {
            Console.Write($"{nomeDoCampo}: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public void MostrarLavanderia(Lavanderia lavanderia)
        {
            Console.WriteLine(lavanderia.Nome);
            Console.WriteLine(lavanderia.Endereco.Rua + "-" + lavanderia.Endereco.Numero);
        }

        public void VerPedidos(List<Pedido> pedidos)
        {
            Console.Clear();
            foreach (var pedido  in pedidos)
            {
                Console.WriteLine($"PEDIDO: {Pedido.PedidoCod}");
                Console.Write("CPF: ");
                Console.WriteLine(pedido.CPF);
                Console.Write("CNPJ: ");
                Console.WriteLine(pedido.CNPJ);
                Console.Write("Quantidade de roupas leves: ");
                Console.WriteLine(pedido.Quant_RL);
                Console.Write("Quantidade de roupas pesadas: ");
                Console.WriteLine(pedido.Quant_RP);
                Console.Write("Quantidade de calcados: ");
                Console.WriteLine(pedido.Quant_CAl);
                Console.Write("Quantidade de roupas intimas: ");
                Console.WriteLine(pedido.Quant_RI);
                Console.Write("Quantidade de roupas leves: ");
                Console.WriteLine(pedido.Quant_RC);
            }
        }

        public void FazerPedido(List<Pedido> pedidos, string cnpj, string cpf)
        {
            Console.Clear();
            pedidos.Add(new Pedido(cpf, cnpj, GetInt("Quantidade Roupas Leves"), GetInt("Quantidade Roupas Pesadas"),
                GetInt("Quantidade Calcados"), GetInt("Quantidade Roupas Intimas"), GetInt("Quantidade Roupas De Cama")));
        }

        public void Login(List<Usuario> usuarios)
        {
            bool logado = false;
            while(!logado)
            {
                Console.Clear();
                Console.WriteLine("1 - Log-in");
                Console.WriteLine("2 - Cadastro");
                var keypressed = Console.ReadKey();
                switch (keypressed.KeyChar)
                {
                    case '1': // LOG-IN
                        Console.Clear();
                        Console.Write("Email: ");
                        var username = Console.ReadLine();
                        Console.Write("Password: ");
                        var password = Console.ReadLine();
                        foreach (var usuario in usuarios)
                        {  
                            if (usuario.Email == username && usuario.Senha == password)
                            {
                                logado = true;
                            }
                            else
                            {
                                Console.WriteLine("Senha ou email invalido");
                            }
                            Console.ReadKey();
                        }
                        break;
                    case '2': // CADASTRO
                        Console.Clear();
                        usuarios.Add(new Usuario(
                            GetCampo("CPF"),
                            GetCampo("Nome"),
                            GetCampo("Telefone"),
                            GetCampo("Email"),
                            GetCampo("Senha"),
                            GetCampo("Cidade"),
                            GetCampo("Estado"),
                            GetCampo("Rua"),
                            GetCampo("Bairro"),
                            GetCampo("Numero"),
                            GetCampo("Complemento")));
                        break;
                }
            }
        }
    }
}
