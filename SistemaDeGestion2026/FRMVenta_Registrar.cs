using AForge.Video.DirectShow;
using CapaRN;
using DevComponents.DotNetBar.Controls;
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
    public partial class FRMVenta_Registrar : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
        private aclient cliente = new aclient();
        private bool clienteOK = false;

        private aproduc producto = new aproduc();
        public Boolean lectorHabilitado = false;
        private bool productoOK = false;

        public avenpro venta = new avenpro();
        private List<liteven> listaItems = new List<liteven>();

        public string CodProMod = "";
        private double total = 0;
        #endregion

        #region Constructor
        public FRMVenta_Registrar()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        private void ActualizarGridItems()
        {
            DTGLista.Rows.Clear();


            foreach (liteven a in listaItems)
            {
                DTGLista.Rows.Add();

                DTGLista[0, DTGLista.Rows.Count - 1].Value = a.paivcodite;
                DTGLista[1, DTGLista.Rows.Count - 1].Value = a.capdmodpro;
                DTGLista[2, DTGLista.Rows.Count - 1].Value = a.capdcodbar;
                DTGLista[3, DTGLista.Rows.Count - 1].Value = a.capdnompro;
                DTGLista[4, DTGLista.Rows.Count - 1].Value = a.capdtalpro;
                DTGLista[5, DTGLista.Rows.Count - 1].Value = a.capddespro;
                DTGLista[6, DTGLista.Rows.Count - 1].Value = a.caivcanite;
                DTGLista[7, DTGLista.Rows.Count - 1].Value = a.caivpreuni;
                DTGLista[8, DTGLista.Rows.Count - 1].Value = a.caivsubtot;

            }
        }
        private void AgregarItem(aproduc pro)
        {

            liteven item = new liteven();

            item = listaItems.Find(x => x.faivcodpro == pro.papdcodpro);

            if (item != null)
            {
                item.caivcanite += 1;
                item.caivsubtot = item.caivpreuni * item.caivcanite;
            }
            else
            {
                item = new liteven();
                item.faivcodpro = pro.papdcodpro;
                item.capdmodpro = pro.capdmodpro;
                item.capdcodbar = pro.capdcodbar;
                item.capdnompro = pro.capdnompro;
                item.capdtalpro = pro.capdtalpro;
                item.capddespro = pro.capddespro;
                item.caivcanite = 1;
                item.caivpreuni = pro.capdpreven;
                item.caivsubtot = item.caivpreuni * item.caivcanite;
                item.caivestite = true;

                listaItems.Add(item);
            }
            ActualizarGridItems();
            ActualizarTotal();
        }
        private void ActualizarTotal()
        {            
            total = 0;
            foreach (liteven item in listaItems)
            {
                total += (double)item.caivsubtot;
            }
            LBLTotalNumeral.Text = "Total: " + total.ToString("N2");
            LBLTotalLiteral.Text = MetodosGenerales.ConvertirNumeroALetras(total).ToUpper();
            

        }
        #endregion

        #region Eventos
        private void TXTNIT_Leave(object sender, EventArgs e)
        {
            cliente.caclnitcli = TXTNIT.Text;
            if (cliente.ObtenerDatosNIT())
            {
                TXTNombreCliente.Text = cliente.caclrazcli;
                clienteOK = true;
            }
            else
            {
                TXTNombreCliente.Text = "";
                clienteOK = false;
            }
        }
        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            FRMCliente_Buscar a = new FRMCliente_Buscar();

            // a.condicion = "papscodper not in (select papscodper from aperson,aususis where papscodper=fauscodper order by papscodper)";
            a.ShowDialog();
            if (a.seleccionadoOK)
            {
                this.cliente = a.cliente;
                this.clienteOK = true;
                TXTNIT.Text = cliente.caclnitcli;
                TXTNombreCliente.Text = cliente.caclrazcli;

            }
            else
            {
                this.clienteOK = false;
                TXTNIT.Text = "";
                TXTNombreCliente.Text = "Nommbre del cliente";
            }
        }
        private void BTNCodigoBarras_Click(object sender, EventArgs e)
        {
            if (!lectorHabilitado)
            {
                lectorHabilitado = true;
                LBLCodigoBarras.Text = "LECTOR ACTIVO";
                LBLCodigoBarras.BackColor = Color.ForestGreen;
            }
            else
            {

                producto.capdcodbar = LBLCodigoBarras.Text;

                if (producto.ObtenerDatosCodigo(false, producto.capdcodbar))
                {
                    //MessageBox.Show("Producto encontrado: " + producto.capddespro, "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AgregarItem(producto);
                    lectorHabilitado = true;
                    LBLCodigoBarras.Text = "LECTOR ACTIVO";
                    LBLCodigoBarras.BackColor = Color.ForestGreen;
                }
                else
                {
                    MessageBox.Show("Producto no encontrado", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LBLCodigoBarras.Text = "LECTOR ACTIVO";
                    LBLCodigoBarras.BackColor = Color.ForestGreen;
                    BTNCodigoBarras.Focus();

                }

            }
        }
        private void BTNCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (LBLCodigoBarras.Text == "LECTOR ACTIVO")
            {
                LBLCodigoBarras.Text = "" + e.KeyChar;
            }
            else
            {
                LBLCodigoBarras.Text += e.KeyChar;
            }
        }
        private void FRMVenta_Registrar_Load(object sender, EventArgs e)
        {
            lectorHabilitado = false;
            LBLCodigoBarras.Text = "LECTOR INACTIVO";
            LBLCodigoBarras.BackColor = Color.Salmon;
            LBLCodigoBarras.ForeColor = Color.White;
            ActualizarGridItems();
        }
        private void BTNCodigoBarras_Leave(object sender, EventArgs e)
        {
            lectorHabilitado = false;
            LBLCodigoBarras.Text = "LECTOR INACTIVO";
            LBLCodigoBarras.BackColor = Color.Salmon;
            LBLCodigoBarras.ForeColor = Color.White;
        }
        private void BTNBuscarProducto_Click(object sender, EventArgs e)
        {
            FRMProducto_Buscar a = new FRMProducto_Buscar();
            a.ShowDialog();
            if (a.seleccionadoOK)
            {
                this.producto = a.producto;
                this.productoOK = true;
                AgregarItem(producto);
            }
            else
            {
                this.productoOK = false;

            }

        }
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Desea eliminar el item seleccionado?", "Eliminar item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string codItem = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                    liteven item = listaItems.Find(x => x.paivcodite == codItem);
                    if (item != null)
                    {                         
                        total -= (double)item.caivsubtot;
                        LBLTotalNumeral.Text = "Total: " + total.ToString("N2");
                        LBLTotalLiteral.Text = MetodosGenerales.ConvertirNumeroALetras(total).ToUpper();
                        listaItems.Remove(item);
                        ActualizarGridItems();
                    }
                }
            }
        }
        #endregion

        private void DTGLista_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                eliminarToolStripMenuItem_Click(sender, e);
            }
        }
    }
}