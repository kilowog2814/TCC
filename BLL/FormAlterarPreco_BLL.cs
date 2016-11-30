using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class FormAlterarPreco_BLL
    {
        private FormAlterarPreco_DAL dal;
        private DataTable tabela;
        private String descricao, preco, dataAtualizacao;


        public void pesquisarQuarto(String codigoPesquisa,String tipoDeAtualizacao) 
        {
            dal = new FormAlterarPreco_DAL();
            tabela = new DataTable();
            try
            {
                if (tipoDeAtualizacao.Equals("quarto"))
                {
                    tabela = dal.pesquisarQuarto(codigoPesquisa);
                    descricao = tabela.Rows[0]["descricao"].ToString();
                    preco = tabela.Rows[0]["preco"].ToString();
                    dataAtualizacao = tabela.Rows[0]["dataAlteracao"].ToString();
                }
                else if (tipoDeAtualizacao.Equals("servico")) 
                {
                    tabela = dal.pesquisarServico(codigoPesquisa);
                    descricao = tabela.Rows[0]["descricao"].ToString();
                    preco = tabela.Rows[0]["preco"].ToString();
                    dataAtualizacao = tabela.Rows[0]["dataAlteracao"].ToString();
                }

            }
            catch (Exception) 
            {
                
            }
        }

        public bool atualizarDadosQuarto(String novoPreco, String novaDescricao, String codigoQuarto) 
        {
            bool returno = false;
            dal = new FormAlterarPreco_DAL();
            if (dal.atualizarQuarto(novoPreco, novaDescricao, codigoQuarto))
            {
                returno = true;
                return returno;
            } else 
            {
                return returno;
            }
        }

        public bool atualizarServico(String novoPreco, String novaDescricao, String codigoQuarto)
        {
            bool returno = false;
            dal = new FormAlterarPreco_DAL();
            if (dal.atualizarServico(novoPreco, novaDescricao, codigoQuarto))
            {
                returno = true;
                return returno;
            }
            else
            {
                return returno;
            }
        }

        public String getDescricao()
        {
            return descricao;
        }

        public String getPreco()
        {
            return preco;
        }

        public String getDataAtualizacao()
        {
            return dataAtualizacao;
        }
    }

