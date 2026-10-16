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
    public partial class FRMCliente_Buscar : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
        public aclient cliente = new aclient();
        private List<aclient> lista = new List<aclient>();
        public bool seleccionadoOK = false;

        public String condicion = "";
        #endregion

        #region Constructor
        public FRMCliente_Buscar()
        {
            InitializeComponent();
        }

        #endregion

        #region Metodos
        private void ActualizarGrid()
        {
            DTG_Lista.Rows.Clear();
            lista.Clear();
            lista = cliente.Lista("(caclrazcli like '%" + TXT_Filtrar.Text + "%' or " +
                                            "caclnitcli like '%" + TXT_Filtrar.Text + "%' or " +
                                            "cacldircli like '%" + TXT_Filtrar.Text + "%' or " +
                                            "cacltelcli like '%" + TXT_Filtrar.Text + "%') and caclestcli=true limit " +
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
                DTG_Lista[0, DTG_Lista.Rows.Count - 1].Value = a.paclcodcli;

                DTG_Lista[1, DTG_Lista.Rows.Count - 1].Value = a.caclrazcli;
                DTG_Lista[2, DTG_Lista.Rows.Count - 1].Value = a.caclnitcli;

                DTG_Lista[3, DTG_Lista.Rows.Count - 1].Value = a.cacldircli;
                DTG_Lista[4, DTG_Lista.Rows.Count - 1].Value = a.cacltelcli;


            }

        }
        #endregion

        #region Eventos

        #endregion

        private void FRMClienteBuscar_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void TXT_Filtrar_TextChanged(object sender, EventArgs e)
        {
            TXT_Filtrar.SelectAll();
        }

        private void BTN_Buscar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void DTG_Lista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DTG_Lista.SelectedRows.Count > 0)
            {
                cliente.paclcodcli = DTG_Lista[0, DTG_Lista.SelectedRows[0].Index].Value.ToString();
                if (cliente.ObtenerDatos())
                {
                    seleccionadoOK = true;
                    this.Close();
                }

            }
        }

        private void BTN_Okey_Click(object sender, EventArgs e)
        {
            if (DTG_Lista.SelectedRows.Count > 0)
            {
                cliente.paclcodcli = DTG_Lista[0, DTG_Lista.SelectedRows[0].Index].Value.ToString();
                if (cliente.ObtenerDatos())
                {
                    seleccionadoOK = true;
                    this.Close();
                }
            }
        }

        private void BTN_AgregarCliente_Click(object sender, EventArgs e)
        {
            FRMCliente_Registrar a = new FRMCliente_Registrar();
            a.ShowDialog();
            if (a.actualizar)
            {
                ActualizarGrid();
            }
        }
    }
}