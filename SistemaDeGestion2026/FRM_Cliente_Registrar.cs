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
    public partial class FRM_Cliente_Registrar : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
        private aclient cliente = new aclient();
        private aperson persona = new aperson();
        public bool personaOK = false;
        private xnumcor correlativo = new xnumcor();
        public bool modificar = false;
        public String codCliMod = "";
        public bool actualizar = false;
        #endregion

        #region Constructor
        public FRM_Cliente_Registrar()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
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
            

        }

        private void JalarDatos()
        {
            cliente.faclcodper = this.codCliMod;
            cliente.ObtenerDatos();
            persona.papscodper = cliente.faclcodper;
            persona.ObtenerDatos();

            SWB_Estado.Value = cliente.caclestcli;
            TXT_RazonSocial.Text = cliente.caclrazcli;
            TXT_NIT.Text = cliente.caclnitcli;
            TXT_Direccion.Text = cliente.cacldircli;
            TXT_Telefono.Text = cliente.cacltelcli;


            TXT_CodigoPersona.Text = cliente.faclcodper;
            TXT_Nombre.Text = persona.capsapepat + " " + persona.capsapemat + " " + persona.capsnomper;
          

        }
        #endregion

        #region Eventos
        private void BTN_BuscarUsuario_Click(object sender, EventArgs e)
        {
            FRM_Persona_Buscar a = new FRM_Persona_Buscar();
            a.condicion = "papscodper not in (select papscodper from aperson,aclient where papscodper=faclcodper order by papscodper)";
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
        #endregion

        private void BTN_Grabar_Click(object sender, EventArgs e)
        {
            if (VerificarIntegridad())
            {
 

                cliente.caclestcli = SWB_Estado.Value;
                cliente.caclnitcli = TXT_NIT.Text;
                cliente.caclrazcli = TXT_RazonSocial.Text;
                cliente.cacldircli = TXT_Direccion.Text;   
                cliente.cacltelcli = TXT_Telefono.Text;

                cliente.faclcodper = TXT_CodigoPersona.Text;



                if (!this.modificar)
                {
                    if (cliente.Grabar())
                    {
                        MessageBox.Show("Cliente guardado correctamente!!",
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cliente no se pudo guardar!!",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (cliente.Modificar())
                    {
                        MessageBox.Show("Cliente modificado correctamente!!",
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                       
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cliente no se pudo modificar!!",
                                            "Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void FRM_Cliente_Registrar_Load(object sender, EventArgs e)
        {
            if (this.modificar)
            {
                JalarDatos();
                BTN_Grabar.Text = "&Modificar";
                this.Text = "Modificar Cliente";
                GP_Panel_Usuario.Text = "Modificar Cliente";
                TXT_NIT.Focus();
            }
            else
            {
                LimpiarCasillas();
                BTN_Grabar.Text = "&Guardar";
                this.Text = "Registrar Cliente";
                GP_Panel_Usuario.Text = "Registrar Cliente";
                TXT_NIT.Focus();
            }
        }
    }
}
