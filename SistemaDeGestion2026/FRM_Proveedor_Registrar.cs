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
    public partial class FRM_Proveedor_Registrar : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
        private aprovee proveedor = new aprovee();
        private aperson persona = new aperson();
        public bool personaOK = false;
        private xnumcor correlativo = new xnumcor();
        public bool modificar = false;
        public String codPrvMod = "";
        public bool actualizar = false;
        #endregion

        #region Constructor
        public FRM_Proveedor_Registrar()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos
        private bool VerificarIntegridad()
        {
            bool respuesta = true;


            if (TXT_NIT.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el NIT", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_NIT.Focus();
                respuesta = false;
            }
            else if (TXT_RazonSocial.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca la Razón Social", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_RazonSocial.Focus();
                respuesta = false;
            }
            else if (TXT_Direccion.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca la dirección", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_Direccion.Focus();
                respuesta = false;
            }
            else if (TXT_Telefono.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el teléfono", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_Telefono.Focus();
                respuesta = false;
            }
            else if (TXT_Nombre.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("No seleccionó una persona", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_Telefono.Focus();
                respuesta = false;
            }



            return respuesta;
        }

        private void LimpiarCasillas()
        {
            SWB_Estado.Value = true;
            TXT_RazonSocial.Text = "";
            TXT_NIT.Text = "";
            TXT_Direccion.Text = "";
            TXT_Telefono.Text = "";

            TXT_CodigoPersona.Text = "";
            TXT_Nombre.Text = "";
        }

        private void JalarDatos()
        {

            persona.papscodper = this.codPrvMod;
            persona.ObtenerDatos();

            proveedor.fapvcodper = this.codPrvMod;
            proveedor.ObtenerDatos();

            SWB_Estado.Value = proveedor.capvestprv;
            TXT_RazonSocial.Text = proveedor.capvrazprv;
            TXT_NIT.Text = proveedor.capvnirprv;
            TXT_Direccion.Text = proveedor.capvdirprv;
            TXT_Telefono.Text = proveedor.capvtelprv;


            TXT_CodigoPersona.Text = persona.papscodper;
            TXT_Nombre.Text = persona.capsapepat + " " + persona.capsapemat + " " + persona.capsnomper;


        }
        #endregion

        #region Eventos
        private void BTN_Grabar_Click(object sender, EventArgs e)
        {
            if (VerificarIntegridad())
            {


                proveedor.capvestprv = SWB_Estado.Value;
                proveedor.capvnirprv = TXT_NIT.Text;
                proveedor.capvrazprv = TXT_RazonSocial.Text;
                proveedor.capvdirprv = TXT_Direccion.Text;
                proveedor.capvtelprv = TXT_Telefono.Text;





                if (!this.modificar)
                {
                    proveedor.fapvcodper = TXT_CodigoPersona.Text;
                    if (proveedor.Grabar2())
                    {
                        MessageBox.Show("Proveedor guardado correctamente!!",
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Proveedor no se pudo guardar!!",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (proveedor.Modificar2(TXT_CodigoPersona.Text))
                    {
                        MessageBox.Show("Proveedor modificado correctamente!!",
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Proveedor no se pudo modificar!!",
                                            "Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void BTN_Limpiar_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_BuscarUsuario_Click(object sender, EventArgs e)
        {
            FRM_Persona_Buscar a = new FRM_Persona_Buscar();
            a.condicion = "papscodper not in (select papscodper from aperson,aprovee where papscodper=fapvcodper order by papscodper)";
            a.ShowDialog();
            if (a.seleccionadoOK)
            {
                this.persona = a.persona;
                this.personaOK = true;

                TXT_Nombre.Text = persona.capsapepat + " " + persona.capsapemat + " " + persona.capsnomper;
                TXT_CodigoPersona.Text = persona.papscodper;
            }
            else
            {
                this.personaOK = false;
                TXT_Nombre.Text = "Persona";

            }
        }

        private void FRM_Proveedor_Registrar_Load(object sender, EventArgs e)
        {
            if (this.modificar)
            {
                JalarDatos();
                BTN_Grabar.Text = "&Modificar";
                this.Text = "Modificar Proveedor";
                GP_Panel_Usuario.Text = "Modificar Proveedor";
                TXT_NIT.Focus();
            }
            else
            {
                LimpiarCasillas();
                BTN_Grabar.Text = "&Guardar";
                this.Text = "Registrar Proveedor";
                GP_Panel_Usuario.Text = "Registrar Proveedor";
                TXT_NIT.Focus();
            }
        }
        #endregion

    }
}
