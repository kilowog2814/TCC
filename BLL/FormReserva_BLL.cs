using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
  public   class FormReserva_BLL
    {
        private FormReserva_DAL reserva;
        private DataTable tabela;
        private FormLogin_BLL idFuncionario;
        

        public bool cadastrarCliente(String vl)
        {
            reserva = new FormReserva_DAL();

            if (reserva.cadatrarCliente(vl)  == 1)
            {
                return true;
            }

            return false;
        }

        public bool cadastrarReserva(String vl)
        {
            reserva = new FormReserva_DAL();
            idFuncionario = new FormLogin_BLL();
            reserva.codigoCliente();
            if (reserva.cadastrarReserva(vl, idFuncionario.getCodFuncionario()) == 1)
            {
                return true;
            }

            return false;
        }

        public int pesquisarQuarto(String quarto) 
        {
            reserva = new FormReserva_DAL();
            tabela = new DataTable();
           
            tabela = reserva.pesquisaQuarto(quarto);
            String diaria = tabela.Rows[0]["descricao"].ToString();

            if (diaria.Equals("Quarto Normal - Solteiro")) 
            {
                return 1;
            }

            if (diaria.Equals("Quarto Suite - Solteiro")) 
            {
                return 2;
            }

            if (diaria.Equals("Quarto Luxo - Solteiro")) 
            {
                return 3;
            }

            return 4;
        }

        public int reservarServico(String servico) 
        {
            try
            {
                if (servico.Equals(""))
                {
                    return 3;
                }
                reserva = new FormReserva_DAL();
                String[] temp = servico.Split(',');
                for (int i = 0; i <= temp.Length; i++)
                {
                    if (temp[i].Equals(""))
                    {
                        break;
                    }
                    else 
                    {
                        servico = temp[i];
                        reserva.reservaServico(servico);
                    }
                }
                return 1;
            }
            catch (Exception) 
            {
                return 0;
            }
            
        }
    }
}
