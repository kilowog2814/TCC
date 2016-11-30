using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BLL;
namespace TCM
{
    public partial class FrmGrafico : Form
    {
        FormGrafico_BLL bll = new FormGrafico_BLL();
        public FrmGrafico()
        {
            InitializeComponent();
        }

        private void FrmGrafico_Load(object sender, EventArgs e)
        {
            try
            {
                bll.gerarGrafico_BLL();
                grfQuarto.DataSource = bll.getTotalReserva().DefaultView;
                grfQuarto.Palette = ChartColorPalette.Excel;
                grfQuarto.Series["Series1"].ChartType = SeriesChartType.Column;
                grfQuarto.Titles.Add("Total de Reservas");
                grfQuarto.Series[0].XValueMember = "descricao";
                grfQuarto.Series[0].YValueMembers = "Numero de Reservas";
            }
            catch (Exception erro) 
            {
                MessageBox.Show(erro.Message);
            
            }

        }

    

       
    }
}
