namespace Turnos
{
    partial class Principal_OLD
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal_OLD));
            this.LabelIngreseNombreYPass = new System.Windows.Forms.Label();
            this.BotonValidarUsuario = new System.Windows.Forms.Button();
            this.LabelContraseña = new System.Windows.Forms.Label();
            this.LabelUsuario = new System.Windows.Forms.Label();
            this.TextBoxPass = new System.Windows.Forms.TextBox();
            this.TextBoxUser = new System.Windows.Forms.TextBox();
            this.btnCloseSession = new System.Windows.Forms.Button();
            this.tbIntro = new System.Windows.Forms.RichTextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.TextBoxInfo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelIngreseNombreYPass
            // 
            this.LabelIngreseNombreYPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelIngreseNombreYPass.AutoSize = true;
            this.LabelIngreseNombreYPass.BackColor = System.Drawing.Color.White;
            this.LabelIngreseNombreYPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIngreseNombreYPass.Location = new System.Drawing.Point(244, 230);
            this.LabelIngreseNombreYPass.Name = "LabelIngreseNombreYPass";
            this.LabelIngreseNombreYPass.Size = new System.Drawing.Size(384, 20);
            this.LabelIngreseNombreYPass.TabIndex = 30;
            this.LabelIngreseNombreYPass.Text = "Ingrese su nombre de usuario y contraseña del portal";
            this.LabelIngreseNombreYPass.Visible = false;
            // 
            // BotonValidarUsuario
            // 
            this.BotonValidarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BotonValidarUsuario.Location = new System.Drawing.Point(625, 315);
            this.BotonValidarUsuario.Name = "BotonValidarUsuario";
            this.BotonValidarUsuario.Size = new System.Drawing.Size(170, 31);
            this.BotonValidarUsuario.TabIndex = 29;
            this.BotonValidarUsuario.Text = "Validar";
            this.BotonValidarUsuario.UseVisualStyleBackColor = true;
            this.BotonValidarUsuario.Visible = false;
            this.BotonValidarUsuario.Click += new System.EventHandler(this.BotonValidarUsuario_Click);
            // 
            // LabelContraseña
            // 
            this.LabelContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelContraseña.AutoSize = true;
            this.LabelContraseña.BackColor = System.Drawing.Color.White;
            this.LabelContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelContraseña.Location = new System.Drawing.Point(180, 315);
            this.LabelContraseña.Name = "LabelContraseña";
            this.LabelContraseña.Size = new System.Drawing.Size(96, 20);
            this.LabelContraseña.TabIndex = 28;
            this.LabelContraseña.Text = "Contraseña:";
            this.LabelContraseña.Visible = false;
            // 
            // LabelUsuario
            // 
            this.LabelUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelUsuario.AutoSize = true;
            this.LabelUsuario.BackColor = System.Drawing.Color.White;
            this.LabelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsuario.Location = new System.Drawing.Point(208, 279);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.Size = new System.Drawing.Size(68, 20);
            this.LabelUsuario.TabIndex = 27;
            this.LabelUsuario.Text = "Usuario:";
            this.LabelUsuario.Visible = false;
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPass.Location = new System.Drawing.Point(282, 315);
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.PasswordChar = '*';
            this.TextBoxPass.Size = new System.Drawing.Size(323, 31);
            this.TextBoxPass.TabIndex = 26;
            this.TextBoxPass.Visible = false;
            // 
            // TextBoxUser
            // 
            this.TextBoxUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUser.Location = new System.Drawing.Point(282, 275);
            this.TextBoxUser.Name = "TextBoxUser";
            this.TextBoxUser.Size = new System.Drawing.Size(323, 31);
            this.TextBoxUser.TabIndex = 25;
            this.TextBoxUser.Visible = false;
            // 
            // btnCloseSession
            // 
            this.btnCloseSession.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCloseSession.Location = new System.Drawing.Point(343, 275);
            this.btnCloseSession.Name = "btnCloseSession";
            this.btnCloseSession.Size = new System.Drawing.Size(170, 31);
            this.btnCloseSession.TabIndex = 24;
            this.btnCloseSession.Text = "Aceptar";
            this.btnCloseSession.UseVisualStyleBackColor = true;
            this.btnCloseSession.Visible = false;
            // 
            // tbIntro
            // 
            this.tbIntro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIntro.BackColor = System.Drawing.Color.White;
            this.tbIntro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIntro.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIntro.Location = new System.Drawing.Point(56, 119);
            this.tbIntro.Name = "tbIntro";
            this.tbIntro.ReadOnly = true;
            this.tbIntro.Size = new System.Drawing.Size(725, 98);
            this.tbIntro.TabIndex = 23;
            this.tbIntro.Text = resources.GetString("tbIntro.Text");
            // 
            // Label4
            // 
            this.Label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Blue;
            this.Label4.Location = new System.Drawing.Point(396, 437);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(201, 16);
            this.Label4.TabIndex = 22;
            this.Label4.Text = "http://tiresias.udea.edu.co/turnos";
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(236, 437);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(165, 16);
            this.Label3.TabIndex = 21;
            this.Label3.Text = "ingresando a la dirección: ";
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(37, 421);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(758, 16);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "Señor usuario, si NO tiene separado el turno, por favor dirijase al equipo de cóm" +
    "puto reservado para éste fin y separe su  turno";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBox1.Location = new System.Drawing.Point(23, 22);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(800, 500);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 19;
            this.PictureBox1.TabStop = false;
            // 
            // Timer1
            // 
            this.Timer1.Interval = 9000;
            // 
            // TextBoxInfo
            // 
            this.TextBoxInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxInfo.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxInfo.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxInfo.ForeColor = System.Drawing.Color.Maroon;
            this.TextBoxInfo.Location = new System.Drawing.Point(64, 355);
            this.TextBoxInfo.Name = "TextBoxInfo";
            this.TextBoxInfo.ReadOnly = true;
            this.TextBoxInfo.Size = new System.Drawing.Size(738, 52);
            this.TextBoxInfo.TabIndex = 31;
            this.TextBoxInfo.Text = "";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 545);
            this.Controls.Add(this.LabelIngreseNombreYPass);
            this.Controls.Add(this.BotonValidarUsuario);
            this.Controls.Add(this.LabelContraseña);
            this.Controls.Add(this.LabelUsuario);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.TextBoxUser);
            this.Controls.Add(this.btnCloseSession);
            this.Controls.Add(this.tbIntro);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TextBoxInfo);
            this.Controls.Add(this.PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Turnos_Closing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label LabelIngreseNombreYPass;
        internal System.Windows.Forms.Button BotonValidarUsuario;
        internal System.Windows.Forms.Label LabelContraseña;
        internal System.Windows.Forms.Label LabelUsuario;
        internal System.Windows.Forms.TextBox TextBoxPass;
        internal System.Windows.Forms.TextBox TextBoxUser;
        internal System.Windows.Forms.Button btnCloseSession;
        internal System.Windows.Forms.RichTextBox tbIntro;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.RichTextBox TextBoxInfo;
    }
}

