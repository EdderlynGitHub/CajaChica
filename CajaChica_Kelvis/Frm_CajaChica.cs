using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace CajaChica_Kelvis
{
    public partial class Frm_CajaChica : Form
    {

        DataSet dsq;
        int f = 0;
        int NFactura;
        ErrorProvider error;
        // Patrón Singlenton

        private static Frm_CajaChica frmInstance = null;

        public static Frm_CajaChica Instance()
        {
            if (((frmInstance == null)
                        || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new Frm_CajaChica();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }
        public Frm_CajaChica()
        {
            InitializeComponent();
            error = new ErrorProvider();
        }
        // Validar Datos
        public bool validar()
        {
            bool valor = false;

            if (!string.IsNullOrWhiteSpace(Txt_Monto.Text))
            {
                valor = true;
            }
            return valor;
        }

        private void Tsb_Editar_Click(object sender, EventArgs e)
        {

        }
        //agregar registro
        private void Tsb_Agregar_Click(object sender, EventArgs e)
        {
            //Variables V = new Variables();
            Tsb_Aceptar.Enabled = true;
            Tsb_Cancelar.Enabled = true;
            Tsb_Editar.Enabled = true;
            Txt_Monto.Enabled = true;
            Txt_Nota.Enabled = true;
            Dtp_Fecha_Envio.Enabled = true;

            //V.NumeroDoc= buscarNumeroDocumento();
            Txt_NFactura.Text = Convert.ToString(buscarNumeroDocumento());
        }

        private void Tsb_Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void Tsb_Aceptar_Click(object sender, EventArgs e)
        {
           // ND = buscarNumeroDocumento();
            
            if (validar())

            {

             //  f = Convert.ToInt32(dsq.Tables["NDocu"].Rows[0][0]);

                    Variables N = new Variables();
                    SQL I = new SQL();


                    N.Nota = Txt_Nota.Text;
                //N.NumeroDoc = Convert.ToInt32(Txt_NFactura.Text);
                    N.NumeroDoc = buscarNumeroDocumento();
                    N.Monto = float.Parse(Txt_Monto.Text);
                    N.Estado = "Y";
                    N.FechaIngreso = DateTime.Parse(Dtp_Fecha_Envio.Value.ToString());
                    N.FechaSistema = DateTime.Parse(Dtp_FechaSis.Value.ToString());
                    N.NombrePC = NombrePC();

                    I.InsertarCH(N);


                    //dgvUsuarios.Update();
                    // LlenarGrid();
                    MessageBox.Show("Registro agregado con exito.", "Agregado", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    Limpiar(Txt_Monto,Txt_Nota);
               // Application.Restart();

                }
                else
                {
                    MessageBox.Show("Hay campos que son obligatorios que se encuentran vacios.", "Error de validación", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                Txt_NFactura.Text = Convert.ToString(buscarNumeroDocumentoAntes());

            }


            Frm_ReporteCaja RC = new Frm_ReporteCaja();
            RC.ShowDialog();


            Tsb_Aceptar.Enabled = false;
            Tsb_Cancelar.Enabled = false;
            Tsb_Editar.Enabled = false;
            Txt_Monto.Enabled = false;
            Txt_Nota.Enabled = false;
            Dtp_Fecha_Envio.Enabled = false;

            Variables V = new Variables();
            SQL B = new SQL();

            V.NombrePC = NombrePC();
            B.BuscarTotalCaja(V);


            dsq = B.BuscarTotalCaja(V);

            if (Convert.ToBoolean(dsq.Tables["TOTALCAJA"].Rows.Count > 0))
            {
                /* r = Convert.ToInt32(dsq.Tables["DatosPOS"].Rows[0]["pIdRegistro"]);
                 np = Convert.ToString(dsq.Tables["DatosPOS"].Rows[0]["Secuencia"]);
                 tp = Convert.ToString(dsq.Tables["DatosPOS"].Rows[0]["fkTipoNCF"]);*/


                Txt_TotalCaja.Text = Convert.ToString(dsq.Tables["TOTALCAJA"].Rows[0][0]);

            }


            }
         //Cancelar documento
        private void Tsb_Cancelar_Click(object sender, EventArgs e)
        {
            Tsb_Aceptar.Enabled = false;
            Tsb_Cancelar.Enabled = false;
            Tsb_Editar.Enabled = false;
            Txt_Monto.Enabled = false;
            Txt_Nota.Enabled = false;
            Dtp_Fecha_Envio.Enabled = false;
            Txt_NFactura.Text = Convert.ToString(buscarNumeroDocumentoAntes());
        }

        private void Txt_NFactura_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_CajaChica_Load(object sender, EventArgs e)
        {
            Refresh();
            //label6.Text = NombrePC();

            Txt_NFactura.Text = Convert.ToString(buscarNumeroDocumentoAntes());
            Variables V = new Variables();
            SQL B = new SQL();

            V.NombrePC = NombrePC();
            B.BuscarTotalCaja(V);


            dsq = B.BuscarTotalCaja(V);

            if (Convert.ToBoolean(dsq.Tables["TOTALCAJA"].Rows.Count > 0))
            {
                /* r = Convert.ToInt32(dsq.Tables["DatosPOS"].Rows[0]["pIdRegistro"]);
                 np = Convert.ToString(dsq.Tables["DatosPOS"].Rows[0]["Secuencia"]);
                 tp = Convert.ToString(dsq.Tables["DatosPOS"].Rows[0]["fkTipoNCF"]);*/


                Txt_TotalCaja.Text = Convert.ToString(dsq.Tables["TOTALCAJA"].Rows[0][0]);



            }

            }

        private void Frm_CajaChica_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public int buscarNumeroDocumento()
        {


            SQL C = new SQL();
            dsq = C.UltimoNFactura();

            if (Convert.ToBoolean(dsq.Tables["UltimoNFactura"].Rows.Count > 0))
            {
                NFactura = Convert.ToInt16(dsq.Tables["UltimoNFactura"].Rows[0]["NFactura"]) + 1;
            }
            else
            {
                NFactura = 1;
            }

            //Txt_NFactura.Text = Convert.ToString(NFactura);
            dsq.Tables["UltimoNFactura"].Clear();


            return NFactura;
        }

        public int buscarNumeroDocumentoAntes()
        {


            SQL C = new SQL();
            dsq = C.UltimoNFactura();

            if (Convert.ToBoolean(dsq.Tables["UltimoNFactura"].Rows.Count > 0))
            {
                NFactura = Convert.ToInt16(dsq.Tables["UltimoNFactura"].Rows[0]["NFactura"]);
            }
            else
            {
                NFactura = 1;
            }

            //Txt_NFactura.Text = Convert.ToString(NFactura);
            dsq.Tables["UltimoNFactura"].Clear();


            return NFactura;
        }

        public void Limpiar(params TextBox[] text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                text[i].Clear();

            }

        }

        public string NombrePC()

        { string nombre = Environment.MachineName; return nombre; }

    }
}
