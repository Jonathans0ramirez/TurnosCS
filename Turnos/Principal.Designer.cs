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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.timerAnimation = new System.Windows.Forms.Timer(this.components);
            this.headerPanel = new System.Windows.Forms.Panel();
            this.pbFranja = new System.Windows.Forms.PictureBox();
            this.ReservationLoadCheckingImg = new System.Windows.Forms.PictureBox();
            this.logoStatusTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFranja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationLoadCheckingImg)).BeginInit();
            this.SuspendLayout();
            // 
            // timerAnimation
            // 
            this.timerAnimation.Interval = 60000;
            this.timerAnimation.Tick += new System.EventHandler(this.TimerAnimation_Tick);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(176)))), ((int)(((byte)(6)))));
            this.headerPanel.Controls.Add(this.pbFranja);
            this.headerPanel.Controls.Add(this.ReservationLoadCheckingImg);
            this.logoStatusTransition.SetDecoration(this.headerPanel, BunifuAnimatorNS.DecorationType.None);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(920, 70);
            this.headerPanel.TabIndex = 12;
            // 
            // pbFranja
            // 
            this.pbFranja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFranja.BackgroundImage = global::Turnos.Properties.Resources.FranjaInstImg;
            this.pbFranja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoStatusTransition.SetDecoration(this.pbFranja, BunifuAnimatorNS.DecorationType.None);
            this.pbFranja.Location = new System.Drawing.Point(681, 0);
            this.pbFranja.Name = "pbFranja";
            this.pbFranja.Size = new System.Drawing.Size(239, 70);
            this.pbFranja.TabIndex = 12;
            this.pbFranja.TabStop = false;
            // 
            // ReservationLoadCheckingImg
            // 
            this.logoStatusTransition.SetDecoration(this.ReservationLoadCheckingImg, BunifuAnimatorNS.DecorationType.None);
            this.ReservationLoadCheckingImg.Image = global::Turnos.Properties.Resources.icons8_instagram_check_mark_100;
            this.ReservationLoadCheckingImg.Location = new System.Drawing.Point(3, 3);
            this.ReservationLoadCheckingImg.Name = "ReservationLoadCheckingImg";
            this.ReservationLoadCheckingImg.Size = new System.Drawing.Size(64, 64);
            this.ReservationLoadCheckingImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReservationLoadCheckingImg.TabIndex = 11;
            this.ReservationLoadCheckingImg.TabStop = false;
            // 
            // logoStatusTransition
            // 
            this.logoStatusTransition.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.logoStatusTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 20;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.logoStatusTransition.DefaultAnimation = animation1;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.SystemColors.Control;
            this.logoStatusTransition.SetDecoration(this.panelContainer, BunifuAnimatorNS.DecorationType.None);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 70);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(920, 592);
            this.panelContainer.TabIndex = 13;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(920, 662);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.headerPanel);
            this.logoStatusTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrincipalNew";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Turnos_Closing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFranja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationLoadCheckingImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel headerPanel;
        private BunifuAnimatorNS.BunifuTransition logoStatusTransition;
        private System.Windows.Forms.Timer timerAnimation;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.PictureBox ReservationLoadCheckingImg;
        private System.Windows.Forms.PictureBox pbFranja;
    }
}