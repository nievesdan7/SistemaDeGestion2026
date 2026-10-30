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
    public partial class FRMVenta_Lista : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
        
        private avenpro venta = new avenpro();
        private List<avenpro> listaVentas = new List<avenpro>();
        
        #endregion

        #region Constructor
        public FRMVenta_Lista()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        public void ActualizarGrid()
        {
            DTGLista.Rows.Clear();            
            
            listaVentas = venta.Lista("cavpobsven like '%" + TXTFiltrar.Text +"%' limit " +
                                           IIN_Filas.Value.ToString()
                );
            foreach (avenpro v in listaVentas)
            {
                DTGLista.Rows.Add();
                if (v.cavpestven)
                {
                    if (DTGLista.Rows.Count % 2 == 0)
                    {
                        DTGLista.Rows[DTGLista.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Gainsboro;
                    }
                }
                else
                {
                    DTGLista.Rows[DTGLista.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Tomato;
                    DTGLista.Rows[DTGLista.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
                }
                DTGLista[0, DTGLista.Rows.Count - 1].Value = v.pavpcodven;
                DTGLista[1, DTGLista.Rows.Count - 1].Value = v.cavpestven;
                DTGLista[2, DTGLista.Rows.Count - 1].Value = v.cavpfeccre;
                DTGLista[3, DTGLista.Rows.Count - 1].Value = v.favpusucre;
                DTGLista[4, DTGLista.Rows.Count - 1].Value = v.cavpfecmod;
                DTGLista[5, DTGLista.Rows.Count - 1].Value = v.favpusumod;
                DTGLista[6, DTGLista.Rows.Count - 1].Value = v.cavpmontot;
                DTGLista[7, DTGLista.Rows.Count - 1].Value = v.cavpobsven;
                DTGLista[8, DTGLista.Rows.Count - 1].Value = v.favpcodcli;
            }
        }
        #endregion

        #region Eventos
        private void BTN_Registrar_Click(object sender, EventArgs e)
        {
            FRMVenta_Registrar a = new FRMVenta_Registrar();
            a.modificar = false;
            a.ShowDialog();
            if (a.actualizar)
            {
                ActualizarGrid();
            }

        }
        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                FRMVenta_Registrar a= new FRMVenta_Registrar();
                a.modificar = true;

                // Obtiene el código de la venta seleccionada (asumiendo que está en la primera columna, índice 0)
                a.CodVenMod = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();

                a.ShowDialog();

                if (a.actualizar)
                {
                    ActualizarGrid();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una venta de la lista para modificar.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }
        #endregion

        private void FRMVenta_Lista_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }
    }
}
