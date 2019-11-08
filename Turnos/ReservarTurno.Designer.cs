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
            this.paneAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // reservarBtn
            // 
            this.reservarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reservarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(151)))));
            this.reservarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservarBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservarBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.reservarBtn.Location = new System.Drawing.Point(106, 3);
            this.reservarBtn.Name = "reservarBtn";
            this.reservarBtn.Size = new System.Drawing.Size(97, 30);
            this.reservarBtn.TabIndex = 0;
            this.reservarBtn.Text = "Reservar";
            this.reservarBtn.UseVisualStyleBackColor = false;
            this.reservarBtn.Click += new System.EventHandler(this.ReservarBtn_Click);
            // 
            // flPanelHoras
            // 
            this.flPanelHoras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flPanelHoras.Location = new System.Drawing.Point(105, 164);
            this.flPanelHoras.Name = "flPanelHoras";
            this.flPanelHoras.Size = new System.Drawing.Size(689, 141);
            this.flPanelHoras.TabIndex = 1;
            // 
            // backgroundWorkerHorasBtns
            // 
            this.backgroundWorkerHorasBtns.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerHorasBtns_DoWork);
            // 
            // principalLbl
            // 
            this.principalLbl.AutoEllipsis = true;
            this.principalLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.principalLbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.principalLbl.Location = new System.Drawing.Point(0, 0);
            this.principalLbl.Name = "principalLbl";
            this.principalLbl.Size = new System.Drawing.Size(882, 99);
            this.principalLbl.TabIndex = 2;
            this.principalLbl.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed sit amet consectetur" +
    " metus.";
            this.principalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(33)))), ((int)(((byte)(89)))));
            this.cancelarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.cancelarBtn.Location = new System.Drawing.Point(3, 3);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(97, 30);
            this.cancelarBtn.TabIndex = 0;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = false;
            this.cancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // paneAcciones
            // 
            this.paneAcciones.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.paneAcciones.AutoSize = true;
            this.paneAcciones.Controls.Add(this.cancelarBtn);
            this.paneAcciones.Controls.Add(this.reservarBtn);
            this.paneAcciones.Location = new System.Drawing.Point(329, 335);
            this.paneAcciones.Name = "paneAcciones";
            this.paneAcciones.Size = new System.Drawing.Size(206, 36);
            this.paneAcciones.TabIndex = 3;
            // 
            // backgroundWorkerReservar
            // 
            this.backgroundWorkerReservar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerReservar_DoWork);
            // 
            // ReservarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.paneAcciones);
            this.Controls.Add(this.principalLbl);
            this.Controls.Add(this.flPanelHoras);
            this.Name = "ReservarTurno";
            this.Size = new System.Drawing.Size(882, 453);
            this.Load += new System.EventHandler(this.ReservarTurno_Load);
            this.paneAcciones.ResumeLayout(false);
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
    }
}
