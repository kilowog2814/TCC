using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class FormConsulta_DAL
    {
        private ClasseConexao conexao;
        private DataSet data;
        //private FormCheck_out_DAL checkOut;


        public DataTable pesquisarServico(String codReserva)
        {
            try
            {
                conexao = new ClasseConexao();
                data = new DataSet();
                String sql = "Select codServico from tblReserva_Servico where codReserva = " + codReserva;
                data = conexao.executarSQL(sql);
                return data.Tables[0];
            }
            catch (Exception)
            {
                return null;
            }

        }

        

    }

