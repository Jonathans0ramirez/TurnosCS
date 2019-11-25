namespace Turnos
{
    partial class ReservarTurno
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.reservarBtn = new System.Windows.Forms.Button();
            this.flPanelHoras = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorkerHorasBtns = new System.ComponentModel.BackgroundWorker();
            this.principalLbl = new System.Windows.Forms.Label();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.paneAcciones = new System.Windows.Forms.FlowLayoutPanel();
            this.backgroundWorkerReservar = new System.ComponentModel.BackgroundWorker();
            this.panelTitleElipse = new ns1.BunifuElipse(this.components);
            this.containerlPrincipal = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.descripcionLbl = new System.Windows.Forms.Label();
            this.containerHoras = new System.Windows.Forms.Panel();
            this.panelLoad = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReservationLoadCheckingImg = new System.Windows.Forms.PictureBox();
            this.panelLoadElipse = new ns1.BunifuElipse(this.components);
            this.paneAcciones.SuspendLayout();
            this.containerlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.containerHoras.SuspendLayout();
            this.panelLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationLoadCheckingImg)).BeginInit();
            this.SuspendLayout();
            // 
            // reservarBtn
            // 
            this.reservarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reservarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(179)))), ((int)(((byte)(22)))));
            this.reservarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservarBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservarBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reservarBtn.Location = new System.Drawing.Point(109, 3);
            this.reservarBtn.Name = "reservarBtn";
            this.reservarBtn.Size = new System.Drawing.Size(100, 33);
            this.reservarBtn.TabIndex = 0;
            this.reservarBtn.Text = "Reservar >";
            this.reservarBtn.UseVisualStyleBackColor = false;
            this.reservarBtn.Click += new System.EventHandler(this.ReservarBtn_Click);
            // 
            // flPanelHoras
            // 
            this.flPanelHoras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flPanelHoras.Location = new System.Drawing.Point(79, 14);
            this.flPanelHoras.Name = "flPanelHoras";
            this.flPanelHoras.Size = new System.Drawing.Size(726, 100);
            this.flPanelHoras.TabIndex = 1;
            // 
            // backgroundWorkerHorasBtns
            // 
            this.backgroundWorkerHorasBtns.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerHorasBtns_DoWork);
            // 
            // principalLbl
            // 
            this.principalLbl.AutoSize = true;
            this.principalLbl.BackColor = System.Drawing.Color.White;
            this.principalLbl.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.principalLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(106)))), ((int)(((byte)(57)))));
            this.principalLbl.Location = new System.Drawing.Point(242, 103);
            this.principalLbl.Name = "principalLbl";
            this.principalLbl.Size = new System.Drawing.Size(398, 56);
            this.principalLbl.TabIndex = 2;
            this.principalLbl.Text = "Nombre.Usuario";
            this.principalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(106)))), ((int)(((byte)(57)))));
            this.cancelarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.cancelarBtn.Location = new System.Drawing.Point(3, 3);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(100, 33);
            this.cancelarBtn.TabIndex = 0;
            this.cancelarBtn.Text = "< Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = false;
            this.cancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // paneAcciones
            // 
            this.paneAcciones.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.paneAcciones.AutoSize = true;
            this.paneAcciones.Controls.Add(this.cancelarBtn);
            this.paneAcciones.Controls.Add(this.reservarBtn);
            this.paneAcciones.Location = new System.Drawing.Point(335, 459);
            this.paneAcciones.Name = "paneAcciones";
            this.paneAcciones.Size = new System.Drawing.Size(212, 39);
            this.paneAcciones.TabIndex = 3;
            // 
            // backgroundWorkerReservar
            // 
            this.backgroundWorkerReservar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerReservar_DoWork);
            // 
            // panelTitleElipse
            // 
            this.panelTitleElipse.ElipseRadius = 15;
            this.panelTitleElipse.TargetControl = this.containerlPrincipal;
            // 
            // containerlPrincipal
            // 
            this.containerlPrincipal.BackColor = System.Drawing.Color.White;
            this.containerlPrincipal.Controls.Add(this.pictureBoxLogo);
            this.containerlPrincipal.Controls.Add(this.descripcionLbl);
            this.containerlPrincipal.Controls.Add(this.principalLbl);
            this.containerlPrincipal.Location = new System.Drawing.Point(31, 13);
            this.containerlPrincipal.Name = "containerlPrincipal";
            this.containerlPrincipal.Size = new System.Drawing.Size(820, 215);
            this.containerlPrincipal.TabIndex = 4;
            this.containerlPrincipal.Visible = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::Turnos.Properties.Resources.logo_udea;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Location = new System.Drawing.Point(252, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(346, 84);
            this.pictureBoxLogo.TabIndex = 51;
            this.pictureBoxLogo.TabStop = false;
            // 
            // descripcionLbl
            // 
            this.descripcionLbl.AutoSize = true;
            this.descripcionLbl.BackColor = System.Drawing.Color.White;
            this.descripcionLbl.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.descripcionLbl.Location = new System.Drawing.Point(182, 170);
            this.descripcionLbl.Name = "descripcionLbl";
            this.descripcionLbl.Size = new System.Drawing.Size(519, 27);
            this.descripcionLbl.TabIndex = 2;
            this.descripcionLbl.Text = "Reserva el turno de acuerdo a tu disponibilidad";
            this.descripcionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // containerHoras
            // 
            this.containerHoras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.containerHoras.Controls.Add(this.flPanelHoras);
            this.containerHoras.Location = new System.Drawing.Point(31, 286);
            this.containerHoras.Name = "containerHoras";
            this.containerHoras.Size = new System.Drawing.Size(820, 132);
            this.containerHoras.TabIndex = 5;
            // 
            // panelLoad
            // 
            this.panelLoad.BackColor = System.Drawing.Color.White;
            this.panelLoad.Controls.Add(this.label3);
            this.panelLoad.Controls.Add(this.label2);
            this.panelLoad.Controls.Add(this.ReservationLoadCheckingImg);
            this.panelLoad.Location = new System.Drawing.Point(258, 165);
            this.panelLoad.Name = "panelLoad";
            this.panelLoad.Size = new System.Drawing.Size(371, 265);
            this.panelLoad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(18, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 54);
            this.label3.TabIndex = 52;
            this.label3.Text = "Turnos está consultando la disponibilidad del equipo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(106)))), ((int)(((byte)(57)))));
            this.label2.Location = new System.Drawing.Point(91, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 41);
            this.label2.TabIndex = 52;
            this.label2.Text = "Cargando";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReservationLoadCheckingImg
            // 
            this.ReservationLoadCheckingImg.Image = global::Turnos.Properties.Resources.Interwind_1s_100px;
            this.ReservationLoadCheckingImg.Location = new System.Drawing.Point(130, 6);
            this.ReservationLoadCheckingImg.Name = "ReservationLoadCheckingImg";
            this.ReservationLoadCheckingImg.Size = new System.Drawing.Size(100, 100);
            this.ReservationLoadCheckingImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReservationLoadCheckingImg.TabIndex = 12;
            this.ReservationLoadCheckingImg.TabStop = false;
            // 
            // panelLoadElipse
            // 
            this.panelLoadElipse.ElipseRadius = 15;
            this.panelLoadElipse.TargetControl = this.panelLoad;
            // 
            // ReservarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.containerHoras);
            this.Controls.Add(this.paneAcciones);
            this.Controls.Add(this.containerlPrincipal);
            this.Controls.Add(this.panelLoad);
            this.Name = "ReservarTurno";
            this.Size = new System.Drawing.Size(881, 538);
            this.Load += new System.EventHandler(this.ReservarTurno_Load);
            this.paneAcciones.ResumeLayout(false);
            this.containerlPrincipal.ResumeLayout(false);
            this.containerlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.containerHoras.ResumeLayout(false);
            this.panelLoad.ResumeLayout(false);
            this.panelLoad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationLoadCheckingImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reservarBtn;
        private System.Windows.Forms.FlowLayoutPanel flPanelHoras;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerHorasBtns;
        private System.Windows.Forms.Label principalLbl;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.FlowLayoutPanel paneAcciones;
        private System.ComponentModel.BackgroundWorker backgroundWorkerReservar;
        private ns1.BunifuElipse panelTitleElipse;
        private System.Windows.Forms.Panel containerlPrincipal;
        private System.Windows.Forms.Label descripcionLbl;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel containerHoras;
        private System.Windows.Forms.Panel panelLoad;
        private System.Windows.Forms.PictureBox ReservationLoadCheckingImg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ns1.BunifuElipse panelLoadElipse;
    }
}
