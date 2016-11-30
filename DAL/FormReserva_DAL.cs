using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class FormReserva_DAL
    {
        private ClasseConexao conexao;
        private DataSet data;
        private String idCliente = null;

        public int cadatrarCliente(String valores)
        {
            try
            {
                conexao = new ClasseConexao();
                data = new DataSet();
                String[] dadosCliente = valores.Split(',');

                String aux = "'" + dadosCliente[0] + "', '" + dadosCliente[1] + "', '" + dadosCliente[2] + "', '" + dadosCliente[3] + "', '" + dadosCliente[4] + "', '" + dadosCliente[5] + "', '" + dadosCliente[6] + "', '" + dadosCliente[7] + "', '" + dadosCliente[8] + "', '" + dadosCliente[9] + "'";

                String cliente = "EXEC  usp_cadastrarCliente " + aux;
                if (conexao.executarSQL(cliente) != null)
                {
                    return 1;
                }
                return 0;
            }
            catch (Exception) 
            {
                return 0;    
            }

            
        }
        public int cadastrarReserva(String dados,String idFuncionarioDll)

        {
            try
            {
                
                String[] dadosReserva = dados.Split(',');

                String reserva = "EXEC usp_inserirReserva " + idFuncionarioDll + ", " + idCliente + "," + dadosReserva[0] + "," + dadosReserva[1] + ",'" + dadosReserva[2] + "','" + dadosReserva[3]+"'";
                conexao = new ClasseConexao();
                if (conexao.executarSQL(reserva) != null)
                {
                    return 1;
                }

                return 0;
            }
            catch (Exception) 
            {
                return 0;
            }
        }

        public int reservaServico(String servico) 
        {
            try
            {
                conexao = new ClasseConexao();
                data = new DataSet();

                data = conexao.executarSQL("Select MAX (codReserva) as codReserva  from tblReserva");
                String codReserva = data.Tables[0].Rows[0]["codReserva"].ToString();

                if (servico.Equals("cafe")) 
                {
                    conexao = new ClasseConexao();
                    conexao.executarSQL("EXEC usp_servicosDaReserva " + codReserva + ",100001");
                }
                if (servico.Equals("almoco"))
                {
                    conexao = new ClasseConexao();
                    conexao.executarSQL("EXEC usp_servicosDaReserva " + codReserva + ",100002");
                }
                if (servico.Equals("jantar"))
                {
                    conexao = new ClasseConexao();
                    conexao.executarSQL("EXEC usp_servicosDaReserva " + codReserva + ",100003");
                }
                if (servico.Equals("sauna"))
                {
                    conexao = new ClasseConexao();
                    conexao.executarSQL("EXEC usp_servicosDaReserva " + codReserva + ",100004");
                }
                if (servico.Equals("piscina"))
                {
                    conexao = new ClasseConexao();
                    conexao.executarSQL("EXEC usp_servicosDaReserva " + codReserva + ",100005");
                }
                if (servico.Equals("jogos"))
                {
                    conexao = new ClasseConexao();
                    conexao.executarSQL("EXEC usp_servicosDaReserva " + codReserva + ",100006");
                }

                return 1;
            }
            catch (Exception) 
            {
                return 0;
            }
        }

        public DataTable pesquisaQuarto(String pesqui) 
        {
            try
            {
                conexao = new ClasseConexao();
                data = new DataSet();
                String sql = "Select descricao from tblQuarto where codQuarto = '" + pesqui + "'";
                data = conexao.executarSQL(sql);
                return data.Tables[0];
            }
            catch (Exception) 
            {
                return null;
            }
        }


        public void codigoCliente() 
        {
            conexao = new ClasseConexao();
            data = new DataSet();
            string SQL = "Select MAX(codCliente) as codCliente from tblCliente";
            data = conexao.executarSQL(SQL);
            idCliente = data.Tables[0].Rows[0]["codCliente"].ToString();
        }
    }

}
