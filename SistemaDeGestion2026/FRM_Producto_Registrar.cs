using AForge.Video;
using AForge.Video.DirectShow;
using CapaRN;
using DevComponents.DotNetBar.Controls;
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
    public partial class FRM_Producto_Registrar : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
        private aproduc producto = new aproduc();
        private acatpro categoria = new acatpro();
        private xnumcor correlativo = new xnumcor();
        public bool modificar = false;
        public String codProMod = "";

        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        public bool actualizar = false;
        private bool TieneFoto = false;

        public Boolean lectorHabilitado = false;
        #endregion

        #region Constructor
        public FRM_Producto_Registrar()
        {
            InitializeComponent();
            DetectarCamaras();
         
        }
        #endregion

        #region Metodos

        private bool VerificarIntegridad()
        {

        
            bool respuesta = true;
            
            if (LBLCodigoBarras.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Registre un código de barras", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LBLCodigoBarras.Focus();
                respuesta = false;
            }
            else if (TXT_Modelo.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el modelo", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_Modelo.Focus();
                respuesta = false;
            }
            
            else if (CMBGenero.SelectedIndex==-1)
            {
                MessageBox.Show("Seleccione un género", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMBGenero.Focus();
                respuesta = false;
            }
            else if (CMBCategoria.SelectedIndex==-1)
            {
                MessageBox.Show("Elija una categoría", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMBCategoria.Focus();
                respuesta = false;
            }
            else if (CMBNombreProducto.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el nombre del producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMBNombreProducto.Focus();
                respuesta = false;
            }
            else if (CMBMarca.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca la marca", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMBMarca.Focus();
                respuesta = false;
            }
            else if (CMBMaterial.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el material", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMBMaterial.Focus();
                respuesta = false;
            }
            else if (CMBColor.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el color", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMBColor.Focus();
                respuesta = false;
            }
            else if (CMBTalla.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca la talla", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMBTalla.Focus();
                respuesta = false;
            }
            else if (TXT_Descripcion.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca la descripción", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_Descripcion.Focus();
                respuesta = false;
            }

            return respuesta;
        }
        private void LimpiarCasillas()
        {
            SWB_Estado.Value = true;
            LBLCodigoBarras.Text = "";
            TXT_Modelo.Text= "";
            CMBGenero.SelectedIndex = -1;
            CMBCategoria.SelectedIndex = -1;

            CMBNombreProducto.Text = "";
            CMBMarca.Text = "";
            CMBMaterial.Text = "";
            CMBColor.Text = "";
            CMBTalla.Text = "";
            INTStock.Value = 0;
            DINPrecioVenta.Value = 0.00;
            DINPrecioMinimo.Value = 0.00;
            TXT_Descripcion.Text = "";
        }
        private void CargarCombo(String campo, ComboBox combo)
        {
            
            try
            {
                List<String> listaNombreProducto = producto.Combo(campo);
                combo.Items.Clear();
                combo.DisplayMember = campo;

                combo.DataSource = listaNombreProducto;
                combo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los combos",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            



        }
        private void CargarComboCategorias()
        {
            List<acatpro> listaCategorias = categoria.Lista("cacpestcat = true order by cacpnomcat");            
            CMBCategoria.Items.Clear();
            CMBCategoria.DisplayMember = "cacpnomcat";
            CMBCategoria.ValueMember = "pacpcodcat";
            CMBCategoria.DataSource = listaCategorias;
            CMBCategoria.SelectedIndex = -1;
            

        }
        private void JalarDatos()
        {
            producto.papdcodpro = this.codProMod;
            producto.ObtenerDatos();

            SWB_Estado.Value = producto.capdestpro;
            LBLCodigoBarras.Text = producto.capdcodbar;
            TXT_Modelo.Text = producto.capdmodpro;            
            CMBGenero.Text = producto.capdgenpro;
            CMBCategoria.SelectedValue = producto.fapdcodcat;
            CMBNombreProducto.Text = producto.capdnompro;
            CMBMarca.Text = producto.capdmarpro;
            CMBMaterial.Text = producto.capdmatpro;
            CMBColor.Text = producto.capdcolpro;
            CMBTalla.Text = producto.capdtalpro;
            INTStock.Value = producto.capdstopro;
            DINPrecioVenta.Value = (double)producto.capdpreven;
            DINPrecioMinimo.Value = (double)producto.capdpremin;                       
            TXT_Descripcion.Text = producto.capddespro;
            

            if (producto.capdfotpro == " ")
            {
                TieneFoto = false;
                PCB_Fotografía.Image = Resources.NoImagen;
            }
            else
            {
                TieneFoto = true;
                PCB_Fotografía.Image = MetodosGenerales.ConvertBase64StringToImage(producto.capdfotpro);
            }

        }

        #endregion


        #region Eventos

        private void FRM_Producto_Registrar_Load(object sender, EventArgs e)
        {           
            CargarComboCategorias();
            CargarCombo("capdnompro", CMBNombreProducto);
            CargarCombo("capdmarpro", CMBMarca);
            CargarCombo("capdmatpro", CMBMaterial);
            CargarCombo("capdcolpro", CMBColor);
            CargarCombo("capdtalpro", CMBTalla);
            IniciarCamara();
            if (this.modificar)
            {
                JalarDatos();
                BTN_Grabar.Text = "&Modificar";
                this.Text = "Modificar Producto";
                GP_Panel_Producto.Text = "Modificar Producto";
                SWB_Estado.Focus();
            }
            else
            {
                LimpiarCasillas();
                BTN_Grabar.Text = "&Guardar";
                this.Text = "Registrar Producto";
                GP_Panel_Producto.Text = "Registrar Producto";
                SWB_Estado.Focus();
                
            }
        }
        private void BTN_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCasillas();
        }
        private void BTN_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }        
        private void BTN_Grabar_Click(object sender, EventArgs e)
        {
            if (VerificarIntegridad())
            {
                producto = new aproduc();

                if (!this.modificar)
                {
                    //Generar el correlativo
                    correlativo.pxnctipcor = "aproduc";
                    if (correlativo.ObtenerSiguiente())
                    {
                        producto.papdcodpro = correlativo.pxnctipcor + "-" + correlativo.cxncnumcor.ToString("D5");

                        producto.capdpreven = 0.00m;
                        producto.capdpremin = 0.00m;
                        producto.capdfeccre = DateTime.Now; 
                        producto.capdfotpro = " ";
                        producto.capdstopro = 0;
                    }
                    else
                    {
                        MessageBox.Show("No se obtuvo correlativo",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    producto.papdcodpro = this.codProMod;
                    
                }

                producto.capdestpro = SWB_Estado.Value;
                producto.capdnompro = CMBNombreProducto.Text;
                producto.fapdcodcat = CMBCategoria.SelectedValue.ToString();
                producto.capdmarpro = CMBMarca.Text;
                producto.capdmodpro = TXT_Modelo.Text;
                producto.capdtalpro = CMBTalla.Text;
                producto.capdmatpro = CMBMaterial.Text;
                producto.capdgenpro = CMBGenero.Text;
                producto.capdcolpro = CMBColor.Text;
                               
                producto.capdcodbar = LBLCodigoBarras.Text;
                producto.capddespro = TXT_Descripcion.Text;
                producto.capdfecmod = DateTime.Now;



                //Fotografia del producto
                if (TieneFoto)
                {
                    producto.capdfotpro = MetodosGenerales.ConvertImageToBase64String(PCB_Fotografía.Image);
                }
                else
                {
                    producto.capdfotpro = " ";
                }




                if (!this.modificar)
                {
                    if (producto.Grabar())
                    {
                        MessageBox.Show("Producto guardado correctamente!!",
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRM_Producto_Registrar_FormClosing;
                        ApagarCamara();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Producto no se pudo guardar!!",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (producto.Modificar2())
                    {
                        MessageBox.Show("Producto modificado correctamente!!",
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRM_Producto_Registrar_FormClosing;
                        ApagarCamara();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Producto no se pudo modificar!!",
                                            "Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                    }
                }
            }
        }
        private void BTN_AgregarCategoria_Click(object sender, EventArgs e)
        {
            FRM_Categoria_Registrar a = new FRM_Categoria_Registrar();   
            a.ShowDialog();
            CargarComboCategorias();


        }
        private void TXT_Nompro_TextChanged(object sender, EventArgs e)
        {
            String descripcion = "";
            if (CMBNombreProducto.Text.Replace(" ", "") != "") 
            {
                descripcion += CMBNombreProducto.Text;

                if (CMBGenero.Text.Replace(" ", "") != "")
                {
                    descripcion += " - GÉNERO: " + CMBGenero.Text;

                    if (CMBMarca.Text.Replace(" ", "") != "")
                    {
                        descripcion += " - MARCA: " + CMBMarca.Text;

                        if (CMBColor.Text.Replace(" ", "") != "")
                        {
                            descripcion += " - COLOR: " + CMBColor.Text;

                            if (CMBTalla.Text.Replace(" ", "") != "")
                            {
                                descripcion += " - TALLA: " + CMBTalla.Text;

                            }
                        }
                    }
                }                
            }
            
            TXT_Descripcion.Text = descripcion;
        }
        private void BTNCodigoBarras_Click(object sender, EventArgs e)
        {
            if (!lectorHabilitado)
            {
                lectorHabilitado = true;
                LBLCodigoBarras.Text = "LECTOR ACTIVO";
                LBLCodigoBarras.BackColor = Color.PaleGreen;
            }
            else
            {
                if (LBLCodigoBarras.Text == "LECTOR ACTIVO")
                {
                    LBLCodigoBarras.Text = "SIN CODIGO";
                    LBLCodigoBarras.BackColor = Color.Salmon;
                }
                else
                {
                    LBLCodigoBarras.BackColor = Color.LightBlue;
                }
                lectorHabilitado = false;
                TXT_Modelo.Focus();
            }
        }
        private void BTNCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (LBLCodigoBarras.Text == "LECTOR ACTIVO")
            {
                LBLCodigoBarras.Text = "" + e.KeyChar;
            }
            else
            {
                LBLCodigoBarras.Text += e.KeyChar;
            }

        }
        private void FRM_Producto_Registrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar el formulario?",
                                "Pregunta",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                ApagarCamara();
            }
        }

        #endregion

        #region Metodos de la cámara

        private void DetectarCamaras()
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);//constructor            
            FinalFrame = new VideoCaptureDevice();
        }
        private void IniciarCamara()
        {
            try
            {
                FinalFrame = new VideoCaptureDevice(CaptureDevice[0].MonikerString);// specified web cam and its filter moniker string
                FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);// click button event is fired, 
                FinalFrame.Start();
            }
            catch
            {
                MessageBox.Show("No se detectó ninguna cámara web en el sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs) // must be void so that it can be accessed everywhere.
                                                                             // New Frame Event Args is an constructor of a class
        {
            PCB_Camara.Image = (Bitmap)eventArgs.Frame.Clone();// clone the bitmap

        }
        private void ApagarCamara()
        {
            if (FinalFrame.IsRunning == true) FinalFrame.Stop();
        }

        #endregion

        #region Eventos de la cámara

        private void BTN_CamaraCapturar_Click(object sender, EventArgs e)
        {
            PCB_Fotografía.Image = PCB_Camara.Image;
            TieneFoto = true;
        }
        private void BTN_AbrirFoto_Click(object sender, EventArgs e)
        {
            if (OFDElegirImagen.ShowDialog() == DialogResult.OK)
            {
                PCB_Fotografía.ImageLocation = OFDElegirImagen.FileName;
                TieneFoto = true;
            }
        }
        private void BTN_LimpiarFoto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea borrar la imagen?",
                           "Pregunta",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                TieneFoto = false;
                PCB_Fotografía.Image = Resources.gif_no_imagen;
            }
        }
        private void BTN_CapturarFoto_Click(object sender, EventArgs e)
        {
            PCB_Fotografía.Image = PCB_Camara.Image;
            TieneFoto = true;
        }


        #endregion

       
    }
}
