using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class FormCheckIn_BLL
    {

        private FormCheckIn_DAL check;
        private static DataTable data;
        private static string codCli = null;
        private string nomeCliente, emailCliente, codQuarto, cepCliente, cpfCliente, dataEntrada, dataSaida, dataNascimento, telefone, quatidade,status;


        public String pesquisaBll(string codReserva)
        {
            check = new FormCheckIn_DAL();
            data = new DataTable();
            String todosServicos = null;
            try
            {
                data = check.pesquisarReserva(codReserva);

                codCli = data.Rows[0]["codCliente"].ToString();
                codReserva = data.Rows[0]["codReserva"].ToString();
                nomeCliente = data.Rows[0]["nomeCliente"].ToString();
                emailCliente =  data.Rows[0]["emailCliente"].ToString();
                codQuarto = data.Rows[0]["codQuarto"].ToString();
                cepCliente =  data.Rows[0]["cepCliente"].ToString();
                cpfCliente = data.Rows[0]["cpfCliente"].ToString();
                dataEntrada =  data.Rows[0]["dataEntrada"].ToString();
                dataNascimento = data.Rows[0]["dataNascimentoCliente"].ToString();
                dataSaida = data.Rows[0]["dataSaida"].ToString();
                telefone = data.Rows[0]["telefoneCliente"].ToString();
                quatidade =  data.Rows[0]["qtdeHospede"].ToString();
                status = data.Rows[0]["statusReserva"].ToString();

                for (int i = 0; i < data.Rows.Count; i++) 
                {
                    if (data.Rows[i]["codServico"].ToString().Equals("100001"))
                    {
                        todosServicos += "cafe,";
                    }

                    if (data.Rows[i]["codServico"].ToString().Equals("100002"))
                    {
                        todosServicos += "almoco,";
                    }

                    if (data.Rows[i]["codServico"].ToString().Equals("100003"))
                    {
                        todosServicos += "jantar,";
                    }

                    if (data.Rows[i]["codServico"].ToString().Equals("100004"))
                    {
                        todosServicos += "piscina,";
                    }

                    if (data.Rows[i]["codServico"].ToString().Equals("100005"))
                    {
                        todosServicos += "sauna,";
                    }

                    if (data.Rows[i]["codServico"].ToString().Equals("100006"))
                    {
                        todosServicos += "jogos,";
                    }
                }
                return todosServicos;


            }
            catch (Exception) 
            {
                return null;   
            }
        }

        public bool confirmarCheckIn(string codFunc, String codReserva)
        {
            check = new FormCheckIn_DAL();
            if (check.confirmarCheckIn(codFunc, codReserva) == 1)
                return true;
            else
                return false;
        }

        public bool confirmarAlterandoBLL(string val, string data, string servicos)
        {
            check = new FormCheckIn_DAL();

            val = val + codCli + ";";
            if (check.confirmarAlterandoDAL(val, data, servicos) == 1)
                return true;
            else
                return false;
        }

        public bool realizarNoShowBll(String codReserva)
        {
            check = new FormCheckIn_DAL();
            if (check.realizarNoShow(codReserva) == 1)
                return true;
            else
                return false;
        }

        public bool cancelarReservaBll(String codReserva)
        {
            check = new FormCheckIn_DAL();
            if (check.cancelarReserva(codReserva) == 1)
                return true;
            else
                return false;
        }

        public int pesquisarServicos() 
        {
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    if (int.Parse(dt.Rows[i]["codServico"].ToString()) == 100001)
            //    {
                    
            //    }
            //    if (int.Parse(dt.Rows[i]["codServico"].ToString()) == 100002)
            //    {
                    
            //    }
            //    if (int.Parse(dt.Rows[i]["codServico"].ToString()) == 100003)
            //    {
                    
            //    }
            //    if (int.Parse(dt.Rows[i]["codServico"].ToString()) == 100005)
            //    {
                    
            //    }
            //    if (int.Parse(dt.Rows[i]["codServico"].ToString()) == 100004)
            //    {
                    
            //    }
            //    if (int.Parse(dt.Rows[i]["codServico"].ToString()) == 100006)
            //    {
                    
            //    }
            //}
            return 0;
        }

        public String getNomeCliente() 
        {
            return nomeCliente;
        }

        public String getEmailCliente()
        {
            return emailCliente;
        }

        public String getCodQuarto()
        {
            return codQuarto;
        }

        public String getCepCliente()
        {
            return cepCliente;
        }

        public String getCpfCliente()
        {
            return cpfCliente;
        }

        public String getDataEntradaCliente()
        {
            return dataEntrada;
        }

        public String getDataSaidaCliente()
        {
            return dataSaida;
        }

        public String getDataNascimento()
        {
            return dataNascimento;
        }

        public String getTelefone()
        {
            return telefone;
        }

        public String getQuantidade()
        {
            return quatidade;
        }
        public String getStatus()   
        {
            return status;
        }
    }
}
