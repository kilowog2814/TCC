using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class FormRelatorio_BLL
    {
        public DataTable gerarRelatorio_BLL()
        {
            FormRelatorio_DAL pf = new FormRelatorio_DAL();
            return pf.gerarRelatorioDal();
        }
    }
    
}
