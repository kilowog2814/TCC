using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class FormPrincipal_DAL
    {
        ClasseConexao conexao;
        DataSet data;

        public DataTable getCheckIn()
        {
            conexao = new ClasseConexao();
            String SQL = "EXEC usp_atualizarGridCheckIn";
            data = conexao.executarSQL(SQL);
            return data.Tables[0];
        }

        public DataTable getCheckOut()
        {
            conexao = new ClasseConexao();
            String SQL = "EXEC usp_atualizarGridCheckOut";
            data = conexao.executarSQL(SQL);
            return data.Tables[0];
        }

    }
}
