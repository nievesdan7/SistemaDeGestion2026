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
    public partial class FRM_Proveedor_Lista : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables

        private aprovee proveedor = new aprovee();
        private List<aprovee> lista = new List<aprovee>();

        #endregion

        #region Constructor
        public FRM_Proveedor_Lista()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        private void ActualizarGrid()
        {
            DTG_Lista.Rows.Clear();
            lista.Clear();
            lista = proveedor.Lista("(capvrazprv like '%" + TXT_Filtrar.Text + "%' or " +
                                            "capvnirprv like '%" + TXT_Filtrar.Text + "%' or " +
                                            "capvdirprv like '%" + TXT_Filtrar.Text + "%' or " +
                                            "capvtelprv like '%" + TXT_Filtrar.Text + "%') limit " +
                                           IIN_Filas.Value.ToString()
                                           );

            foreach (aprovee a in lista)
            {
                DTG_Lista.Rows.Add();

                if (a.capvestprv)
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
                DTG_Lista[0, DTG_Lista.Rows.Count - 1].Value = a.fapvcodper;
                DTG_Lista[1, DTG_Lista.Rows.Count - 1].Value = a.capvestprv;
                DTG_Lista[2, DTG_Lista.Rows.Count - 1].Value = a.capvrazprv;
                DTG_Lista[3, DTG_Lista.Rows.Count - 1].Value = a.capvnirprv;

                DTG_Lista[4, DTG_Lista.Rows.Count - 1].Value = a.capvdirprv;
                DTG_Lista[5, DTG_Lista.Rows.Count - 1].Value = a.capvtelprv;


            }

        }
        #endregion

        #region Eventos

        private void BTN_Registrar_Click(object sender, EventArgs e)
        {
            FRM_Proveedor_Registrar F1 = new FRM_Proveedor_Registrar();
            F1.modificar = false;
            F1.ShowDialog();
            if (F1.actualizar)
            {
                ActualizarGrid();
            }
        }

        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            if (DTG_Lista.SelectedRows.Count > 0)
            {
                FRM_Proveedor_Registrar F1 = new FRM_Proveedor_Registrar();
                F1.modificar = true;
                F1.codPrvMod = DTG_Lista[0, DTG_Lista.SelectedRows[0].Index].Value.ToString();
                F1.ShowDialog();
                if (F1.actualizar)
                {
                    ActualizarGrid();
                }
            }
        }

        private void FRM_Proveedor_Lista_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        #endregion
    }
}
