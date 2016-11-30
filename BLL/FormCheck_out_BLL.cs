using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class FormCheck_out_BLL
{
    private FormCheck_out_DAL dal;
    private DataTable dadosReserva;
    private static String codReserva;
    private String nomeCliente, cpfCliente, codQuarto, dataEntrada, quantidade, precoDiaria, rgCliente,telefoneCliente, emailCliente,statusReserva;
    private String totalServico;

    public void pesquisarCliente(String codReserva)
    {
        dal = new FormCheck_out_DAL();
        dadosReserva = new DataTable();
        dadosReserva = dal.pesquisarCliente(codReserva);
        nomeCliente = dadosReserva.Rows[0]["nomeCliente"].ToString();
        cpfCliente = dadosReserva.Rows[0]["cpfCliente"].ToString();
        rgCliente = dadosReserva.Rows[0]["rgCliente"].ToString();
        emailCliente = dadosReserva.Rows[0]["emailCliente"].ToString();
        telefoneCliente = dadosReserva.Rows[0]["telefoneCliente"].ToString();

    }

    public void pesquisarReserva(String codReserva)
    {
        dal = new FormCheck_out_DAL();
        dadosReserva = new DataTable();
        dadosReserva = dal.pesquisarReserva(codReserva);
        codQuarto = dadosReserva.Rows[0]["codQuarto"].ToString();
        dataEntrada = dadosReserva.Rows[0]["dataEntrada"].ToString();
        quantidade = dadosReserva.Rows[0]["qtdeHospede"].ToString();
        statusReserva = dadosReserva.Rows[0]["statusReserva"].ToString();
    }

    public double pesquisarQuarto(String codReserva)
    {
        dal = new FormCheck_out_DAL();
        dadosReserva = new DataTable();
        dadosReserva = dal.pesquisarQuarto(codReserva);
        double preco = double.Parse(dadosReserva.Rows[0]["preco"].ToString());
        return preco;
    }

    public void calcularServico(String codReserva)
    {
        try
        {
            dal = new FormCheck_out_DAL();
            dadosReserva = new DataTable();
            dadosReserva = dal.totalServicos(codReserva);
            totalServico = dadosReserva.Rows[0]["valorServicos"].ToString();

        }
        catch (Exception)
        {

        }
    }

    public String calcularTotalEstadia(String codReserva)
    {
        try
        {
            dal = new FormCheck_out_DAL();
            dadosReserva = new DataTable();
            dadosReserva = dal.calcularTotalEstadia(codReserva);
            String totalConsumo = dadosReserva.Rows[0]["valorTotal"].ToString();
            return totalConsumo;
        }
        catch (Exception)
        {
            return null;
        }

    }
    public bool finalizarReserva(string codReserva) 
    {
        dal = new FormCheck_out_DAL();
        if (dal.finalizarReserva(codReserva) == 1)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }


    public void setCodReserva(string vl)
    {
        codReserva = vl;
    }

    public String getCodReserva()
    {
        return codReserva;
    }

    public String getNomeCliente()
    {
        return nomeCliente;
    }

    public String getCPFCliente()
    {
        return cpfCliente;
    }

    public String getCodQuarto()
    {
        return codQuarto;
    }

    public String getQuantidade()
    {
        return quantidade;
    }

    public String getDataEntrada()
    {
        return dataEntrada;
    }

    public String getTotalServico()
    {
        return totalServico;
    }

    public String getPrecoDiaria() 
    {
        return precoDiaria;
    }

    public String getTelefone() 
    {
        return telefoneCliente;
    }

    public String getRG() 
    {
        return rgCliente;
    }

    public String getEmail()
    {
        return emailCliente;
    }

    public String getStatus() 
    {
        return statusReserva;
    }
}
