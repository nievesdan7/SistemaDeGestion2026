using AForge.Video.DirectShow;
using CapaRN;
using DevComponents.DotNetBar.Controls;
using QRCoder;
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
    public partial class FRMVenta_Registrar : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
        private avenpro venta = new avenpro();
        private aiteven item = new aiteven();
        private xnumcor correlativo = new xnumcor();
        public aususis usuario = new aususis();
        public bool actualizar = false;
        public bool modificar = false;
        private aclient cliente = new aclient();
        private bool clienteOK = false;
        private bool productoOK = false;
        private bool lectorHabilitado = false;
        public aproduc producto = new aproduc();
        private liteven itemModificar = new liteven();
        private bool modificarItem = false;
        private List<liteven> listaItems = new List<liteven>();
        private double total = 0;
        public string CodVenMod= "";

        #endregion

        #region Constructor
        public FRMVenta_Registrar()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        private void ActualizarGridItems()
        {
            DTGLista.Rows.Clear();


            foreach (liteven a in listaItems)
            {
                DTGLista.Rows.Add();

                DTGLista[0, DTGLista.Rows.Count - 1].Value = a.faivcodpro;
                DTGLista[1, DTGLista.Rows.Count - 1].Value = a.capdmodpro;
                DTGLista[2, DTGLista.Rows.Count - 1].Value = a.capdcodbar;
                DTGLista[3, DTGLista.Rows.Count - 1].Value = a.capdnompro;
                DTGLista[4, DTGLista.Rows.Count - 1].Value = a.capdtalpro;
                DTGLista[5, DTGLista.Rows.Count - 1].Value = a.capddespro;
                DTGLista[6, DTGLista.Rows.Count - 1].Value = a.caivcanite;
                DTGLista[7, DTGLista.Rows.Count - 1].Value = a.caivpreuni;
                DTGLista[8, DTGLista.Rows.Count - 1].Value = a.caivsubtot;

            }
        }
        private void AgregarItem(aproduc pro)
        {

            liteven item = new liteven();
            item = listaItems.Find(x => x.faivcodpro == pro.papdcodpro);

            if (item != null)
            {
                if ((pro.capdstopro - item.caivcanite) > 0)
                {
                    item.caivcanite += 1;
                    item.caivsubtot = item.caivpreuni * item.caivcanite;
                }
                else
                {
                    MessageBox.Show("No hay suficiente stock para agregar el producto", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (pro.capdstopro > 0)
                {
                    item = new liteven();
                    item.faivcodpro = pro.papdcodpro;
                    item.capdmodpro = pro.capdmodpro;
                    item.capdcodbar = pro.capdcodbar;
                    item.capdnompro = pro.capdnompro;
                    item.capdtalpro = pro.capdtalpro;
                    item.capddespro = pro.capddespro;
                    item.caivcanite = 1;
                    item.caivpreuni = pro.capdpreven;
                    item.capdstopro = pro.capdstopro;
                    item.caivsubtot = item.caivpreuni * item.caivcanite;
                    item.caivestite = true;
                    listaItems.Add(item);
                }
                else
                {
                    MessageBox.Show("No hay suficiente stock para agregar el producto", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            ActualizarGridItems();
            ActualizarTotal();

        }
        private void ActualizarTotal()
        {
            total = 0;
            foreach (liteven item in listaItems)
            {
                total += (double)item.caivsubtot;
            }
            LBLTotalNumeral.Text = "Total: " + total.ToString("N2");
            LBLTotalLiteral.Text = MetodosGenerales.ConvertirNumeroALetras(total).ToUpper();


        }
        private void LimpiarCasillas()
        {
            TXTNIT.Text = "";
            TXTNombreCliente.Text = "";
            clienteOK = false;
            DTGLista.Rows.Clear();
            TXTObservaciones.Text = "";

        }
        
        #endregion

        #region Eventos
        private void TXTNIT_Leave(object sender, EventArgs e)
        {
            cliente.caclnitcli = TXTNIT.Text;
            if (cliente.ObtenerDatosNIT())
            {
                TXTNombreCliente.Text = cliente.caclrazcli;
                clienteOK = true;
            }
            else
            {
                TXTNombreCliente.Text = "";
                clienteOK = false;
            }
        }
        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            FRMCliente_Buscar a = new FRMCliente_Buscar();

            // a.condicion = "papscodper not in (select papscodper from aperson,aususis where papscodper=fauscodper order by papscodper)";
            a.ShowDialog();
            if (a.seleccionadoOK)
            {
                this.cliente = a.cliente;
                this.clienteOK = true;
                TXTNIT.Text = cliente.caclnitcli;
                TXTNombreCliente.Text = cliente.caclrazcli;

            }
            else
            {
                this.clienteOK = false;
                TXTNIT.Text = "";
                TXTNombreCliente.Text = "Nommbre del cliente";
            }
        }
        private void BTNCodigoBarras_Click(object sender, EventArgs e)
        {
            if (!lectorHabilitado)
            {
                lectorHabilitado = true;
                LBLCodigoBarras.Text = "LECTOR ACTIVO";
                LBLCodigoBarras.BackColor = Color.ForestGreen;
            }
            else
            {

                producto.capdcodbar = LBLCodigoBarras.Text;

                if (producto.ObtenerDatosCodigo(false, producto.capdcodbar))
                {
                    //MessageBox.Show("Producto encontrado: " + producto.capddespro, "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AgregarItem(producto);
                    lectorHabilitado = true;
                    LBLCodigoBarras.Text = "LECTOR ACTIVO";
                    LBLCodigoBarras.BackColor = Color.ForestGreen;
                }
                else
                {
                    MessageBox.Show("Producto no encontrado", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LBLCodigoBarras.Text = "LECTOR ACTIVO";
                    LBLCodigoBarras.BackColor = Color.ForestGreen;
                    BTNCodigoBarras.Focus();

                }

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
        private void FRMVenta_Registrar_Load(object sender, EventArgs e)
        {
            lectorHabilitado = false;
            LBLCodigoBarras.Text = "LECTOR INACTIVO";
            LBLCodigoBarras.BackColor = Color.Salmon;
            LBLCodigoBarras.ForeColor = Color.White;
            ActualizarGridItems();
            usuario.pauscodusu = FRM_Principal.codigoUsuario;
            usuario.ObtenerDatos();

        }
        private void BTNCodigoBarras_Leave(object sender, EventArgs e)
        {
            lectorHabilitado = false;
            LBLCodigoBarras.Text = "LECTOR INACTIVO";
            LBLCodigoBarras.BackColor = Color.Salmon;
            LBLCodigoBarras.ForeColor = Color.White;
        }
        private void BTNBuscarProducto_Click(object sender, EventArgs e)
        {
            FRMProducto_Buscar a = new FRMProducto_Buscar();
            a.ShowDialog();
            if (a.seleccionadoOK)
            {
                this.producto = a.producto;
                this.productoOK = true;
                AgregarItem(producto);
            }
            else
            {
                this.productoOK = false;

            }

        }
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Desea eliminar el item seleccionado?", "Eliminar item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string codItem = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                    liteven item = listaItems.Find(x => x.paivcodite == codItem);
                    if (item != null)
                    {
                        total -= (double)item.caivsubtot;
                        LBLTotalNumeral.Text = "Total: " + total.ToString("N2");
                        LBLTotalLiteral.Text = MetodosGenerales.ConvertirNumeroALetras(total).ToUpper();
                        listaItems.Remove(item);
                        ActualizarGridItems();
                    }
                }
            }
        }
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DTGLista_CellDoubleClick(sender, new DataGridViewCellEventArgs(0, DTGLista.SelectedRows[0].Index));
        }
        private void DTGLista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                eliminarToolStripMenuItem_Click(sender, e);
            }
        }
        private void DTGLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < listaItems.Count)
            {
                itemModificar = listaItems[e.RowIndex];

                if (itemModificar != null)
                {
                    modificarItem = true;

                    TXTDescripcion.Text = itemModificar.capddespro;
                    INTCantidad.Value = itemModificar.caivcanite;
                    DINPrecio.Value = (Double)itemModificar.caivpreuni;


                    producto.papdcodpro = itemModificar.faivcodpro;

                    if (producto.ObtenerDatos())
                    {
                        if (string.IsNullOrWhiteSpace(producto.capdfotpro))
                        {
                            PCBFoto.Image = Resources.NoImagen;
                        }
                        else
                        {
                            PCBFoto.Image = MetodosGenerales.ConvertBase64StringToImage(producto.capdfotpro);
                        }
                        DINPrecio.Enabled = true;
                        INTCantidad.Enabled = true;
                        TXTDescripcion.Enabled = true;

                    }
                }
            }
        }
        private void BTNModificarProducto_Click(object sender, EventArgs e)
        {
            if (INTCantidad.Value > producto.capdstopro)
            {
                MessageBox.Show(
                    "Cantidad insuficiente en Stock: " + producto.capdstopro + " existencias disponibles",
                    "STOCK",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                if (modificarItem)
                {
                    itemModificar.capddespro = TXTDescripcion.Text;
                    itemModificar.caivcanite = (int)INTCantidad.Value;
                    itemModificar.caivpreuni = (decimal)DINPrecio.Value;
                    itemModificar.caivsubtot = itemModificar.caivcanite * itemModificar.caivpreuni;
                    ActualizarGridItems();
                    ActualizarTotal();
                    BTNLimpiarProducto_Click(sender, e);

                }
            }
        }
        private void BTNLimpiarProducto_Click(object sender, EventArgs e)
        {
            TXTDescripcion.Text = "";
            DINPrecio.Value = 0;
            INTCantidad.Value = 0;
            DINPrecio.Enabled = false;
            INTCantidad.Enabled = false;
            TXTDescripcion.Enabled = false;
            modificarItem = false;
            PCBFoto.Image = Resources.NoImagen;

        }

        #endregion

        private void BTNGrabar_Click(object sender, EventArgs e)
        {
            List <aproduc> listaProductos = new List<aproduc>();
            listaProductos = listaItems.Select(x => new aproduc
            {
                papdcodpro = x.faivcodpro,
                capdmodpro = x.capdmodpro,
                capdcodbar = x.capdcodbar,
                capdnompro = x.capdnompro,
                capdtalpro = x.capdtalpro,
                capddespro = x.capddespro,
                capdstopro = x.capdstopro - x.caivcanite,
                capdpreven = x.caivpreuni
            }).ToList();
            

            if (VerificarIntegridad())
            {
                venta = new avenpro();
                correlativo.pxnctipcor = "avenpro";
                if (correlativo.ObtenerSiguiente())
                {
                    venta.pavpcodven = correlativo.pxnctipcor + "-" +
                                       correlativo.cxncnumcor.ToString("D12");
                }
                venta.cavpestven = SWB_Estado.Value;
                venta.cavpfeccre = DateTime.Now;
                venta.cavpfechor = DateTime.Now;
                venta.cavpfecmod = DateTime.Now;
                venta.cavpmontot = listaItems.Sum(x => x.caivsubtot);
                venta.cavpobsven = TXTObservaciones.Text;
                venta.favpcodcli = cliente.paclcodcli;
                venta.favpusucre = "aususis-000000000008";
                venta.favpusumod = "aususis-000000000008";
                         

                correlativo.pxnctipcor = "aiteven";
                if (correlativo.ObtenerSiguiente(listaItems.Count))
                {
                    correlativo.cxncnumcor -= listaItems.Count - 1;
                    foreach (liteven item in listaItems)
                    {

                        item.paivcodite = correlativo.pxnctipcor + "-" +
                                          correlativo.cxncnumcor.ToString("D12");
                        item.faivcodven = venta.pavpcodven;
                        correlativo.cxncnumcor++;
                    }

                }

                
                    if (venta.Grabar() && item.Grabar(listaItems) && producto.actualizarStock(listaProductos))
                    {
                        MessageBox.Show("Venta guardada correctamente!!",
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        
                        if(PDGDialogo.ShowDialog() == DialogResult.OK)
                        {
                            PRDRecibo.Print();
                        }
                        this.actualizar = true;
                        this.FormClosing -= FRMVenta_Registrar_FormClosing;
                        this.Close();
                        FRMVenta_Lista a= new FRMVenta_Lista();
                        a.ActualizarGrid();

                }
                    else
                    {
                        MessageBox.Show("Venta no se pudo guardar!!",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                

            }
        }

        private bool VerificarIntegridad()
        {
            bool respuesta = true;
            if(clienteOK == false)
            {
                MessageBox.Show("Debe seleccionar un cliente para la venta", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                respuesta = false;
            }
            else if (listaItems.Count == 0)
            {
                MessageBox.Show("Agregue al menos un producto a la venta", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                respuesta = false;
            }
            else if (total <= 0)
            {
                MessageBox.Show("El total de la venta debe ser mayor a cero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                respuesta = false;
            }
            

            return respuesta;
        }
        private void BTN_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCasillas(); 
        }
        private void FRMVenta_Registrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar el formulario?",
                               "Pregunta",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void PRDRecibo_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int inicioX = 10;
            int finalX = 290;
            int inicioY = 60;

            e.Graphics.DrawString("Nombre de la Empresa", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new PointF(inicioX + 20, inicioY));
            e.Graphics.DrawString("Teléfono: 123456789", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new PointF(inicioX + 20, inicioY + 20));
            e.Graphics.DrawString("Bermejo-Tarija-Bolivia", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new PointF(inicioX + 20, inicioY + 40));
            e.Graphics.DrawString("RECIBO DE VENTA", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(inicioX+20, inicioY+60));

            e.Graphics.DrawLine(Pens.Black, new Point(inicioX, inicioY+80), new Point(finalX, inicioY + 80));

            e.Graphics.DrawString("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy"), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new PointF(inicioX + 20, inicioY + 100));
            e.Graphics.DrawString("Hora: " + DateTime.Now.ToString("HH:mm:ss"), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new PointF(inicioX + 20, inicioY + 120));
            e.Graphics.DrawString("Cliente: " + cliente.caclrazcli, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new PointF(inicioX + 20, inicioY + 140));
            e.Graphics.DrawString("NIT: " + cliente.caclnitcli, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new PointF(inicioX + 20, inicioY + 160));

            e.Graphics.DrawLine(Pens.Black, new Point(inicioX, inicioY + 180), new Point(finalX, inicioY + 180));

            e.Graphics.DrawString("CANT.", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new PointF(inicioX, inicioY + 200));
            e.Graphics.DrawString("CONCEPTO", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new PointF(inicioX + 45, inicioY + 200));
            e.Graphics.DrawString("P.U.", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new PointF(inicioX + 180, inicioY + 200));
            e.Graphics.DrawString("IMPORTE", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new PointF(inicioX + 220, inicioY + 200));

            e.Graphics.DrawLine(Pens.Black, new Point(inicioX, inicioY + 220), new Point(finalX, inicioY + 220));

            int espacioY = inicioY+240;

            foreach (var i in listaItems)
            {
                e.Graphics.DrawString(i.caivcanite.ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new PointF(inicioX, espacioY));
                e.Graphics.DrawString(i.capdnompro, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new PointF(inicioX + 45, espacioY));
                e.Graphics.DrawString(i.caivpreuni.ToString("N2"), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new PointF(inicioX + 180, espacioY));
                e.Graphics.DrawString(i.caivsubtot.ToString("N2"), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new PointF(inicioX + 240, espacioY));
                espacioY += 20;
            }

            e.Graphics.DrawLine(Pens.Black, new Point(inicioX, espacioY), new Point(finalX, espacioY));

            e.Graphics.DrawString("TOTAL: " + total.ToString("N2"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new PointF(inicioX + 180, espacioY+20));


            int tamanoPixel = 3; // Tamaño de cada "pixel" del código QR
            // 1. Generar la matriz del código QR
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("Hola Mundo XD!!!!!!", QRCodeGenerator.ECCLevel.Q);

            // 2. Iterar sobre la matriz de datos para pintar los bloques
            using (Brush pincelNegro = new SolidBrush(Color.Black))
            {
                for (int row = 0; row < qrCodeData.ModuleMatrix.Count; row++)
                {
                    for (int col = 0; col < qrCodeData.ModuleMatrix[row].Length; col++)
                    {
                        // Si el bit es verdadero (1), se pinta un cuadro negro
                        if (qrCodeData.ModuleMatrix[row][col])
                        {
                            e.Graphics.FillRectangle(pincelNegro,
                                inicioX + (col * tamanoPixel),
                                espacioY+40 + (row * tamanoPixel),
                                tamanoPixel,
                                tamanoPixel);
                        }
                    }
                }
            }
        }
    }
}