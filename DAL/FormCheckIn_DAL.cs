using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FormCheckIn_DAL
    {
        private ClasseConexao con;
        private DataSet ds;

        public DataTable pesquisarReserva(string codReserva)
        {
            try
            {
                con = new ClasseConexao();
                ds = new DataSet();
                ds = con.executarSQL("SELECT c.*, r.*, s.* FROM tblCliente c INNER JOIN tblReserva r ON c.codCliente = r.codCliente AND r.codReserva = " + codReserva + " LEFT JOIN tblReserva_Servico s ON r.codReserva = s.codReserva");
                return ds.Tables[0];
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int confirmarCheckIn(string codFunc, string codReser)
        {
            try
            {
                con = new ClasseConexao();
                con.executarSQL("exec usp_confirmarCheckIn "+codFunc +", "+ codReser);
                return 1;

            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int confirmarAlterandoDAL(string val, string data, string servicos)
        {
            con = new ClasseConexao();

            string[] info = val.Split(';');
            string[] lstServicos = servicos.Split(',');

            if (data.Equals(DateTime.Now.ToString().Split(' ')[0]))
            {
                
                con.executarSQL_NoQuery("UPDATE tblReserva SET idFuncionario = " + info[1] + ", codQuarto = " + info[2] + ", qtdeHospede = " + info[3] + ", dataEntrada = '" + info[4] + "', dataSaida = '" + info[5] + "', statusReserva = 's' WHERE codReserva = " + info[0]);
            }
            else
            {
                
                con.executarSQL_NoQuery("UPDATE tblReserva SET idFuncionario = " + info[1] + ", codQuarto = " + info[2] + ", qtdeHospede = " + info[3] + ", dataEntrada = '" + info[4] + "', dataSaida = '" + info[5] + " WHERE codReserva = " + info[0]);
            }

            con = new ClasseConexao();
            con.executarSQL("DELETE tblReserva_Servico WHERE codReserva = " + info[0]);

            for (int i = 0; i < lstServicos.Length; i++)
            {
                ///if (lstServicos[i].Length == 6)
                //{
                    con = new ClasseConexao();
                    con.executarSQL_NoQuery("INSERT INTO tblReserva_Servico VALUES(" + info[0] + ", " + lstServicos[i] + ")");
               // }
            }

            con = new ClasseConexao();
            return con.executarSQL_NoQuery("UPDATE tblCliente SET nomeCliente = '" + info[6] + "', cpfCliente = '" + info[7] + "', dataNascimentoCliente = '" + info[8] + "', cepCliente = '" + info[9] + "', emailCliente = '" + info[10] + "', telefoneCliente = '" + info[11] + "' WHERE codCliente = " + info[12]);
        }

        public int realizarNoShow(string codReserva)
        {
            con = new ClasseConexao();
            con.executarSQL_NoQuery("INSERT INTO tblNoShow values (" + codReserva + ", '" + DateTime.Now + "'");
            con = new ClasseConexao();
            return con.executarSQL_NoQuery("EXEC usp_realizarNoShow " + codReserva);
        }

        public int cancelarReserva(string codReserva)
        {
            con = new ClasseConexao();
            return con.executarSQL_NoQuery("EXEC usp_cancelarReserva " + codReserva);
        }

        public DataTable pesquisar_Servico(String codReserva) 
        {
            con = new ClasseConexao();
            ds = new DataSet();
            try
            {
                String sql = "SELECT * FROM tblReserva_Servico WHERE = codReserva =" + codReserva;
                ds = con.executarSQL(sql);
                return ds.Tables[0];
            }
            catch (Exception) 
            {
                return null;
            }
        
        }


    }
}
