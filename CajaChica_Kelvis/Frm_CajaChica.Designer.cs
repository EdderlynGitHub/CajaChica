namespace CajaChica_Kelvis
{
    partial class Frm_CajaChica
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CajaChica));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Tsb_Editar = new System.Windows.Forms.ToolStripButton();
            this.Tsb_Agregar = new System.Windows.Forms.ToolStripButton();
            this.Tsb_Eliminar = new System.Windows.Forms.ToolStripButton();
            this.Tsb_Aceptar = new System.Windows.Forms.ToolStripButton();
            this.Tsb_Cancelar = new System.Windows.Forms.ToolStripButton();
            this.Dtp_Fecha_Envio = new System.Windows.Forms.DateTimePicker();
            this.Txt_TotalCaja = new System.Windows.Forms.TextBox();
            this.Txt_Monto = new System.Windows.Forms.TextBox();
            this.Txt_Nota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_NFactura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Dtp_FechaSis = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsb_Editar,
            this.Tsb_Agregar,
            this.Tsb_Eliminar,
            this.Tsb_Aceptar,
            this.Tsb_Cancelar});
            this.toolStrip1.Location = new System.Drawing.Point(9, 6);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(120, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Tsb_Editar
            // 
            this.Tsb_Editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsb_Editar.Enabled = false;
            this.Tsb_Editar.Image = global::CajaChica_Kelvis.Properties.Resources.Prorgrams;
            this.Tsb_Editar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Tsb_Editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsb_Editar.Name = "Tsb_Editar";
            this.Tsb_Editar.Size = new System.Drawing.Size(36, 36);
            this.Tsb_Editar.Text = "Editar";
            this.Tsb_Editar.Visible = false;
            this.Tsb_Editar.Click += new System.EventHandler(this.Tsb_Editar_Click);
            // 
            // Tsb_Agregar
            // 
            this.Tsb_Agregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsb_Agregar.Image = global::CajaChica_Kelvis.Properties.Resources.icono_formulario1;
            this.Tsb_Agregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Tsb_Agregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsb_Agregar.Name = "Tsb_Agregar";
            this.Tsb_Agregar.Size = new System.Drawing.Size(36, 36);
            this.Tsb_Agregar.Text = "Agregar";
            this.Tsb_Agregar.Click += new System.EventHandler(this.Tsb_Agregar_Click);
            // 
            // Tsb_Eliminar
            // 
            this.Tsb_Eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsb_Eliminar.Enabled = false;
            this.Tsb_Eliminar.Image = global::CajaChica_Kelvis.Properties.Resources.cambio_de_cepillo_de_escoba_de_barrer_claro_icono_5768_96;
            this.Tsb_Eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Tsb_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsb_Eliminar.Name = "Tsb_Eliminar";
            this.Tsb_Eliminar.Size = new System.Drawing.Size(36, 36);
            this.Tsb_Eliminar.Text = "Eliminar";
            this.Tsb_Eliminar.Visible = false;
            this.Tsb_Eliminar.Click += new System.EventHandler(this.Tsb_Eliminar_Click);
            // 
            // Tsb_Aceptar
            // 
            this.Tsb_Aceptar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsb_Aceptar.Enabled = false;
            this.Tsb_Aceptar.Image = global::CajaChica_Kelvis.Properties.Resources.floppy_2;
            this.Tsb_Aceptar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Tsb_Aceptar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsb_Aceptar.Name = "Tsb_Aceptar";
            this.Tsb_Aceptar.Size = new System.Drawing.Size(36, 36);
            this.Tsb_Aceptar.Text = "Aceptar";
            this.Tsb_Aceptar.Click += new System.EventHandler(this.Tsb_Aceptar_Click);
            // 
            // Tsb_Cancelar
            // 
            this.Tsb_Cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsb_Cancelar.Image = global::CajaChica_Kelvis.Properties.Resources.imageres_1027;
            this.Tsb_Cancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Tsb_Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsb_Cancelar.Name = "Tsb_Cancelar";
            this.Tsb_Cancelar.Size = new System.Drawing.Size(36, 36);
            this.Tsb_Cancelar.Text = "Cancelar";
            this.Tsb_Cancelar.Click += new System.EventHandler(this.Tsb_Cancelar_Click);
            // 
            // Dtp_Fecha_Envio
            // 
            this.Dtp_Fecha_Envio.Enabled = false;
            this.Dtp_Fecha_Envio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Fecha_Envio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Fecha_Envio.Location = new System.Drawing.Point(377, 74);
            this.Dtp_Fecha_Envio.Name = "Dtp_Fecha_Envio";
            this.Dtp_Fecha_Envio.Size = new System.Drawing.Size(134, 31);
            this.Dtp_Fecha_Envio.TabIndex = 3;
            // 
            // Txt_TotalCaja
            // 
            this.Txt_TotalCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Txt_TotalCaja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_TotalCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TotalCaja.Location = new System.Drawing.Point(552, 229);
            this.Txt_TotalCaja.Name = "Txt_TotalCaja";
            this.Txt_TotalCaja.ReadOnly = true;
            this.Txt_TotalCaja.Size = new System.Drawing.Size(146, 24);
            this.Txt_TotalCaja.TabIndex = 4;
            // 
            // Txt_Monto
            // 
            this.Txt_Monto.Enabled = false;
            this.Txt_Monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Monto.Location = new System.Drawing.Point(90, 76);
            this.Txt_Monto.Name = "Txt_Monto";
            this.Txt_Monto.Size = new System.Drawing.Size(161, 31);
            this.Txt_Monto.TabIndex = 0;
            // 
            // Txt_Nota
            // 
            this.Txt_Nota.Enabled = false;
            this.Txt_Nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nota.Location = new System.Drawing.Point(90, 121);
            this.Txt_Nota.Multiline = true;
            this.Txt_Nota.Name = "Txt_Nota";
            this.Txt_Nota.Size = new System.Drawing.Size(608, 57);
            this.Txt_Nota.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Monto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(445, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total caja";
            // 
            // Txt_NFactura
            // 
            this.Txt_NFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Txt_NFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_NFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NFactura.Location = new System.Drawing.Point(609, 6);
            this.Txt_NFactura.Name = "Txt_NFactura";
            this.Txt_NFactura.ReadOnly = true;
            this.Txt_NFactura.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_NFactura.Size = new System.Drawing.Size(89, 19);
            this.Txt_NFactura.TabIndex = 8;
            this.Txt_NFactura.TextChanged += new System.EventHandler(this.Txt_NFactura_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(507, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "# Documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(299, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha";
            // 
            // Dtp_FechaSis
            // 
            this.Dtp_FechaSis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_FechaSis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_FechaSis.Location = new System.Drawing.Point(552, 73);
            this.Dtp_FechaSis.Name = "Dtp_FechaSis";
            this.Dtp_FechaSis.Size = new System.Drawing.Size(134, 31);
            this.Dtp_FechaSis.TabIndex = 11;
            this.Dtp_FechaSis.Visible = false;
            // 
            // Frm_CajaChica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 269);
            this.Controls.Add(this.Dtp_FechaSis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_NFactura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Nota);
            this.Controls.Add(this.Txt_Monto);
            this.Controls.Add(this.Txt_TotalCaja);
            this.Controls.Add(this.Dtp_Fecha_Envio);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(726, 308);
            this.MinimumSize = new System.Drawing.Size(726, 308);
            this.Name = "Frm_CajaChica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caja Chica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_CajaChica_FormClosing);
            this.Load += new System.EventHandler(this.Frm_CajaChica_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton Tsb_Editar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Tsb_Agregar;
        private System.Windows.Forms.ToolStripButton Tsb_Eliminar;
        private System.Windows.Forms.ToolStripButton Tsb_Aceptar;
        private System.Windows.Forms.ToolStripButton Tsb_Cancelar;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Envio;
        private System.Windows.Forms.TextBox Txt_TotalCaja;
        private System.Windows.Forms.TextBox Txt_Monto;
        private System.Windows.Forms.TextBox Txt_Nota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_NFactura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker Dtp_FechaSis;
    }
}

