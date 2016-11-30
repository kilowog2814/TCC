using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class FormGrafico_BLL
    {
       
        private DataTable totalReserva;

        public DataTable getTotalReserva()
        {
            return totalReserva;
        }

        public void gerarGrafico_BLL()
        {

            FormGrafico_DAL pf = new FormGrafico_DAL();
            totalReserva = pf.gerarGrafico_DAL();
           
        }
    }
}
