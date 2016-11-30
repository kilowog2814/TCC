using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class FormLogin_BLL
    {
        private FormLogin_DAL dal;
        private static DataTable tabela;
        private static string nivelFuncionario;
        private static string nomeFuncionario;
        private static string codFunc;

       
        public String getNivelFuncionario()
        {
            return nivelFuncionario;
        }

        public String getNomeFuncionario()
        {
            return nomeFuncionario;
        }
        public String getCodFuncionario()
        {
            return codFunc;
        }

        public bool loginBLL(string login, string senha)
        {
            dal = new FormLogin_DAL();
            try
            {
                tabela = dal.login(login, senha);
                nivelFuncionario = tabela.Rows[0]["codNivel"].ToString();
                nomeFuncionario = tabela.Rows[0]["nomeFuncionario"].ToString();
                codFunc = tabela.Rows[0]["idFuncionario"].ToString();
                String status = tabela.Rows[0]["statusFuncionario"].ToString();
                if (status.Equals("Demitido"))
                    return false;
                else
                    return true;
            }
            catch (Exception)
            {
                return false;
            }
        }




    }
}
