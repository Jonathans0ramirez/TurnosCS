namespace Turnos
{
    partial class ValidarTurno
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
            this.panelValidar_2 = new System.Windows.Forms.Panel();
            this.labelTurnos = new System.Windows.Forms.Label();
            this.panelContrasena = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.validarBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelValidar = new System.Windows.Forms.Panel();
            this.backgroundWorkerValidar = new System.ComponentModel.BackgroundWorker();
            this.panelValidar_2.SuspendLayout();
            this.panelContrasena.SuspendLayout();
            this.panelUsuario.SuspendLayout();
            this.panelValidar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelValidar_2
            // 
            this.panelValidar_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelValidar_2.BackColor = System.Drawing.Color.White;
            this.panelValidar_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelValidar_2.Controls.Add(this.labelTurnos);
            this.panelValidar_2.Controls.Add(this.panelContrasena);
            this.panelValidar_2.Controls.Add(this.panelUsuario);
            this.panelValidar_2.Controls.Add(this.validarBtn);
            this.panelValidar_2.Controls.Add(this.label2);
            this.panelValidar_2.Controls.Add(this.label1);
            this.panelValidar_2.Location = new System.Drawing.Point(157, 76);
            this.panelValidar_2.Name = "panelValidar_2";
            this.panelValidar_2.Size = new System.Drawing.Size(395, 314);
            this.panelValidar_2.TabIndex = 35;
            // 
            // labelTurnos
            // 
            this.labelTurnos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTurnos.AutoSize = true;
            this.labelTurnos.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTurnos.Location = new System.Drawing.Point(80, 27);
            this.labelTurnos.Name = "labelTurnos";
            this.labelTurnos.Size = new System.Drawing.Size(230, 86);
            this.labelTurnos.TabIndex = 43;
            this.labelTurnos.Text = "Turnos";
            // 
            // panelContrasena
            // 
            this.panelContrasena.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContrasena.Controls.Add(this.flowLayoutPanel2);
            this.panelContrasena.Controls.Add(this.textBoxPass);
            this.panelContrasena.Location = new System.Drawing.Point(35, 194);
            this.panelContrasena.Name = "panelContrasena";
            this.panelContrasena.Size = new System.Drawing.Size(333, 26);
            this.panelContrasena.TabIndex = 42;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(10, 24);
            this.flowLayoutPanel2.TabIndex = 45;
            // 
            // textBoxPass
            // 
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.Location = new System.Drawing.Point(12, 3);
            this.textBoxPass.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '•';
            this.textBoxPass.Size = new System.Drawing.Size(319, 19);
            this.textBoxPass.TabIndex = 41;
            // 
            // panelUsuario
            // 
            this.panelUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUsuario.Controls.Add(this.flowLayoutPanel1);
            this.panelUsuario.Controls.Add(this.textBoxUser);
            this.panelUsuario.Location = new System.Drawing.Point(35, 135);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(333, 26);
            this.panelUsuario.TabIndex = 41;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(10, 24);
            this.flowLayoutPanel1.TabIndex = 44;
            // 
            // textBoxUser
            // 
            this.textBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.Location = new System.Drawing.Point(12, 3);
            this.textBoxUser.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(319, 19);
            this.textBoxUser.TabIndex = 41;
            // 
            // validarBtn
            // 
            this.validarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.validarBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.validarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.validarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validarBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validarBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.validarBtn.Location = new System.Drawing.Point(134, 242);
            this.validarBtn.Margin = new System.Windows.Forms.Padding(0);
            this.validarBtn.Name = "validarBtn";
            this.validarBtn.Size = new System.Drawing.Size(127, 33);
            this.validarBtn.TabIndex = 36;
            this.validarBtn.Text = "Validar";
            this.validarBtn.UseVisualStyleBackColor = false;
            this.validarBtn.Click += new System.EventHandler(this.ValidarBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Usuario";
            // 
            // panelValidar
            // 
            this.panelValidar.Controls.Add(this.panelValidar_2);
            this.panelValidar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelValidar.Location = new System.Drawing.Point(0, 0);
            this.panelValidar.Name = "panelValidar";
            this.panelValidar.Size = new System.Drawing.Size(721, 501);
            this.panelValidar.TabIndex = 36;
            // 
            // ValidarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelValidar);
            this.Name = "ValidarTurno";
            this.Size = new System.Drawing.Size(721, 501);
            this.panelValidar_2.ResumeLayout(false);
            this.panelValidar_2.PerformLayout();
            this.panelContrasena.ResumeLayout(false);
            this.panelContrasena.PerformLayout();
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            this.panelValidar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelValidar_2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button validarBtn;
        private System.Windows.Forms.Panel panelContrasena;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Panel panelValidar;
        private System.Windows.Forms.Label labelTurnos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.ComponentModel.BackgroundWorker backgroundWorkerValidar;
    }
}
