using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class FormPrincipal_BLL
    {
        FormPrincipal_DAL principal;

        public DataTable getCheckIn()
        {
            principal = new FormPrincipal_DAL();
            return principal.getCheckIn();
        }
        public DataTable getCheckOut()
        {
            principal = new FormPrincipal_DAL();
            return principal.getCheckOut();
        }
    }
}
