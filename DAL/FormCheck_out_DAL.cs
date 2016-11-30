using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class FormCheck_out_DAL
{
    private ClasseConexao conexao;
    private DataSet data;

    public DataTable pesquisarCliente(String codReserva)
    {
        try
        {
            conexao = new ClasseConexao();
            data = new DataSet();
            String sql = "Select * from tblCliente where codCliente in (Select codCliente from tblReserva where codReserva =" + codReserva + ")";
            data = conexao.executarSQL(sql);
            return data.Tables[0];
        }
        catch (Exception)
        {
            return null;
        }
    }

    public DataTable pesquisarQuarto(String codReserva)
    {
        try
        {
            conexao = new ClasseConexao();
            data = new DataSet();
            String sql = "Select preco,numeroQuarto from tblQuarto where codQuarto in (Select codQuarto from tblReserva where codReserva = " + codReserva + ")";
            data = conexao.executarSQL(sql);
            return data.Tables[0];
        }
        catch (Exception)
        {
            return null;
        }
    }

    public DataTable pesquisarReserva(String codReserva)
    {
        try
        {
            conexao = new ClasseConexao();
            data = new DataSet();
            String sql = "Select  codQuarto, dataEntrada, dataSaida, qtdeHospede, statusReserva from tblReserva where codReserva = " + codReserva;
            data = conexao.executarSQL(sql);
            return data.Tables[0];
        }
        catch (Exception)
        {
            return null;
        }
    }

    public DataTable pesquisarServico(String codReserva)
    {
        try
        {
            conexao = new ClasseConexao();
            data = new DataSet();
            String sql = "Select * from tblReserva_Servico where codReserva = " + codReserva;
            data = conexao.executarSQL(sql);
            return data.Tables[0];
        }
        catch (Exception)
        {
            return null;
        }

    }
    public DataTable calcularTotalEstadia(String codReserva)
    {
        try
        {
            conexao = new ClasseConexao();
            data = new DataSet();
            String sql = "EXEC usp_somaEstadia " + codReserva;
            data = conexao.executarSQL(sql);
            return data.Tables[1];
        }
        catch (Exception)
        {
            return null;
        }

    }

    public DataTable totalServicos(String codReserva)
    {
        try
        {
            conexao = new ClasseConexao();
            data = new DataSet();
            String sql = "EXEC usp_somaEstadia " + codReserva;
            data = conexao.executarSQL(sql);
            return data.Tables[0];
        }
        catch (Exception)
        {
            return null;
        }
    }

    public int finalizarReserva(String codReserva)
    {
        try
        {
            conexao = new ClasseConexao();
            data = new DataSet();
            String sql = "UPDATE tblReserva SET statusReserva = 'E' WHERE codReserva =" + codReserva;
            return conexao.executarSQL_NoQuery(sql);
            
        }
        catch (Exception)
        {
            return 0;
        }
    }





}
