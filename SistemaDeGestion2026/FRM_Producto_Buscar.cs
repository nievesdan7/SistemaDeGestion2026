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
    public partial class FRM_Producto_Buscar : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
        public aproduc producto = new aproduc();
        private List<aproduc> lista_productos = new List<aproduc>();
        public bool seleccionadoOK = false;
        #endregion

        #region Constructor
        public FRM_Producto_Buscar()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        private void ActualizarGrid()
        {
            DTG_Lista.Rows.Clear();
            lista_productos.Clear();

            lista_productos = producto.Lista("papdcodpro like '%" + TXT_Filtrar.Text + "%' or " +
                                           "capdnompro like '%" + TXT_Filtrar.Text + "%' limit " +
                                           IIN_Filas.Value.ToString()
                                           );
            foreach (aproduc a in lista_productos)
            {
                DTG_Lista.Rows.Add();

                if (a.capdestpro)
                {
                    if (DTG_Lista.Rows.Count % 2 == 0)
                    {
                        DTG_Lista.Rows[DTG_Lista.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                    }
                }
                else
                {
                    DTG_Lista.Rows[DTG_Lista.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Salmon;
                }

                DTG_Lista[0, DTG_Lista.Rows.Count - 1].Value = a.papdcodpro;
                DTG_Lista[1, DTG_Lista.Rows.Count - 1].Value = a.capdestpro;
                DTG_Lista[2, DTG_Lista.Rows.Count - 1].Value = a.capdnompro;
                DTG_Lista[3, DTG_Lista.Rows.Count - 1].Value = a.fapdcodcat;
                
                DTG_Lista[4, DTG_Lista.Rows.Count - 1].Value = a.capdmodpro;
                DTG_Lista[5, DTG_Lista.Rows.Count - 1].Value = a.capdmarpro;
                DTG_Lista[6, DTG_Lista.Rows.Count - 1].Value = a.capdmatpro;
                DTG_Lista[7, DTG_Lista.Rows.Count - 1].Value = a.capdcolpro;
                DTG_Lista[8, DTG_Lista.Rows.Count - 1].Value = a.capdstopro;
                DTG_Lista[9, DTG_Lista.Rows.Count - 1].Value = a.capdpreven;
                DTG_Lista[10, DTG_Lista.Rows.Count - 1].Value = a.capdfeccre;
                DTG_Lista[11, DTG_Lista.Rows.Count - 1].Value = a.capdfecmod;
                
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
            FRM_Producto_Registrar a = new FRM_Producto_Registrar();
            a.modificar = true;
            a.codProMod = DTG_Lista[0, DTG_Lista.SelectedRows[0].Index].Value.ToString();
            a.ShowDialog();
            if (a.actualizar)
            {
                ActualizarGrid();
            }
        }

        #endregion
    }
}
