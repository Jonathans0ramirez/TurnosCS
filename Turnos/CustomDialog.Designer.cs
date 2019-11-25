namespace Turnos
{
    partial class CustomDialog
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
            this.yesBtn = new System.Windows.Forms.Button();
            this.noBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.okBtn = new System.Windows.Forms.Button();
            this.flPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.dialogImg = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contentLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.flowLayoutPanelButtons.SuspendLayout();
            this.flPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dialogImg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // yesBtn
            // 
            this.yesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.yesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(106)))), ((int)(((byte)(57)))));
            this.yesBtn.FlatAppearance.BorderSize = 0;
            this.yesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.yesBtn.Location = new System.Drawing.Point(476, 11);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(75, 23);
            this.yesBtn.TabIndex = 3;
            this.yesBtn.Text = "Sí";
            this.yesBtn.UseVisualStyleBackColor = false;
            this.yesBtn.Visible = false;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // noBtn
            // 
            this.noBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.noBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.noBtn.FlatAppearance.BorderSize = 0;
            this.noBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noBtn.Location = new System.Drawing.Point(557, 11);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(75, 23);
            this.noBtn.TabIndex = 3;
            this.noBtn.Text = "No";
            this.noBtn.UseVisualStyleBackColor = false;
            this.noBtn.Visible = false;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // flowLayoutPanelButtons
            // 
            this.flowLayoutPanelButtons.AutoSize = true;
            this.flowLayoutPanelButtons.Controls.Add(this.noBtn);
            this.flowLayoutPanelButtons.Controls.Add(this.yesBtn);
            this.flowLayoutPanelButtons.Controls.Add(this.okBtn);
            this.flowLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(0, 111);
            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            this.flowLayoutPanelButtons.Padding = new System.Windows.Forms.Padding(8);
            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(651, 45);
            this.flowLayoutPanelButtons.TabIndex = 5;
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.okBtn.FlatAppearance.BorderSize = 0;
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBtn.Location = new System.Drawing.Point(395, 11);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 3;
            this.okBtn.Text = "Ok  >";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Visible = false;
            this.okBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // flPanel
            // 
            this.flPanel.Controls.Add(this.dialogImg);
            this.flPanel.Controls.Add(this.panel1);
            this.flPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flPanel.Location = new System.Drawing.Point(0, 0);
            this.flPanel.Name = "flPanel";
            this.flPanel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.flPanel.Size = new System.Drawing.Size(651, 111);
            this.flPanel.TabIndex = 8;
            // 
            // dialogImg
            // 
            this.dialogImg.BackgroundImage = global::Turnos.Properties.Resources.CreadaImg;
            this.dialogImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dialogImg.Location = new System.Drawing.Point(18, 3);
            this.dialogImg.Name = "dialogImg";
            this.dialogImg.Size = new System.Drawing.Size(100, 108);
            this.dialogImg.TabIndex = 9;
            this.dialogImg.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.contentLbl);
            this.panel1.Controls.Add(this.titleLbl);
            this.panel1.Location = new System.Drawing.Point(121, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 108);
            this.panel1.TabIndex = 10;
            // 
            // contentLbl
            // 
            this.contentLbl.AutoEllipsis = true;
            this.contentLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.contentLbl.Location = new System.Drawing.Point(0, 52);
            this.contentLbl.Name = "contentLbl";
            this.contentLbl.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.contentLbl.Size = new System.Drawing.Size(511, 56);
            this.contentLbl.TabIndex = 8;
            this.contentLbl.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc at dui in nisl volu" +
    "tpat euismod ac a enim. Curabitur ultrices elit ex. Suspendisse dictum mattis.";
            this.contentLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoEllipsis = true;
            this.titleLbl.AutoSize = true;
            this.titleLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLbl.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(106)))), ((int)(((byte)(57)))));
            this.titleLbl.Location = new System.Drawing.Point(0, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.titleLbl.Size = new System.Drawing.Size(186, 52);
            this.titleLbl.TabIndex = 7;
            this.titleLbl.Text = "titleLbl";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(651, 156);
            this.Controls.Add(this.flPanel);
            this.Controls.Add(this.flowLayoutPanelButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CustomDialog_Load);
            this.flowLayoutPanelButtons.ResumeLayout(false);
            this.flPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dialogImg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button yesBtn;
        private System.Windows.Forms.Button noBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.FlowLayoutPanel flPanel;
        private System.Windows.Forms.PictureBox dialogImg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label contentLbl;
        private System.Windows.Forms.Label titleLbl;
    }
}