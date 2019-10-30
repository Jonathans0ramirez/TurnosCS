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
            this.menuBtn = new ns1.BunifuFlatButton();
            this.accionesPanel_2 = new System.Windows.Forms.Panel();
            this.verificarLbl = new ns1.BunifuCustomLabel();
            this.reservarLbl = new ns1.BunifuCustomLabel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.expandCollapseTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.ReservationLoadCheckingImg = new System.Windows.Forms.PictureBox();
            this.expandCollapseBtn = new ns1.BunifuFlatButton();
            this.verificarBtnImg = new ns1.BunifuFlatButton();
            this.reservarBtnImg = new ns1.BunifuFlatButton();
            this.accionesPanel.SuspendLayout();
            this.accionesPanel_2.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationLoadCheckingImg)).BeginInit();
            this.SuspendLayout();
            // 
            // timerAnimation
            // 
            this.timerAnimation.Interval = 60000;
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
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.headerPanel.Controls.Add(this.ReservationLoadCheckingImg);
            this.expandCollapseTransition.SetDecoration(this.headerPanel, BunifuAnimatorNS.DecorationType.None);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(920, 69);
            this.headerPanel.TabIndex = 12;
            // 
            // expandCollapseTransition
            // 
            this.expandCollapseTransition.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.expandCollapseTransition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 20;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
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
            // ReservationLoadCheckingImg
            // 
            this.expandCollapseTransition.SetDecoration(this.ReservationLoadCheckingImg, BunifuAnimatorNS.DecorationType.None);
            this.ReservationLoadCheckingImg.Image = global::Turnos.Properties.Resources.icons8_instagram_check_mark_100;
            this.ReservationLoadCheckingImg.Location = new System.Drawing.Point(3, 3);
            this.ReservationLoadCheckingImg.Name = "ReservationLoadCheckingImg";
            this.ReservationLoadCheckingImg.Size = new System.Drawing.Size(64, 64);
            this.ReservationLoadCheckingImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReservationLoadCheckingImg.TabIndex = 11;
            this.ReservationLoadCheckingImg.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.ReservationLoadCheckingImg)).EndInit();
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
        private System.Windows.Forms.Panel panelContainer;
        private ns1.BunifuFlatButton expandCollapseBtn;
        private System.Windows.Forms.PictureBox ReservationLoadCheckingImg;
    }
}