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

        private String descripcion = "";
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

            if (TXT_Nompro.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el nombre del producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_Nompro.Focus();
                respuesta = false;
            }
            else if (TXT_Marca.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca la marca del producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_Marca.Focus();
                respuesta = false;
            }
            
            else if (TXT_Talla.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca la talla del producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_Talla.Focus();
                respuesta = false;
            }
            else if (COMBOCategoria.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Elija una categoría para el producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                COMBOCategoria.Focus();
                respuesta = false;
            }
            else if (TXT_Modelo.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el modelo del producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_Modelo.Focus();
                respuesta = false;
            }
            else if (TXT_Material.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el material del producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_Material.Focus();
                respuesta = false;
            }
            else if (TXT_Genero.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el género del producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_Genero.Focus();
                respuesta = false;
            }
            else if (TXTCodigoBarras.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el codigo de barras del producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTCodigoBarras.Focus();
                respuesta = false;
            }
            else if (TXT_Descripcion.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca la descripción del producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_Descripcion.Focus();
                respuesta = false;
            }
            return respuesta;
        }
        private void LimpiarCasillas()
        {
            SWB_Estado.Value = true;
            TXT_Nompro.Text = "";
            COMBOCategoria.Text = "";
        }
        private void JalarDatosCOMBOCategoria()
        {
            producto.papdcodpro = this.codProMod;
            producto.ObtenerDatos();
            

               try
                {
                    List<acatpro> listaCategorias = categoria.Lista("");
                    COMBOCategoria.DataSource = listaCategorias;
                    COMBOCategoria.DisplayMember = "cacpnomcat";
                    COMBOCategoria.ValueMember = "pacpcodcat";
                    COMBOCategoria.Text = producto.fapdcodcat;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las categorías: " + ex.Message,
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            
            
           

        }
        private void JalarDatos()
        {
            producto.papdcodpro = this.codProMod;
            producto.ObtenerDatos();

            SWB_Estado.Value = producto.capdestpro;
            TXT_Nompro.Text = producto.capdnompro;
            

                try
                {
                    List<acatpro> listaCategorias = categoria.Lista("");
                   
                    COMBOCategoria.DisplayMember = "cacpnomcat";
                    COMBOCategoria.ValueMember = "pacpcodcat";
                    COMBOCategoria.DataSource = listaCategorias;

                    COMBOCategoria.SelectedValue = producto.fapdcodcat;
            }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las categorías: " + ex.Message,
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }

            
            TXT_Marca.Text = producto.capdmarpro;
            TXT_Talla.Text = producto.capdtalpro;
            TXT_Modelo.Text = producto.capdmodpro;
            TXT_Material.Text = producto.capdmatpro;
            TXT_Genero.Text = producto.capdgenpro;
            DOUBLE_PrecioVenta.Value = (double)producto.capdpreven;
            DOUBLE_PrecioMinimo.Value = (double)producto.capdpremin;
            TXT_Color.Text = producto.capdcolpro;
            TXTCodigoBarras.Text = producto.capdcodbar;
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
            IniciarCamara();
            if (this.modificar)
            {
                JalarDatos();
                BTN_Grabar.Text = "&Modificar";
                this.Text = "Modificar Producto";
                GP_Panel_Producto.Text = "Modificar Producto";
                TXT_Nompro.Focus();
            }
            else
            {
                LimpiarCasillas();
                JalarDatosCOMBOCategoria();
                BTN_Grabar.Text = "&Guardar";
                this.Text = "Registrar Producto";
                GP_Panel_Producto.Text = "Registrar Producto";
                TXT_Nompro.Focus();
                
            }
        }       
        private void BTN_Salir_Click(object sender, EventArgs e)
        {
            Close();
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
                producto.capdnompro = TXT_Nompro.Text;
                producto.fapdcodcat = COMBOCategoria.SelectedValue.ToString();
                producto.capdmarpro = TXT_Marca.Text;
                producto.capdmodpro = TXT_Modelo.Text;
                producto.capdtalpro = TXT_Talla.Text;
                producto.capdmatpro = TXT_Material.Text;
                producto.capdgenpro = TXT_Genero.Text;
                producto.capdcolpro = TXT_Color.Text;
                producto.capdpreven = (decimal)DOUBLE_PrecioVenta.Value;
               
                producto.capdcodbar = TXTCodigoBarras.Text;
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
            JalarDatosCOMBOCategoria();


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

        private void TXT_Nompro_TextChanged(object sender, EventArgs e)
        {
            descripcion = "";
            if (TXT_Nompro.Text.Replace(" ", "") != "") {
                descripcion += TXT_Nompro.Text;
                if (TXT_Marca.Text.Replace(" ", "") != "")
                {
                    descripcion += ", Marca  " + TXT_Marca.Text;
                    if (TXT_Talla.Text.Replace(" ", "") != "")
                    {
                        descripcion += ", Talla " + TXT_Talla.Text;
                        if (TXT_Modelo.Text.Replace(" ", "") != "")
                        {
                            descripcion += ", Modelo " + TXT_Modelo.Text;
                            if (TXT_Material.Text.Replace(" ", "") != "")
                            {
                                descripcion += ", Material " + TXT_Material.Text;
                                if (TXT_Color.Text.Replace(" ", "") != "")
                                {
                                    descripcion += ", Color " + TXT_Color.Text;
                                    if (TXT_Genero.Text.Replace(" ", "") != "")
                                    {
                                        descripcion += ", Género " + TXT_Genero.Text;
                                    }
                                }
                            }
                        }
                    }
                }
                
            }
            
            TXT_Descripcion.Text = descripcion;
        }
    }
}
