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
    public partial class FRMProducto_Buscar : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
        public aproduc producto = new aproduc();
        private List<aproduc> lista_productos = new List<aproduc>();
        public bool seleccionadoOK = false;
        #endregion

        #region Constructor
        public FRMProducto_Buscar()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        private void ActualizarGrid()
        {
            DTGLista.Rows.Clear();
            lista_productos.Clear();

            lista_productos = producto.Lista("papdcodpro like '%" + TXT_Filtrar.Text + "%' or " +
                                           "capdnompro like '%" + TXT_Filtrar.Text + "%' limit " +
                                           IIN_Filas.Value.ToString()
                                           );
            foreach (aproduc a in lista_productos)
            {
                DTGLista.Rows.Add();

                if (!a.capdestpro)
                {
                    DTGLista.Rows[DTGLista.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Salmon;
                }
                

                DTGLista[0, DTGLista.Rows.Count - 1].Value = a.papdcodpro;
                DTGLista[1, DTGLista.Rows.Count - 1].Value = a.capdestpro;
                DTGLista[2, DTGLista.Rows.Count - 1].Value = a.capdnompro;
                DTGLista[3, DTGLista.Rows.Count - 1].Value = a.fapdcodcat;
                
                DTGLista[4, DTGLista.Rows.Count - 1].Value = a.capdmodpro;
                DTGLista[5, DTGLista.Rows.Count - 1].Value = a.capdmarpro;
                DTGLista[6, DTGLista.Rows.Count - 1].Value = a.capdmatpro;
                DTGLista[7, DTGLista.Rows.Count - 1].Value = a.capdcolpro;
                DTGLista[8, DTGLista.Rows.Count - 1].Value = a.capdstopro;
                DTGLista[9, DTGLista.Rows.Count - 1].Value = a.capdpreven;
                
               
                
            }

        }
        #endregion

        #region Eventos
        private void FRM_Producto_Buscar_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }
        private void BTN_AgregarProducto_Click(object sender, EventArgs e)
        {
            FRMProducto_Registrar a = new FRMProducto_Registrar();
            a.ShowDialog();
            if (a.actualizar)
            {
                ActualizarGrid();
            }
        }
        private void BTN_Okey_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                producto.papdcodpro = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                if (producto.ObtenerDatos())
                {
                    seleccionadoOK = true;
                    this.Close();
                }
            }
        }
        private void DTG_Lista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                producto.papdcodpro = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                if (producto.ObtenerDatos())
                {
                    seleccionadoOK = true;
                    this.Close();
                }

            }
        }

        #endregion

    }
}
