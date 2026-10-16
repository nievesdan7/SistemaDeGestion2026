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
    public partial class FRMProducto_Lista : DevComponents.DotNetBar.Office2007Form
    {

        #region Variables
        private lproduc producto = new lproduc();
        private aproduc producto2 = new aproduc();
        private List<lproduc> lista_productos = new List<lproduc>();
        public bool seleccionadoOK = false;
        
        #endregion

        #region Constructor
        public FRMProducto_Lista()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        private void ActualizarGrid()
        {
            DTG_Lista.Rows.Clear();
            lista_productos.Clear();

            lista_productos = producto.Lista("(capdmodpro like '%" + TXTFiltrar.Text + "%' or " +
                                             "capdcodbar like '%" + TXTFiltrar.Text + "%' or " +
                                             "capdnompro like '%" + TXTFiltrar.Text + "%' or " +
                                             "capdgenpro like '%" + TXTFiltrar.Text + "%' or " +
                                             "capdmarpro like '%" + TXTFiltrar.Text + "%' or " +
                                             "capdcolpro like '%" + TXTFiltrar.Text + "%' or " +
                                             "capdtalpro like '%" + TXTFiltrar.Text + "%' or " +
                                             "capddespro like '%" + TXTFiltrar.Text + "%' or " +
                                             "cacpnomcat like '%" + TXTFiltrar.Text + "%') limit " +
                                           IIN_Filas.Value.ToString()
                                           );
            foreach (lproduc a in lista_productos)
            {
                DTG_Lista.Rows.Add();

                if (!a.capdestpro)
                {
                    DTG_Lista.Rows[DTG_Lista.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Salmon;
                }

                DTG_Lista[0, DTG_Lista.Rows.Count - 1].Value = a.papdcodpro;
                DTG_Lista[1, DTG_Lista.Rows.Count - 1].Value = a.capdestpro;
                DTG_Lista[2, DTG_Lista.Rows.Count - 1].Value = a.capdmodpro;
                DTG_Lista[3, DTG_Lista.Rows.Count - 1].Value = a.capdcodbar;
                DTG_Lista[4, DTG_Lista.Rows.Count - 1].Value = a.capdnompro;
                DTG_Lista[5, DTG_Lista.Rows.Count - 1].Value = a.cacpnomcat;
                DTG_Lista[6, DTG_Lista.Rows.Count - 1].Value = a.capdgenpro;
                DTG_Lista[7, DTG_Lista.Rows.Count - 1].Value = a.capdmarpro;
                DTG_Lista[8, DTG_Lista.Rows.Count - 1].Value = a.capdcolpro;
                DTG_Lista[9, DTG_Lista.Rows.Count - 1].Value = a.capdtalpro;
                DTG_Lista[10, DTG_Lista.Rows.Count - 1].Value = a.capdstopro;
                DTG_Lista[11, DTG_Lista.Rows.Count - 1].Value = a.capdpreven;
                DTG_Lista[12, DTG_Lista.Rows.Count - 1].Value = a.capddespro;


            }

        }
        #endregion

        #region Eventos
        private void FRM_Producto_Lista_Load(object sender, EventArgs e)
        {            
            ActualizarGrid();            
        }
        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            if (DTG_Lista.SelectedRows.Count>0)
            {
                FRMProducto_Registrar a = new FRMProducto_Registrar();
                a.modificar = true;
                a.codProMod = DTG_Lista[0, DTG_Lista.SelectedRows[0].Index].Value.ToString();
                a.ShowDialog();
                if (a.actualizar)
                {
                    ActualizarGrid();
                }
            }
            else {
                MessageBox.Show("No hay elementos en la tabla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                        
            
        }
        private void BTN_Registrar_Click(object sender, EventArgs e)
        {
            FRMProducto_Registrar a = new FRMProducto_Registrar();
            a.modificar = false;
            a.ShowDialog();
            if (a.actualizar)
            {
                ActualizarGrid();
            }
        }
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DTG_Lista.SelectedRows.Count > 0)
            {
                FRMProducto_Registrar F1 = new FRMProducto_Registrar();
                F1.modificar = true;
                F1.codProMod = DTG_Lista[0, DTG_Lista.SelectedRows[0].Index].Value.ToString();
                F1.ShowDialog();
                if (F1.actualizar)
                {
                    ActualizarGrid();
                }
            }
        }
        private void inhabilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DTG_Lista.SelectedRows.Count > 0)
            {
                producto2.papdcodpro = DTG_Lista.SelectedRows[0].Cells[0].Value.ToString();
                if (producto2.ObtenerDatos())
                {
                    producto2.capdestpro = false;
                    if (producto2.Modificar())
                    {
                        MessageBox.Show("Producto inhabilitado");
                        ActualizarGrid();
                    }
                }
            }
        }
        private void habilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DTG_Lista.SelectedRows.Count > 0)
            {
                producto2.papdcodpro = DTG_Lista.SelectedRows[0].Cells[0].Value.ToString();
                if (producto2.ObtenerDatos())
                {
                    producto2.capdestpro = true;
                    if (producto2.Modificar())
                    {
                        MessageBox.Show("Producto habilitado");
                        ActualizarGrid();
                    }
                }
            }
        }
        private void CMSMenu_Opening(object sender, CancelEventArgs e)
        {
            if (DTG_Lista.SelectedRows.Count > 0)
            {
                producto2.papdcodpro = DTG_Lista.SelectedRows[0].Cells[0].Value.ToString();
                if (producto2.ObtenerDatos())
                {
                    if (producto2.capdestpro)
                    {
                        CMSMenu.Items[1].Visible = true;
                        CMSMenu.Items[2].Visible = false;
                    }
                    else
                    {
                        CMSMenu.Items[1].Visible = false;
                        CMSMenu.Items[2].Visible = true;
                    }
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void TXTFiltrar_Enter(object sender, EventArgs e)
        {
            TXTFiltrar.SelectAll();
        }
        #endregion

        private void DTGLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (DTG_Lista.SelectedRows.Count > 0)
                {
                    FRMProducto_Registrar F1 = new FRMProducto_Registrar();
                    F1.modificar = true;
                    F1.codProMod = DTG_Lista[0, e.RowIndex].Value.ToString();
                    F1.ShowDialog();
                    if (F1.actualizar)
                    {
                        ActualizarGrid();
                    }
                }
            }
        }
    }
}
