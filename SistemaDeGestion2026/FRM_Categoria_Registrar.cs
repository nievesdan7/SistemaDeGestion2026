using CapaRN;
using SistemaDeGestion2026.Properties;
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
    public partial class FRM_Categoria_Registrar : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
        private xnumcor correlativo = new xnumcor();
        private acatpro tabla = new acatpro();
        public String codTabMod = "";

        public bool modificar = false;
        public bool actualizar = false;

        private String nombreMin = "categoría";
        private String nombreMas = "Categoría";
        #endregion

        #region Constructor
        public FRM_Categoria_Registrar()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        private bool VerificarIntegridad()
        {
            bool respuesta = true;

            if (TXT_NombreCategoria.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el nombre de "+nombreMin, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_NombreCategoria.Focus();
                respuesta = false;
            }

            acatpro tabla2 = new acatpro();
            tabla2.cacpnomcat = TXT_NombreCategoria.Text;

            
            if (tabla2.ObtenerDatosNombre(modificar, tabla.cacpnomcat))
            {
                MessageBox.Show("Ya existe una "+nombreMin+" con ese nombre", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_NombreCategoria.Focus();
                respuesta = false;
            }



            return respuesta;
        }

        private void LimpiarCasillas()
        {
            SWB_Estado.Value = true;
            TXT_NombreCategoria.Text = "";
        }

        private void JalarDatos()
        {
            tabla.pacpcodcat = this.codTabMod;
            tabla.ObtenerDatos();

            SWB_Estado.Value = tabla.cacpestcat;
            TXT_NombreCategoria.Text = tabla.cacpnomcat;
            
        }

        #endregion

        #region Eventos

        #endregion

        private void BTN_Grabar_Click(object sender, EventArgs e)
        {
            if (VerificarIntegridad())
            {
  
                tabla = new acatpro();

                if (!this.modificar)
                {
                    correlativo.pxnctipcor = "acatpro";

                    if (correlativo.ObtenerSiguiente())
                    {
                        tabla.pacpcodcat = correlativo.pxnctipcor + "-" + correlativo.cxncnumcor.ToString("D5");
                    }
                }
                else
                {
                    tabla.pacpcodcat = this.codTabMod;
                }
                tabla.cacpestcat = SWB_Estado.Value;
                tabla.cacpnomcat = TXT_NombreCategoria.Text.Trim();



                if (!this.modificar)
                {
                    if (tabla.Grabar())
                    {
                        MessageBox.Show("Categoría guardada correctamente!!",
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Categoría no se pudo guardar!!",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (tabla.Modificar())
                    {
                        MessageBox.Show("Categoria modificada correctamente!!",
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Categoría no se pudo modificar!!",
                                            "Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void BTN_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FRM_Categoria_Load(object sender, EventArgs e)
        {
            if (this.modificar)
            {
                JalarDatos();
                BTN_Grabar.Text = "&Modificar";
                this.Text = "Modificar Categoria";
                GP_Panel_Categoria.Text = "Modificar Categoria";
                TXT_NombreCategoria.Focus();
            }
            else
            {
                LimpiarCasillas();
                BTN_Grabar.Text = "&Agregar";
                BTN_Grabar.Image = Resources.ic_agregar;
                this.Text = "Registrar Categoria";
                GP_Panel_Categoria.Text = "Registrar Categoria";
                TXT_NombreCategoria.Focus();
            }
        }
    }
}
