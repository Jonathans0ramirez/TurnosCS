namespace Turnos
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.timerAnimation = new System.Windows.Forms.Timer(this.components);
            this.accionesPanel = new System.Windows.Forms.Panel();
            this.expandCollapseBtn = new ns1.BunifuFlatButton();
            this.menuBtn = new ns1.BunifuFlatButton();
            this.accionesPanel_2 = new System.Windows.Forms.Panel();
            this.verificarLbl = new ns1.BunifuCustomLabel();
            this.verificarBtnImg = new ns1.BunifuFlatButton();
            this.reservarLbl = new ns1.BunifuCustomLabel();
            this.reservarBtnImg = new ns1.BunifuFlatButton();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton1 = new ns1.BunifuFlatButton();
            this.expandCollapseTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.timerCollapse = new System.Windows.Forms.Timer(this.components);
            this.accionesPanel.SuspendLayout();
            this.accionesPanel_2.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerAnimation
            // 
            this.timerAnimation.Interval = 15;
            this.timerAnimation.Tick += new System.EventHandler(this.TimerAnimation_Tick);
            // 
            // accionesPanel
            // 
            this.accionesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(53)))), ((int)(((byte)(28)))));
            this.accionesPanel.Controls.Add(this.expandCollapseBtn);
            this.accionesPanel.Controls.Add(this.menuBtn);
            this.accionesPanel.Controls.Add(this.accionesPanel_2);
            this.accionesPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expandCollapseTransition.SetDecoration(this.accionesPanel, BunifuAnimatorNS.DecorationType.None);
            this.accionesPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.accionesPanel.Location = new System.Drawing.Point(0, 514);
            this.accionesPanel.Name = "accionesPanel";
            this.accionesPanel.Size = new System.Drawing.Size(920, 70);
            this.accionesPanel.TabIndex = 11;
            // 
            // expandCollapseBtn
            // 
            this.expandCollapseBtn.Activecolor = System.Drawing.Color.Transparent;
            this.expandCollapseBtn.BackColor = System.Drawing.Color.Transparent;
            this.expandCollapseBtn.BackgroundImage = global::Turnos.Properties.Resources.icons8_flecha_contraer_50;
            this.expandCollapseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.expandCollapseBtn.BorderRadius = 0;
            this.expandCollapseBtn.ButtonText = "";
            this.expandCollapseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expandCollapseTransition.SetDecoration(this.expandCollapseBtn, BunifuAnimatorNS.DecorationType.None);
            this.expandCollapseBtn.DisabledColor = System.Drawing.Color.Transparent;
            this.expandCollapseBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.expandCollapseBtn.Iconimage = null;
            this.expandCollapseBtn.Iconimage_right = null;
            this.expandCollapseBtn.Iconimage_right_Selected = null;
            this.expandCollapseBtn.Iconimage_Selected = null;
            this.expandCollapseBtn.IconMarginLeft = 0;
            this.expandCollapseBtn.IconMarginRight = 0;
            this.expandCollapseBtn.IconRightVisible = false;
            this.expandCollapseBtn.IconRightZoom = 0D;
            this.expandCollapseBtn.IconVisible = true;
            this.expandCollapseBtn.IconZoom = 90D;
            this.expandCollapseBtn.IsTab = false;
            this.expandCollapseBtn.Location = new System.Drawing.Point(12, 20);
            this.expandCollapseBtn.Name = "expandCollapseBtn";
            this.expandCollapseBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.expandCollapseBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.expandCollapseBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.expandCollapseBtn.selected = false;
            this.expandCollapseBtn.Size = new System.Drawing.Size(26, 30);
            this.expandCollapseBtn.TabIndex = 15;
            this.expandCollapseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.expandCollapseBtn.Textcolor = System.Drawing.Color.White;
            this.expandCollapseBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandCollapseBtn.Click += new System.EventHandler(this.ExpandCollapseBtn_Click);
            // 
            // menuBtn
            // 
            this.menuBtn.Activecolor = System.Drawing.Color.Transparent;
            this.menuBtn.BackColor = System.Drawing.Color.Transparent;
            this.menuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuBtn.BorderRadius = 0;
            this.menuBtn.ButtonText = "";
            this.menuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expandCollapseTransition.SetDecoration(this.menuBtn, BunifuAnimatorNS.DecorationType.None);
            this.menuBtn.DisabledColor = System.Drawing.Color.Gray;
            this.menuBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.menuBtn.Iconimage = null;
            this.menuBtn.Iconimage_right = null;
            this.menuBtn.Iconimage_right_Selected = null;
            this.menuBtn.Iconimage_Selected = null;
            this.menuBtn.IconMarginLeft = 0;
            this.menuBtn.IconMarginRight = 0;
            this.menuBtn.IconRightVisible = false;
            this.menuBtn.IconRightZoom = 0D;
            this.menuBtn.IconVisible = true;
            this.menuBtn.IconZoom = 90D;
            this.menuBtn.IsTab = false;
            this.menuBtn.Location = new System.Drawing.Point(10, 10);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.menuBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.menuBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.menuBtn.selected = false;
            this.menuBtn.Size = new System.Drawing.Size(43, 52);
            this.menuBtn.TabIndex = 14;
            this.menuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.menuBtn.Textcolor = System.Drawing.Color.White;
            this.menuBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // accionesPanel_2
            // 
            this.accionesPanel_2.AutoSize = true;
            this.accionesPanel_2.Controls.Add(this.verificarLbl);
            this.accionesPanel_2.Controls.Add(this.verificarBtnImg);
            this.accionesPanel_2.Controls.Add(this.reservarLbl);
            this.accionesPanel_2.Controls.Add(this.reservarBtnImg);
            this.expandCollapseTransition.SetDecoration(this.accionesPanel_2, BunifuAnimatorNS.DecorationType.None);
            this.accionesPanel_2.Location = new System.Drawing.Point(384, 0);
            this.accionesPanel_2.Name = "accionesPanel_2";
            this.accionesPanel_2.Size = new System.Drawing.Size(161, 100);
            this.accionesPanel_2.TabIndex = 8;
            // 
            // verificarLbl
            // 
            this.verificarLbl.AutoSize = true;
            this.expandCollapseTransition.SetDecoration(this.verificarLbl, BunifuAnimatorNS.DecorationType.None);
            this.verificarLbl.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verificarLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.verificarLbl.Location = new System.Drawing.Point(86, 74);
            this.verificarLbl.Name = "verificarLbl";
            this.verificarLbl.Size = new System.Drawing.Size(72, 16);
            this.verificarLbl.TabIndex = 13;
            this.verificarLbl.Text = "Verificar";
            this.verificarLbl.Visible = false;
            this.verificarLbl.Click += new System.EventHandler(this.Verificar_Click);
            // 
            // verificarBtnImg
            // 
            this.verificarBtnImg.Activecolor = System.Drawing.Color.Transparent;
            this.verificarBtnImg.BackColor = System.Drawing.Color.Transparent;
            this.verificarBtnImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("verificarBtnImg.BackgroundImage")));
            this.verificarBtnImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.verificarBtnImg.BorderRadius = 0;
            this.verificarBtnImg.ButtonText = "";
            this.verificarBtnImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expandCollapseTransition.SetDecoration(this.verificarBtnImg, BunifuAnimatorNS.DecorationType.None);
            this.verificarBtnImg.DisabledColor = System.Drawing.Color.Gray;
            this.verificarBtnImg.Iconcolor = System.Drawing.Color.Transparent;
            this.verificarBtnImg.Iconimage = null;
            this.verificarBtnImg.Iconimage_right = null;
            this.verificarBtnImg.Iconimage_right_Selected = null;
            this.verificarBtnImg.Iconimage_Selected = null;
            this.verificarBtnImg.IconMarginLeft = 0;
            this.verificarBtnImg.IconMarginRight = 0;
            this.verificarBtnImg.IconRightVisible = false;
            this.verificarBtnImg.IconRightZoom = 0D;
            this.verificarBtnImg.IconVisible = true;
            this.verificarBtnImg.IconZoom = 90D;
            this.verificarBtnImg.IsTab = false;
            this.verificarBtnImg.Location = new System.Drawing.Point(90, 6);
            this.verificarBtnImg.Name = "verificarBtnImg";
            this.verificarBtnImg.Normalcolor = System.Drawing.Color.Transparent;
            this.verificarBtnImg.OnHovercolor = System.Drawing.Color.Transparent;
            this.verificarBtnImg.OnHoverTextColor = System.Drawing.Color.White;
            this.verificarBtnImg.selected = false;
            this.verificarBtnImg.Size = new System.Drawing.Size(64, 64);
            this.verificarBtnImg.TabIndex = 12;
            this.verificarBtnImg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.verificarBtnImg.Textcolor = System.Drawing.Color.White;
            this.verificarBtnImg.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verificarBtnImg.Click += new System.EventHandler(this.Verificar_Click);
            // 
            // reservarLbl
            // 
            this.reservarLbl.AutoSize = true;
            this.expandCollapseTransition.SetDecoration(this.reservarLbl, BunifuAnimatorNS.DecorationType.None);
            this.reservarLbl.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservarLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.reservarLbl.Location = new System.Drawing.Point(3, 74);
            this.reservarLbl.Name = "reservarLbl";
            this.reservarLbl.Size = new System.Drawing.Size(72, 16);
            this.reservarLbl.TabIndex = 11;
            this.reservarLbl.Text = "Reservar";
            this.reservarLbl.Visible = false;
            this.reservarLbl.Click += new System.EventHandler(this.Reservar_Click);
            // 
            // reservarBtnImg
            // 
            this.reservarBtnImg.Activecolor = System.Drawing.Color.Transparent;
            this.reservarBtnImg.BackColor = System.Drawing.Color.Transparent;
            this.reservarBtnImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reservarBtnImg.BackgroundImage")));
            this.reservarBtnImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reservarBtnImg.BorderRadius = 0;
            this.reservarBtnImg.ButtonText = "";
            this.reservarBtnImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expandCollapseTransition.SetDecoration(this.reservarBtnImg, BunifuAnimatorNS.DecorationType.None);
            this.reservarBtnImg.DisabledColor = System.Drawing.Color.Gray;
            this.reservarBtnImg.Iconcolor = System.Drawing.Color.Transparent;
            this.reservarBtnImg.Iconimage = null;
            this.reservarBtnImg.Iconimage_right = null;
            this.reservarBtnImg.Iconimage_right_Selected = null;
            this.reservarBtnImg.Iconimage_Selected = null;
            this.reservarBtnImg.IconMarginLeft = 0;
            this.reservarBtnImg.IconMarginRight = 0;
            this.reservarBtnImg.IconRightVisible = false;
            this.reservarBtnImg.IconRightZoom = 0D;
            this.reservarBtnImg.IconVisible = true;
            this.reservarBtnImg.IconZoom = 90D;
            this.reservarBtnImg.IsTab = false;
            this.reservarBtnImg.Location = new System.Drawing.Point(7, 6);
            this.reservarBtnImg.Name = "reservarBtnImg";
            this.reservarBtnImg.Normalcolor = System.Drawing.Color.Transparent;
            this.reservarBtnImg.OnHovercolor = System.Drawing.Color.Transparent;
            this.reservarBtnImg.OnHoverTextColor = System.Drawing.Color.White;
            this.reservarBtnImg.selected = false;
            this.reservarBtnImg.Size = new System.Drawing.Size(64, 64);
            this.reservarBtnImg.TabIndex = 10;
            this.reservarBtnImg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reservarBtnImg.Textcolor = System.Drawing.Color.White;
            this.reservarBtnImg.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservarBtnImg.Click += new System.EventHandler(this.Reservar_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.headerPanel.Controls.Add(this.pictureBox4);
            this.headerPanel.Controls.Add(this.pictureBox3);
            this.headerPanel.Controls.Add(this.pictureBox2);
            this.headerPanel.Controls.Add(this.pictureBox1);
            this.headerPanel.Controls.Add(this.bunifuFlatButton1);
            this.expandCollapseTransition.SetDecoration(this.headerPanel, BunifuAnimatorNS.DecorationType.None);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(920, 69);
            this.headerPanel.TabIndex = 12;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.expandCollapseTransition.SetDecoration(this.pictureBox4, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(690, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.expandCollapseTransition.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(746, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.expandCollapseTransition.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(802, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.expandCollapseTransition.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(858, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.BackgroundImage")));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expandCollapseTransition.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = false;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(3, 3);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(64, 64);
            this.bunifuFlatButton1.TabIndex = 10;
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.Reservar_Click);
            // 
            // expandCollapseTransition
            // 
            this.expandCollapseTransition.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.expandCollapseTransition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0.5F;
            animation2.RotateLimit = 0.2F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.expandCollapseTransition.DefaultAnimation = animation2;
            // 
            // panelContainer
            // 
            this.expandCollapseTransition.SetDecoration(this.panelContainer, BunifuAnimatorNS.DecorationType.None);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 69);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(920, 445);
            this.panelContainer.TabIndex = 13;
            // 
            // timerCollapse
            // 
            this.timerCollapse.Interval = 5000;
            this.timerCollapse.Tick += new System.EventHandler(this.TimerCollapse_Tick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(920, 584);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.accionesPanel);
            this.expandCollapseTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrincipalNew";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Turnos_Closing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.accionesPanel.ResumeLayout(false);
            this.accionesPanel.PerformLayout();
            this.accionesPanel_2.ResumeLayout(false);
            this.accionesPanel_2.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel accionesPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel accionesPanel_2;
        private ns1.BunifuCustomLabel verificarLbl;
        private ns1.BunifuFlatButton verificarBtnImg;
        private ns1.BunifuCustomLabel reservarLbl;
        private ns1.BunifuFlatButton reservarBtnImg;
        private ns1.BunifuFlatButton menuBtn;
        private BunifuAnimatorNS.BunifuTransition expandCollapseTransition;
        private System.Windows.Forms.Timer timerAnimation;
        private System.Windows.Forms.Timer timerCollapse;
        private System.Windows.Forms.Panel panelContainer;
        private ns1.BunifuFlatButton expandCollapseBtn;
        private ns1.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}