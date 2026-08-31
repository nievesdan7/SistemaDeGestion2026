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
    public partial class FRM_Fondo2 : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
        public aususis usuario = new aususis();
        public aperson persona = new aperson();
        #endregion

        #region Constructor
        public FRM_Fondo2()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos

        /*private void timer1_Tick(object sender, EventArgs e)
        {
            LBLFecha.Text = DateTime.Now.ToString("F");
        }

        private void FRM_Fondo2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            LBLUsuario.Text = "Usuario: " +
                            persona.capsapepat + " " +
                            persona.capsapemat + " " +
                            persona.capsnomper;
        }

        private void FRM_Fondo2_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
        }*/

        #endregion
    }
}
