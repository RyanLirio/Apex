using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bancoAlimentosApi
{
    public class CadastroEmpresas
    {
        public string Email;
        public string Senha;

        public CadastroEmpresas(string email, string password)
        {
            Email = email;
            Senha = password;
        }

        public override string ToString()
        {
            return "Email: " + Email
            + "\nSenha: " + Senha.ToString();
        }

    }
}