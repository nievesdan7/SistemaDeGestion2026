using CapaRN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGestion2026
{
    public partial class FRM_IniciarSesion : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
        public aususis usuario=new aususis();
        public aperson persona = new aperson();
        public bool login_exitoso = false;
        public bool actualizar_password = false;
        #endregion

        #region Constructor

        public FRM_IniciarSesion()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        private bool VerificarIntegridad()
        {
            bool respuesta = true;

            if (TXT_Login.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el Login", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_Login.Focus();
                respuesta = false;
            }
            else if (TXT_Password.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el Password", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_Password.Focus();
                respuesta = false;
            }

            return respuesta;
        }
        #endregion

        #region Eventos

        private void BTNPassword_Click(object sender, EventArgs e)
        {
            if (TXT_Password.PasswordChar == '*')
            {
                TXT_Password.PasswordChar = '\0';
            }
            else
            {
                TXT_Password.PasswordChar = '*';
            }
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Ingresar_Click(object sender, EventArgs e)
        {
            if (VerificarIntegridad())
            {
                usuario.causnomlog = TXT_Login.Text;
                usuario.ObtenerDatosLogin(false, TXT_Login.Text);
                persona.papscodper = usuario.fauscodper;
                persona.ObtenerDatos();
                if (usuario.causactpas)
                {

                    if (TXT_Password.Text == persona.capsnumcid)
                    {
                        MessageBox.Show("Bienvenido " + persona.capsnomper + " " +
                                                      persona.capsapepat + " " +
                                                      persona.capsapemat,
                                                      "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        login_exitoso = true;
                        actualizar_password = true;
                        this.Close();
                    }
                }
                else
                {
                    if (TXT_Password.Text == usuario.causpasswo)
                    {
                        MessageBox.Show("Bienvenido " + persona.capsnomper + " " +
                                                      persona.capsapepat + " " +
                                                      persona.capsapemat,
                                                      "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        login_exitoso = true;
                        actualizar_password = false;
                        this.Close();
                    }
                }
            }
        }
        #endregion
    }
}
