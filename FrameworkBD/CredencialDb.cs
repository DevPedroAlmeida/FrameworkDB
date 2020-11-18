using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameworkBD.FrameworkBD
{
    class CredencialDb
    {
        // Informação do projeto 
        public const string NomeProjeto = "";

        // Informação do Banco De Dado (Sql Server) 
        public static string DadosConexao()
        {

            try
            {
                const string Server = "";
                const string NomeDB = "";
                const string Login = "";
                const string Senha = "";

                if (Server == "" || NomeDB == "" || Login == "" || Senha == "")
                {
                    MessageBox.Show("A Credencial não foi colocada!!", "Erro");

                }

                return "server=" + Server + ";User Id=" + Login + ";database=" + NomeDB + "; password=" + Senha;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro (" + e.Message + ")", "Erro");
                throw;
            }
        }

    }
}
