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
            this.components = new System.ComponentModel.Container();
            this.panelValidar = new System.Windows.Forms.Panel();
            this.panelValidar_2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTurnos = new System.Windows.Forms.Label();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContrasena = new System.Windows.Forms.Panel();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.validarBtn = new System.Windows.Forms.Button();
            this.backgroundWorkerValidar = new System.ComponentModel.BackgroundWorker();
            this.elipsePanel = new ns1.BunifuElipse(this.components);
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.panelValidar.SuspendLayout();
            this.panelValidar_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelUsuario.SuspendLayout();
            this.panelContrasena.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelValidar
            // 
            this.panelValidar.Controls.Add(this.panelValidar_2);
            this.panelValidar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelValidar.Location = new System.Drawing.Point(0, 0);
            this.panelValidar.Name = "panelValidar";
            this.panelValidar.Size = new System.Drawing.Size(721, 594);
            this.panelValidar.TabIndex = 36;
            // 
            // panelValidar_2
            // 
            this.panelValidar_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelValidar_2.BackColor = System.Drawing.Color.White;
            this.panelValidar_2.Controls.Add(this.pictureBox1);
            this.panelValidar_2.Controls.Add(this.labelTurnos);
            this.panelValidar_2.Controls.Add(this.panelUsuario);
            this.panelValidar_2.Controls.Add(this.label1);
            this.panelValidar_2.Controls.Add(this.panelContrasena);
            this.panelValidar_2.Controls.Add(this.label2);
            this.panelValidar_2.Controls.Add(this.validarBtn);
            this.panelValidar_2.Location = new System.Drawing.Point(152, 63);
            this.panelValidar_2.Name = "panelValidar_2";
            this.panelValidar_2.Size = new System.Drawing.Size(413, 470);
            this.panelValidar_2.TabIndex = 50;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Turnos.Properties.Resources.logo_udea;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(36, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 84);
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // labelTurnos
            // 
            this.labelTurnos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTurnos.AutoSize = true;
            this.labelTurnos.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTurnos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(106)))), ((int)(((byte)(57)))));
            this.labelTurnos.Location = new System.Drawing.Point(119, 125);
            this.labelTurnos.Name = "labelTurnos";
            this.labelTurnos.Size = new System.Drawing.Size(183, 56);
            this.labelTurnos.TabIndex = 49;
            this.labelTurnos.Text = "Turnos";
            // 
            // panelUsuario
            // 
            this.panelUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUsuario.Controls.Add(this.textBoxUser);
            this.panelUsuario.ForeColor = System.Drawing.Color.Maroon;
            this.panelUsuario.Location = new System.Drawing.Point(60, 219);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(293, 33);
            this.panelUsuario.TabIndex = 47;
            // 
            // textBoxUser
            // 
            this.textBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.Location = new System.Drawing.Point(5, 6);
            this.textBoxUser.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.textBoxUser.MaxLength = 100;
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(281, 19);
            this.textBoxUser.TabIndex = 41;
            this.textBoxUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUser_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(57, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "*Usuario";
            // 
            // panelContrasena
            // 
            this.panelContrasena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContrasena.Controls.Add(this.textBoxPass);
            this.panelContrasena.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelContrasena.Location = new System.Drawing.Point(60, 297);
            this.panelContrasena.Name = "panelContrasena";
            this.panelContrasena.Size = new System.Drawing.Size(293, 33);
            this.panelContrasena.TabIndex = 48;
            // 
            // textBoxPass
            // 
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.Location = new System.Drawing.Point(5, 6);
            this.textBoxPass.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.textBoxPass.MaxLength = 20;
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '•';
            this.textBoxPass.Size = new System.Drawing.Size(281, 19);
            this.textBoxPass.TabIndex = 41;
            this.textBoxPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPass_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(57, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "*Contraseña";
            // 
            // validarBtn
            // 
            this.validarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.validarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(106)))), ((int)(((byte)(57)))));
            this.validarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.validarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validarBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validarBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.validarBtn.Location = new System.Drawing.Point(145, 380);
            this.validarBtn.Margin = new System.Windows.Forms.Padding(0);
            this.validarBtn.Name = "validarBtn";
            this.validarBtn.Size = new System.Drawing.Size(123, 33);
            this.validarBtn.TabIndex = 46;
            this.validarBtn.Text = "Validar  >";
            this.validarBtn.UseVisualStyleBackColor = false;
            this.validarBtn.Click += new System.EventHandler(this.ValidarBtn_Click);
            this.validarBtn.MouseEnter += new System.EventHandler(this.validarBtn_MouseEnter);
            this.validarBtn.MouseLeave += new System.EventHandler(this.validarBtn_MouseLeave);
            // 
            // backgroundWorkerValidar
            // 
            this.backgroundWorkerValidar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerValidar_DoWork);
            // 
            // elipsePanel
            // 
            this.elipsePanel.ElipseRadius = 15;
            this.elipsePanel.TargetControl = this.panelValidar_2;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ValidarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelValidar);
            this.Name = "ValidarTurno";
            this.Size = new System.Drawing.Size(721, 594);
            this.Load += new System.EventHandler(this.ValidarTurno_Load);
            this.panelValidar.ResumeLayout(false);
            this.panelValidar_2.ResumeLayout(false);
            this.panelValidar_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            this.panelContrasena.ResumeLayout(false);
            this.panelContrasena.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelValidar;
        private System.ComponentModel.BackgroundWorker backgroundWorkerValidar;
        private System.Windows.Forms.Label labelTurnos;
        private System.Windows.Forms.Panel panelContrasena;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Button validarBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelValidar_2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuElipse elipsePanel;
        private ns1.BunifuElipse bunifuElipse1;
    }
}
