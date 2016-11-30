using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FormGrafico_DAL
    {
         private ClasseConexao xx;
         private DataSet ds;

        public DataTable gerarGrafico_DAL() {

            xx = new ClasseConexao();
            ds = new DataSet();
            string sql = "SELECT q.descricao, COUNT(r.codReserva) As 'Numero de Reservas' FROM tblReserva r RIGHT JOIN tblQuarto q ON r.codQuarto = q.codQuarto AND MONTH(r.dataSaida) LIKE MONTH(GETDATE()) GROUP BY q.descricao";
            ds = xx.executarSQL(sql);
            return ds.Tables[0];
               
        }
    }
}
