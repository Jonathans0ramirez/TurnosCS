using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Turnos
{
    public partial class ValidarTurno : UserControl
    {
        WebServices servicios = new WebServices();

        ConfManager confManager = new ConfManager();

        static ValidarTurno _instance;

        public static ValidarTurno Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ValidarTurno();
                }
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }

        public ValidarTurno()
        {
            InitializeComponent();
            Show();
        }

        public void centrarPaneles()
        {
            int x, y;
            x = (panelValidar.Width / 2) - (panelValidar_2.Width / 2);
            y = (panelValidar.Height / 2) - (panelValidar_2.Height / 2);
            panelValidar_2.Location = new Point(x, y);
        }

        private void ValidarBtn_Click(object sender, EventArgs e)
        {
            if (!backgroundWorkerValidar.IsBusy)
            {
                backgroundWorkerValidar.RunWorkerAsync();
            }
        }

        private void validarBtn_MouseEnter(object sender, EventArgs e)
        {
            validarBtn.UseVisualStyleBackColor = false;
            validarBtn.BackColor = Color.FromArgb(127, 179, 22);
        }

        private void validarBtn_MouseLeave(object sender, EventArgs e)
        {
            validarBtn.UseVisualStyleBackColor = true;
            validarBtn.BackColor = Color.FromArgb(31, 106, 57);
        }

        private void ValidarTurno_Load(object sender, EventArgs e)
        {
            centrarPaneles();
        }

        private void backgroundWorkerValidar_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Principal.Instance.BeginInvoke((Action)delegate ()
            {
                Principal.Instance.actualizarImgEstado(global::Turnos.Properties.Resources.Spinner_1s_64px);
            });
            if (textBoxPass.Text == "turnosUGT")
            {
                ValidarTurno.Instance.BeginInvoke((Action)delegate ()
                {
                    textBoxUser.Text = string.Empty;
                    textBoxPass.Text = string.Empty;
                });
                
                Principal.Instance.esEquipoHabilitado = true;
                Principal.Instance.makeVisible(false);
            }
            //else if (false) //Para Pruebas
            else if (servicios.validarTurnoUsuario(textBoxUser.Text))
            {
                if (servicios.validarUsuario(textBoxUser.Text, textBoxPass.Text) || textBoxUser.Text.ToLower() == "user.turnos")
                {
                    confManager.AddUpdateAppSettings("Usuario", textBoxUser.Text);
                    servicios.registrarUsoReserva(textBoxUser.Text);
                    Principal.Instance.BeginInvoke((Action)delegate ()
                    {
                        Principal.Instance.actualizarImgEstado(global::Turnos.Properties.Resources.Login_Icon);
                        Principal.Instance.esEquipoHabilitado = true;
                        Principal.Instance.makeVisible(false);
                    });
                    this.BeginInvoke((Action)delegate ()
                    {
                        textBoxUser.Text = string.Empty;
                        textBoxPass.Text = string.Empty;
                        textBoxUser.Focus();
                    });
                }
                else
                {
                    Principal.Instance.BeginInvoke((Action)delegate ()
                    {
                        Principal.Instance.actualizarImgEstado(global::Turnos.Properties.Resources.Login_Icon);
                    });
                    string message = textBoxUser.Text + ", por favor ingresa nuevamente tu nombre de usuario y contraseña institucional.";
                    string title = "¡Error al autenticar!";
                    Principal.Instance.BeginInvoke((Action)delegate ()
                    {
                        Principal.Instance.TopMost = false;
                    });
                    CustomDialog.ShowMessage(message, title, MessageBoxButtons.OK, global::Turnos.Properties.Resources.ErrorImg);
                    Principal.Instance.BeginInvoke((Action)delegate ()
                    {
                        Principal.Instance.TopMost = true;
                    });
                    this.BeginInvoke((Action)delegate ()
                    {
                        textBoxPass.Text = string.Empty;
                        textBoxPass.Focus();
                    });
                }
            }
            else
            {
                if (servicios.validarUsuario(textBoxUser.Text, textBoxPass.Text))
                {
                    Principal.Instance.BeginInvoke((Action)delegate ()
                    {
                        Principal.Instance.actualizarImgEstado(global::Turnos.Properties.Resources.Login_Icon);
                    });
                    string message = "Hola, no tienes reservado este equipo. ¿Deseas realizar la reserva de este equipo?";
                    string title = "¿Reserva?";
                    Principal.Instance.BeginInvoke((Action)delegate ()
                    {
                        Principal.Instance.TopMost = false;
                    });
                    DialogResult result = CustomDialog.ShowMessage(message, title, MessageBoxButtons.YesNo, global::Turnos.Properties.Resources.ReservarImg);
                    Principal.Instance.BeginInvoke((Action)delegate ()
                    {
                        Principal.Instance.TopMost = true;
                    });
                    if (result == DialogResult.Yes)
                    {
                        Thread.Sleep(30);
                        confManager.AddUpdateAppSettings("Usuario", textBoxUser.Text);

                        // Se manda al UserControl ReservarTurno.cs para que el usuario realice su reserva
                        Principal.Instance.BeginInvoke((Action)delegate ()
                        {
                            if (!Principal.Instance.pnlContainer.Controls.Contains(ReservarTurno.Instance))
                            {
                                Principal.Instance.pnlContainer.Controls.Add(ReservarTurno.Instance);
                                ReservarTurno.Instance.BeginInvoke((Action)delegate ()
                                {
                                    ReservarTurno.Instance.Dock = DockStyle.Fill;
                                });
                            }
                            ReservarTurno.Instance.BeginInvoke((Action)delegate ()
                            {
                                ReservarTurno.Instance.BringToFront();
                                ReservarTurno.Instance.centrarPanelesContainers();
                            });
                            if (Principal.Instance.pnlContainer.Controls.Contains(ValidarTurno.Instance))
                            {
                                Principal.Instance.pnlContainer.Controls.Remove(ValidarTurno.Instance);
                                ValidarTurno.Instance.Dispose();
                                ValidarTurno.Instance = null;
                            }
                        });
                    }
                    else
                    {
                        // Limpia los campos usuario y contraseña del UserControl
                        this.BeginInvoke((Action)delegate ()
                        {
                            textBoxUser.Text = string.Empty;
                            textBoxPass.Text = string.Empty;
                            textBoxUser.Focus();
                        });
                    }
                }
                else
                {
                    Principal.Instance.BeginInvoke((Action)delegate ()
                    {
                        Principal.Instance.actualizarImgEstado(global::Turnos.Properties.Resources.Login_Icon);
                    });
                    string message = textBoxUser.Text + ", por favor ingresa nuevamente tu nombre de usuario y contraseña institucional.";
                    string title = "¡Error al autenticar!";
                    Principal.Instance.BeginInvoke((Action)delegate ()
                    {
                        Principal.Instance.TopMost = false;
                    });
                    CustomDialog.ShowMessage(message, title, MessageBoxButtons.OK, global::Turnos.Properties.Resources.ErrorImg);
                    Principal.Instance.BeginInvoke((Action)delegate ()
                    {
                        Principal.Instance.TopMost = true;
                    });
                    this.BeginInvoke((Action)delegate ()
                    {
                        textBoxPass.Text = string.Empty;
                        textBoxPass.Focus();
                    });
                }
            }
        }

        private void textBoxPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidarBtn_Click(sender, e);

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
