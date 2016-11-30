using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Microsoft.Reporting.WinForms;

namespace TCM
{
    public partial class FrmRelatorio : Form
    {
        public FrmRelatorio()
        {
            InitializeComponent();
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {

          FormRelatorio_BLL  bll = new FormRelatorio_BLL();
            ReportDataSource datasource = new ReportDataSource("DataSet1", bll.gerarRelatorio_BLL().DefaultView);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
        }
    }
}
