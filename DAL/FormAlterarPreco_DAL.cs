using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class FormAlterarPreco_DAL
    {
        private ClasseConexao conexao;
        private DataSet data;

        public DataTable pesquisarQuarto(String idQuarto) 
        {
            try
            {
                conexao = new ClasseConexao();
                data = new DataSet();
                String sql = "Select * from tblQuarto where codQuarto = " + idQuarto;
                data = conexao.executarSQL(sql);
                return data.Tables[0];
            }
            catch (Exception) 
            {
                return null;
            }
        }

        public DataTable pesquisarServico(String codigoServico) 
        {
            try
            {
                conexao = new ClasseConexao();
                data = new DataSet();
                String sql = "Select * from tblServico where codServico = " + codigoServico + "";
                data = conexao.executarSQL(sql);
                return data.Tables[0];
            }
            catch (Exception) 
            {
                return null;
            }
        }

        public bool atualizarQuarto(String novoPreco, String NovaDescricao, String codigoQuarto) 
        {
            try
            {
                conexao = new ClasseConexao();
                String sql = "EXEC usp_alterarPrecoQuarto "+ codigoQuarto+",'"+NovaDescricao+"',"+novoPreco;
                conexao.executarSQL(sql);                
                return true;
            }
            catch (Exception) 
            {
                return false;
            }
        }

        public bool atualizarServico(String novoPreco, String novaDescricao, String codigoServico) 
        {
            try
            {
                conexao = new ClasseConexao();
                string sql = "EXEX usp_alterarPrecoServico " + codigoServico +"," + novoPreco + ",'" + novaDescricao + "'";
                conexao.executarSQL(sql);
                return true;
            }
            catch (Exception) 
            {
                return false;
            }
        }

    }

