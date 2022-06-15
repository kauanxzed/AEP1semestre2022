using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aep.Profiles
{
    public class Usuario
    {
        public string CPF { get; private set; }
        public string Nome { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public Endereco Endereco { get; private set; }
        public bool IsAdmin { get; }
        public string Senha { get; set; }



        public Usuario(string cpf, string nome, string telefone, string email, string senha, string cidade, 
            string estado, string rua, string bairro, string numero, string complemento, bool isAdmin=false)
        {
            CPF = cpf;
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Senha = senha;
            Endereco = new Endereco(cidade, estado, rua, bairro, numero, complemento);
            IsAdmin = isAdmin;
        }
    }
}
