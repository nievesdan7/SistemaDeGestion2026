
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
    public partial class FRM_Principal : Form
    {
        #region Variables
        public aususis usuario = new aususis();
        public aperson persona = new aperson();
        #endregion

        #region Constructor
        public FRM_Principal()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos

        private void Estado_1() {
            foreach (Form s in this.MdiChildren)
            {
                s.Close();
            }
            FRM_Fondo1 a = new FRM_Fondo1();
            a.MdiParent = this;
            a.Dock = DockStyle.Fill;
            a.Show();
            BTNActualizarPassword.Enabled = false;
            BTNCerrarSesion.Enabled = false;
            RTB_Administracion.Enabled = false;
            RTB_Inventario.Enabled = false;
            RBPAdministracion.Enabled = false;
            BTNLogin.Enabled = true;
            BTN_LoginHuella.Enabled = true;

            timer1.Enabled = false;
        }

        private void Estado_2()
        {
            foreach (Form s in this.MdiChildren)
            {
                s.Close();
            }
            FRM_Fondo2 a = new FRM_Fondo2();
            a.MdiParent = this;
            a.Dock = DockStyle.Fill;
            a.persona = this.persona;
            a.usuario = this.usuario;
            a.Show();
            BTNActualizarPassword.Enabled = true;
            BTNCerrarSesion.Enabled = true;
            RTB_Administracion.Enabled = true;
            RTB_Inventario.Enabled = true;
            RBPAdministracion.Enabled = true;
            BTNLogin.Enabled = false;
            BTN_LoginHuella.Enabled = false;

            timer1.Enabled = true;
            lblUsuario.Text = "Usuario: " +
                            persona.capsapepat + " " +
                            persona.capsapemat + " " +
                            persona.capsnomper;
        }

        #endregion

        #region Eventos
        private void FRM_Principal_Load(object sender, EventArgs e)
        {
            FRM_Splash banner = new FRM_Splash();
            banner.ShowDialog();
            this.Opacity = 1;
            Estado_1();
        }
        private void BTN_Personas_Click(object sender, EventArgs e)
        {
            foreach ( Form s in this.MdiChildren )
            {
                s.Close();
            }
            FRMPersona_Lista a = new FRMPersona_Lista();
            a.MdiParent = this;
            a.Dock = DockStyle.Fill;
            a.Show();
        }
        private void BTN_Usuarios_Click(object sender, EventArgs e)
        {
            foreach (Form s in this.MdiChildren)
            {
                s.Close();
            }
            FRMUsuario_Lista a = new FRMUsuario_Lista();
            a.MdiParent = this;
            a.Dock = DockStyle.Fill;
            a.Show();
        }
        private void BTNLogin_Click(object sender, EventArgs e)
        {
            FRMIniciar_Sesion a = new FRMIniciar_Sesion();
            a.ShowDialog();
            if (a.actualizar_password) {
                FRMModificar_Password b = new FRMModificar_Password();
                b.usuario = a.usuario;
                b.persona = a.persona;
                b.ShowDialog();
            }
            
            if (a.login_exitoso)
            {
                this.persona = a.persona;
                this.usuario = a.usuario;
                Estado_2();
            }
        }
        private void BTN_LoginHuella_Click(object sender, EventArgs e)
        {
            FRMIniciar_Sesion_Huella a = new FRMIniciar_Sesion_Huella();
            a.ShowDialog();
            if(a.login_exitoso) {
                /*MessageBox.Show("Bienvenido al sistema " + a.persona.capsnomper, "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                this.persona = a.persona;
                this.usuario = a.usuario;
                Estado_2();
            }
        }
        private void BTNCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar sesión?",
                                "Cerrar Sesión",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Estado_1();
            }
        }
        private void BTN_Productos_Click(object sender, EventArgs e)
        {
            foreach (Form s in this.MdiChildren)
            {
                s.Close();
            }
            FRMProducto_Lista a = new FRMProducto_Lista();
            a.MdiParent = this;
            a.Dock = DockStyle.Fill;
            a.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = "Fecha y Hora: "+DateTime.Now.ToString("F");
        }
        private void BTN_Categorias_Click(object sender, EventArgs e)
        {
            foreach (Form s in this.MdiChildren)
            {
                s.Close();
            }
            FRMCategoria_Lista a = new FRMCategoria_Lista();
            a.MdiParent = this;
            a.Dock = DockStyle.Fill;
            a.Show();
        }
        private void BTN_Clientes_Click(object sender, EventArgs e)
        {
            foreach (Form s in this.MdiChildren)
            {
                s.Close();
            }
            FRMCliente_Lista a = new FRMCliente_Lista();
            a.MdiParent = this;
            a.Dock = DockStyle.Fill;
            a.Show();
        }
        private void BTN_Proveedores_Click(object sender, EventArgs e)
        {
            foreach (Form s in this.MdiChildren)
            {
                s.Close();
            }
            FRMProveedor_Lista a = new FRMProveedor_Lista();
            a.MdiParent = this;
            a.Dock = DockStyle.Fill;
            a.Show();
        }
        private void BTNVentas_Click(object sender, EventArgs e)
        {
            foreach (Form s in this.MdiChildren)
            {
                s.Close();
            }
            FRMVenta_Lista a = new FRMVenta_Lista();
            a.MdiParent = this;
            a.Dock = DockStyle.Fill;
            a.Show();
        }
        #endregion

    }
}
