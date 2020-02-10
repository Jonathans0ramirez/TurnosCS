using System;
using System.Drawing;
using System.Windows.Forms;

namespace Turnos
{
    public partial class CustomDialog : Form
    {
        static CustomDialog customDialog;

        static DialogResult Button_id;

        public CustomDialog()
        {
            InitializeComponent();
        }

        public static DialogResult ShowMessage(string content, string title, MessageBoxButtons buttons, Image image)
        {
            customDialog = new CustomDialog();
            customDialog.titleLbl.Text = title;
            customDialog.contentLbl.Text = content;
            customDialog.dialogImg.BackgroundImage = image;
            customDialog.dialogImg.BackgroundImageLayout = ImageLayout.Zoom;
            switch (buttons)
            {
                case MessageBoxButtons.YesNo:
                    customDialog.yesBtn.Visible = true;
                    customDialog.noBtn.Visible = true;
                    break;
                case MessageBoxButtons.OK:
                    customDialog.okBtn.Visible = true;
                    break;
            }
            customDialog.timerClose.Start();
            customDialog.ShowDialog();
            return Button_id;
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            Button_id = System.Windows.Forms.DialogResult.Yes;
            customDialog.Dispose();
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            customDialog.Dispose();
            Button_id = System.Windows.Forms.DialogResult.No;
        }

        private void CustomDialog_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            this.TopMost = true;
            this.Focus();
        }

        private void closePic_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void closePic_MouseEnter(object sender, EventArgs e)
        {
            closePic.BackColor = Color.Crimson;
            closePic.BackgroundImage = global::Turnos.Properties.Resources.CloseIconWhite;
        }

        private void closePic_MouseLeave(object sender, EventArgs e)
        {
            closePic.BackColor = Color.Transparent;
            closePic.BackgroundImage = global::Turnos.Properties.Resources.CloseIconBlack;
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            timerClose.Stop();
            this.Close();
            this.Dispose();
        }
    }
}
