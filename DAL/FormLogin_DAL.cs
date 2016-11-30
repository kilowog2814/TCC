using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class FormLogin_DAL
    {
        ClasseConexao conexao;
        DataSet data;

        public DataTable login(string login, string senha)
        {
            try
            {
                conexao = new ClasseConexao();
                data = new DataSet();
                String SQL = " EXEC usp_loginFuncionario '"+login+"','"+senha+"'";
                data = conexao.executarSQL(SQL);
                
            }
            catch (Exception) 
            {
                return null;
            }
            return data.Tables[0];
        }
        

    }
}
