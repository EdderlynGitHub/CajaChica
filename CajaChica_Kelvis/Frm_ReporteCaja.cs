using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CajaChica_Kelvis
{
    public partial class Frm_ReporteCaja : Form
    {
        #region "Variables (Clases) de conexión"
        private DataTable Dt;
        #endregion

        public Frm_ReporteCaja()
        {
            InitializeComponent();
        }

        private void Frm_ReporteCaja_Load(object sender, EventArgs e)
        {
            //Frm_CajaChica FC = new Frm_CajaChica();

           // Variables VR = new Variables();


            //VR.NumeroDoc = FC.buscarNumeroDocumento();
            SQL C = new SQL();

          //  C.BuscarCajaChica();

           Dt= C.BuscarCajaChica();


            DataSet1 Ds = new DataSet1();
            // DataTable Dt = new DataTable();
            Cr_Imp_Caja CRPV = new Cr_Imp_Caja();

            CRPV.SetDataSource(Dt);
            crystalReportViewer1.ReportSource = CRPV;
            crystalReportViewer1.Refresh();

           
        }
    }
}
