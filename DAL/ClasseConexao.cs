using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


class ClasseConexao
{

    SqlConnection conexao = new SqlConnection();

    public SqlConnection conectar()
    {
        try
        {
            String strConexao = "Password=etesp; Persist Security Info=True; User ID=aluno; Initial Catalog=HOTEL; Data Source=" + Environment.MachineName;
            conexao.ConnectionString = strConexao;
            conexao.Open();
            return conexao;
        }
        catch (Exception)
        {
            desconectar();
            return null;
        }
    }

    public void desconectar()
    {
        try
        {
            if ((conexao.State == ConnectionState.Open))
            {
                conexao.Close();
                conexao.Dispose();
                conexao = null;
            }
        }
        catch (Exception) { }
    }

    public DataSet executarSQL(String comando_sql)
    {
        try
        {
            conectar();
            SqlDataAdapter adaptador = new SqlDataAdapter(comando_sql, conexao);
            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            return ds;
        }
        catch (Exception)
        {
            return null;
        }
        finally
        {
            desconectar();
        }
    }
    public int executarSQL_NoQuery(String comando_sql)
    {
        int retorno = 0;
        try
        {
            
            conectar();
            SqlCommand cmd = new SqlCommand(comando_sql, conexao);
            return retorno = (int)cmd.ExecuteNonQuery();

        }
        catch (Exception) 
        {
            
        }
        return retorno;
    }
    
    public DataSet executarSQLInjection(String comando_sql)
    {
        try
        {

            SqlDataAdapter adaptador = new SqlDataAdapter();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(comando_sql, conectar());
            cmd.CommandType = CommandType.Text;
            adaptador.SelectCommand = cmd;
            adaptador.Fill(ds);
            return ds;

        }
        catch (Exception)
        {
            return null;
        }
        finally
        {
            desconectar();
        }
    }



}
