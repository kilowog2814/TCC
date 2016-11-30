using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class FormConsulta_BLL
{
    private FormConsulta_DAL dal;
    private DataTable tabela;
    private String todosServicos = null;
    private FormCheck_out_DAL checkOut;

    public String pesquisarServico(String codReserva)
    {
        dal = new FormConsulta_DAL();
        tabela = new DataTable();
        tabela = dal.pesquisarServico(codReserva);
        for (int i = 1; i < tabela.Rows.Count ; i++)
        {
            if (tabela.Rows[i]["codServico"].ToString().Equals("100001"))
            {
                todosServicos += "cafe,";
            }
            if (tabela.Rows[i]["codServico"].ToString().Equals("100002"))
            {
                todosServicos += "almoco,";
            }
            if (tabela.Rows[i]["codServico"].ToString().Equals("100003"))
            {
                todosServicos += "jantar,";

            }
            if (tabela.Rows[i]["codServico"].ToString().Equals("100004"))
            {
                todosServicos += "piscina,";
            }
            if (tabela.Rows[i]["codServico"].ToString().Equals("100005"))
            {
                todosServicos += "sauna,";
            }
            
            if (tabela.Rows[i]["codServico"].ToString().Equals("100006"))
            {
                todosServicos += "jogos,";
            }
            
        }
        return todosServicos;
    }

    public String calcularServico(String codReserva)
    {
        dal = new FormConsulta_DAL();
        tabela = new DataTable();
        checkOut = new FormCheck_out_DAL();
        tabela = checkOut.totalServicos(codReserva);
        return tabela.Rows[0]["valorServico"].ToString();

    }
}

