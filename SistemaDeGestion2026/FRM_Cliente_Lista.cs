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
    public partial class FRM_Cliente_Lista : DevComponents.DotNetBar.Office2007Form
    {

        #region Variable
        
        private aclient cliente = new aclient();
        private List<aclient> lista = new List<aclient>();
        
        #endregion

        public FRM_Cliente_Lista()
        {
            InitializeComponent();
        }

        #region Metodos

        private void ActualizarGrid()
        {
            DTG_Lista.Rows.Clear();
            lista.Clear();
            lista = cliente.Lista("(caclrazcli like '%" + TXT_Filtrar.Text + "%' or " +
                                            "caclnitcli like '%" + TXT_Filtrar.Text + "%' or " +
                                            "cacldircli like '%" + TXT_Filtrar.Text + "%' or " +
                                            "cacltelcli like '%" + TXT_Filtrar.Text + "%') limit " +
                                           IIN_Filas.Value.ToString()
                                           );
            
            foreach (aclient a in lista)
            {
                DTG_Lista.Rows.Add();

                if (a.caclestcli)
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
                DTG_Lista[0, DTG_Lista.Rows.Count - 1].Value = a.faclcodper;
                DTG_Lista[1, DTG_Lista.Rows.Count - 1].Value = a.caclestcli;
                DTG_Lista[2, DTG_Lista.Rows.Count - 1].Value = a.caclrazcli;
                DTG_Lista[3, DTG_Lista.Rows.Count - 1].Value = a.caclnitcli;
                                                               
                DTG_Lista[4, DTG_Lista.Rows.Count - 1].Value = a.cacldircli;
                DTG_Lista[5, DTG_Lista.Rows.Count - 1].Value = a.cacltelcli;


            }

        }

        
        #endregion

        private void BTN_Registrar_Click(object sender, EventArgs e)
        {
            FRM_Cliente_Registrar F1 = new FRM_Cliente_Registrar();
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
                FRM_Cliente_Registrar F1 = new FRM_Cliente_Registrar();
                F1.modificar = true;
                F1.codCliMod = DTG_Lista[0, DTG_Lista.SelectedRows[0].Index].Value.ToString();
                F1.ShowDialog();
                if (F1.actualizar)
                {
                    ActualizarGrid();
                }
            }
        }

        private void FRM_Cliente_Lista_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }
    }
}
