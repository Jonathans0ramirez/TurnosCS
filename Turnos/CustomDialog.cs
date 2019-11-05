﻿using System;
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

        public static DialogResult ShowMessage(string content, string title, MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            customDialog = new CustomDialog();
            customDialog.titleLbl.Text = title;
            customDialog.contentLbl.Text = content;
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
    }
}
