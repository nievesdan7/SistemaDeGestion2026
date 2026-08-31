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
    public partial class FRM_Categoria_Lista : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
        public acatpro categoria = new acatpro();
        private List<acatpro> lista = new List<acatpro>();
        public bool seleccionadoOK = false;
        private String nombreMin = "categoría";
        private String nombreMas = "Categoría";

        
        #endregion

        #region Constructor
        public FRM_Categoria_Lista()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        private void ActualizarGrid()
        {
            DTG_Lista.Rows.Clear();
            lista.Clear();

            lista = categoria.Lista("cacpnomcat like '%" + TXT_Filtrar.Text + "%' limit " +
                                    IIN_Filas.Value.ToString()
                                    );
            foreach (acatpro a in lista)
            {
                DTG_Lista.Rows.Add();

                if (a.cacpestcat)
                {
                    if (DTG_Lista.Rows.Count % 2 == 0)
                    {
                        DTG_Lista.Rows[DTG_Lista.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Gainsboro;
                    }
                }
                else
                {
                    DTG_Lista.Rows[DTG_Lista.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Tomato;
                    DTG_Lista.Rows[DTG_Lista.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
                }
                DTG_Lista[0, DTG_Lista.Rows.Count - 1].Value = a.pacpcodcat;
                DTG_Lista[1, DTG_Lista.Rows.Count - 1].Value = a.cacpestcat;
                DTG_Lista[2, DTG_Lista.Rows.Count - 1].Value = a.cacpnomcat;


            }

        }
        #endregion

        #region Eventos
        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            FRM_Categoria_Registrar a = new FRM_Categoria_Registrar();
            a.modificar = true;
            a.codTabMod = DTG_Lista[0, DTG_Lista.SelectedRows[0].Index].Value.ToString();
            a.ShowDialog();
            if (a.actualizar)
            {
                ActualizarGrid();
            }
        }

        private void FRM_Categoria_Lista_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
            
        }

        private void BTN_Registrar_Click(object sender, EventArgs e)
        {
            FRM_Categoria_Registrar a = new FRM_Categoria_Registrar();
            a.modificar = false;
            a.ShowDialog();
            if (a.actualizar)
            {
                ActualizarGrid();
            }
        }

        #endregion

        private void DTG_Lista_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (DTG_Lista.SelectedRows.Count > 0)
                {
                    FRM_Categoria_Registrar F1 = new FRM_Categoria_Registrar();
                    F1.modificar = true;
                    F1.codTabMod = DTG_Lista[0, e.RowIndex].Value.ToString();
                    F1.ShowDialog();
                    if (F1.actualizar)
                    {
                        ActualizarGrid();
                    }
                }
            }

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DTG_Lista.SelectedRows.Count > 0)
            {
                FRM_Categoria_Registrar F1 = new FRM_Categoria_Registrar();
                F1.modificar = true;
                F1.codTabMod = DTG_Lista[0, DTG_Lista.SelectedRows[0].Index].Value.ToString();
                F1.ShowDialog();
                if (F1.actualizar)
                {
                    ActualizarGrid();
                }
            }
        }

        private void inhabilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            categoria.pacpcodcat = DTG_Lista.SelectedRows[0].Cells[0].Value.ToString();
            if (categoria.ObtenerDatos())
            {
                categoria.cacpestcat = false;
                if (categoria.Modificar())
                {
                    MessageBox.Show(nombreMas+" inhabilitada");
                    ActualizarGrid();
                }
            }
        }

        private void habilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            categoria.pacpcodcat = DTG_Lista.SelectedRows[0].Cells[0].Value.ToString();
            if (categoria.ObtenerDatos())
            {
                categoria.cacpestcat = true;
                if (categoria.Modificar())
                {
                    MessageBox.Show(nombreMas + " habilitada");
                    ActualizarGrid();
                }
            }
        }

        private void CMSMenu_Opening(object sender, CancelEventArgs e)
        {
            if (DTG_Lista.SelectedRows.Count > 0)
            {
                categoria.pacpcodcat = DTG_Lista.SelectedRows[0].Cells[0].Value.ToString();
                if (categoria.ObtenerDatos())
                {
                    if (categoria.cacpestcat)
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

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            categoria.pacpcodcat = DTG_Lista.SelectedRows[0].Cells[0].Value.ToString();
            if (categoria.ObtenerDatos())
            {
                if (MessageBox.Show("¿Está seguro que desea borrar la "+nombreMin+"?",
                                "Pregunta",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (categoria.Eliminar())
                    {
                        MessageBox.Show(nombreMas+" eliminada");
                        ActualizarGrid();
                    }
                }
                                
            }
        }

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            categoria.pacpcodcat = DTG_Lista.SelectedRows[0].Cells[0].Value.ToString();
            if (categoria.ObtenerDatos())
            {
                if (MessageBox.Show("¿Está seguro que desea borrar la " + nombreMin + "?",
                                "Pregunta",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (categoria.Eliminar())
                    {
                        MessageBox.Show(nombreMas + " eliminada");
                        ActualizarGrid();
                    }
                }

            }
        }

       
    }
}
