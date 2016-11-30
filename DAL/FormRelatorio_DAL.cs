using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FormRelatorio_DAL
    {
        private ClasseConexao xx;
        private DataSet ds;
        public DataTable gerarRelatorioDal()
        {
            xx = new ClasseConexao();
            ds = new DataSet();
            string sql = "Select tblFuncionario.idFuncionario, tblFuncionario.nomeFuncionario, COUNT(tblReserva.codReserva)AS Total FROM tblFuncionario INNER JOIN tblReserva ON tblFuncionario.idFuncionario = tblReserva.idFuncionario AND tblReserva.statusReserva LIKE 'V' GROUP BY tblFuncionario.idFuncionario, tblFuncionario.nomeFuncionario";
            ds = xx.executarSQL(sql);
            return ds.Tables[0];
        }
    }
}
