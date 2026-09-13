namespace SistemaDeGestion2026
{
    partial class FRM_Producto_Registrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Producto_Registrar));
            this.GP_Panel_Producto = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.LBLCodigoBarras = new DevComponents.DotNetBar.LabelX();
            this.DINPrecioMinimo = new DevComponents.Editors.DoubleInput();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.DINPrecioVenta = new DevComponents.Editors.DoubleInput();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.INTStock = new DevComponents.Editors.IntegerInput();
            this.CMBTalla = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.CMBGenero = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.HOMBRE = new DevComponents.Editors.ComboItem();
            this.MUJER = new DevComponents.Editors.ComboItem();
            this.UNISEX = new DevComponents.Editors.ComboItem();
            this.CMBColor = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.CMBMaterial = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.CMBMarca = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.CMBNombreProducto = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.BTNCodigoBarras = new DevComponents.DotNetBar.ButtonX();
            this.CMBCategoria = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.BTN_AgregarCategoria = new DevComponents.DotNetBar.ButtonX();
            this.TXT_Descripcion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.GP_Fotografia = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.BTN_AbrirFoto = new DevComponents.DotNetBar.ButtonX();
            this.BTN_LimpiarFoto = new DevComponents.DotNetBar.ButtonX();
            this.BTN_CapturarFoto = new DevComponents.DotNetBar.ButtonX();
            this.PCB_Fotografía = new System.Windows.Forms.PictureBox();
            this.PCB_Camara = new System.Windows.Forms.PictureBox();
            this.BTN_Salir = new DevComponents.DotNetBar.ButtonX();
            this.BTN_Limpiar = new DevComponents.DotNetBar.ButtonX();
            this.BTN_Grabar = new DevComponents.DotNetBar.ButtonX();
            this.TXT_Modelo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SWB_Estado = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.OFDElegirImagen = new System.Windows.Forms.OpenFileDialog();
            this.GP_Panel_Producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DINPrecioMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DINPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.INTStock)).BeginInit();
            this.GP_Fotografia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCB_Fotografía)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCB_Camara)).BeginInit();
            this.SuspendLayout();
            // 
            // GP_Panel_Producto
            // 
            this.GP_Panel_Producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.GP_Panel_Producto.CanvasColor = System.Drawing.SystemColors.Control;
            this.GP_Panel_Producto.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.GP_Panel_Producto.Controls.Add(this.LBLCodigoBarras);
            this.GP_Panel_Producto.Controls.Add(this.DINPrecioMinimo);
            this.GP_Panel_Producto.Controls.Add(this.labelX3);
            this.GP_Panel_Producto.Controls.Add(this.DINPrecioVenta);
            this.GP_Panel_Producto.Controls.Add(this.labelX2);
            this.GP_Panel_Producto.Controls.Add(this.labelX1);
            this.GP_Panel_Producto.Controls.Add(this.INTStock);
            this.GP_Panel_Producto.Controls.Add(this.CMBTalla);
            this.GP_Panel_Producto.Controls.Add(this.CMBGenero);
            this.GP_Panel_Producto.Controls.Add(this.CMBColor);
            this.GP_Panel_Producto.Controls.Add(this.CMBMaterial);
            this.GP_Panel_Producto.Controls.Add(this.CMBMarca);
            this.GP_Panel_Producto.Controls.Add(this.CMBNombreProducto);
            this.GP_Panel_Producto.Controls.Add(this.BTNCodigoBarras);
            this.GP_Panel_Producto.Controls.Add(this.CMBCategoria);
            this.GP_Panel_Producto.Controls.Add(this.BTN_AgregarCategoria);
            this.GP_Panel_Producto.Controls.Add(this.TXT_Descripcion);
            this.GP_Panel_Producto.Controls.Add(this.GP_Fotografia);
            this.GP_Panel_Producto.Controls.Add(this.BTN_Salir);
            this.GP_Panel_Producto.Controls.Add(this.BTN_Limpiar);
            this.GP_Panel_Producto.Controls.Add(this.BTN_Grabar);
            this.GP_Panel_Producto.Controls.Add(this.TXT_Modelo);
            this.GP_Panel_Producto.Controls.Add(this.SWB_Estado);
            this.GP_Panel_Producto.DisabledBackColor = System.Drawing.Color.Empty;
            this.GP_Panel_Producto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GP_Panel_Producto.Location = new System.Drawing.Point(0, 0);
            this.GP_Panel_Producto.Name = "GP_Panel_Producto";
            this.GP_Panel_Producto.Size = new System.Drawing.Size(484, 439);
            // 
            // 
            // 
            this.GP_Panel_Producto.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.GP_Panel_Producto.Style.BackColorGradientAngle = 90;
            this.GP_Panel_Producto.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.GP_Panel_Producto.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GP_Panel_Producto.Style.BorderBottomWidth = 1;
            this.GP_Panel_Producto.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GP_Panel_Producto.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GP_Panel_Producto.Style.BorderLeftWidth = 1;
            this.GP_Panel_Producto.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GP_Panel_Producto.Style.BorderRightWidth = 1;
            this.GP_Panel_Producto.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GP_Panel_Producto.Style.BorderTopWidth = 1;
            this.GP_Panel_Producto.Style.CornerDiameter = 4;
            this.GP_Panel_Producto.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.GP_Panel_Producto.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GP_Panel_Producto.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GP_Panel_Producto.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.GP_Panel_Producto.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.GP_Panel_Producto.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GP_Panel_Producto.TabIndex = 0;
            this.GP_Panel_Producto.Text = "Producto";
            // 
            // LBLCodigoBarras
            // 
            this.LBLCodigoBarras.BackColor = System.Drawing.Color.Chartreuse;
            // 
            // 
            // 
            this.LBLCodigoBarras.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBLCodigoBarras.Location = new System.Drawing.Point(164, 2);
            this.LBLCodigoBarras.Name = "LBLCodigoBarras";
            this.LBLCodigoBarras.Size = new System.Drawing.Size(122, 23);
            this.LBLCodigoBarras.TabIndex = 32;
            this.LBLCodigoBarras.Text = "SIN CODIGO";
            // 
            // DINPrecioMinimo
            // 
            // 
            // 
            // 
            this.DINPrecioMinimo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.DINPrecioMinimo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DINPrecioMinimo.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.DINPrecioMinimo.Increment = 0D;
            this.DINPrecioMinimo.InputMouseWheelEnabled = false;
            this.DINPrecioMinimo.IsInputReadOnly = true;
            this.DINPrecioMinimo.Location = new System.Drawing.Point(163, 266);
            this.DINPrecioMinimo.Name = "DINPrecioMinimo";
            this.DINPrecioMinimo.ShowUpDown = true;
            this.DINPrecioMinimo.Size = new System.Drawing.Size(151, 23);
            this.DINPrecioMinimo.TabIndex = 31;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(62, 264);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(95, 23);
            this.labelX3.TabIndex = 30;
            this.labelX3.Text = "Precio Mínimo:";
            // 
            // DINPrecioVenta
            // 
            // 
            // 
            // 
            this.DINPrecioVenta.BackgroundStyle.Class = "DateTimeInputBackground";
            this.DINPrecioVenta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DINPrecioVenta.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.DINPrecioVenta.Increment = 0D;
            this.DINPrecioVenta.InputMouseWheelEnabled = false;
            this.DINPrecioVenta.IsInputReadOnly = true;
            this.DINPrecioVenta.Location = new System.Drawing.Point(163, 237);
            this.DINPrecioVenta.Name = "DINPrecioVenta";
            this.DINPrecioVenta.ShowUpDown = true;
            this.DINPrecioVenta.Size = new System.Drawing.Size(151, 23);
            this.DINPrecioVenta.TabIndex = 29;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(55, 235);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(102, 23);
            this.labelX2.TabIndex = 28;
            this.labelX2.Text = "Precio de Venta:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(72, 206);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(85, 23);
            this.labelX1.TabIndex = 26;
            this.labelX1.Text = "Stock Actual:";
            // 
            // INTStock
            // 
            // 
            // 
            // 
            this.INTStock.BackgroundStyle.Class = "DateTimeInputBackground";
            this.INTStock.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.INTStock.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.INTStock.Increment = 0;
            this.INTStock.IsInputReadOnly = true;
            this.INTStock.Location = new System.Drawing.Point(163, 206);
            this.INTStock.Name = "INTStock";
            this.INTStock.ShowUpDown = true;
            this.INTStock.Size = new System.Drawing.Size(151, 23);
            this.INTStock.TabIndex = 25;
            // 
            // CMBTalla
            // 
            this.CMBTalla.DisplayMember = "Text";
            this.CMBTalla.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBTalla.ForeColor = System.Drawing.Color.Black;
            this.CMBTalla.FormattingEnabled = true;
            this.CMBTalla.ItemHeight = 17;
            this.CMBTalla.Location = new System.Drawing.Point(163, 177);
            this.CMBTalla.Name = "CMBTalla";
            this.CMBTalla.Size = new System.Drawing.Size(151, 23);
            this.CMBTalla.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CMBTalla.TabIndex = 24;
            this.CMBTalla.WatermarkText = "Talla";
            this.CMBTalla.TextChanged += new System.EventHandler(this.TXT_Nompro_TextChanged);
            // 
            // CMBGenero
            // 
            this.CMBGenero.DisplayMember = "Text";
            this.CMBGenero.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBGenero.ForeColor = System.Drawing.Color.Black;
            this.CMBGenero.FormattingEnabled = true;
            this.CMBGenero.ItemHeight = 17;
            this.CMBGenero.Items.AddRange(new object[] {
            this.HOMBRE,
            this.MUJER,
            this.UNISEX});
            this.CMBGenero.Location = new System.Drawing.Point(163, 31);
            this.CMBGenero.Name = "CMBGenero";
            this.CMBGenero.Size = new System.Drawing.Size(151, 23);
            this.CMBGenero.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CMBGenero.TabIndex = 23;
            this.CMBGenero.WatermarkText = "Género";
            this.CMBGenero.TextChanged += new System.EventHandler(this.TXT_Nompro_TextChanged);
            // 
            // HOMBRE
            // 
            this.HOMBRE.Text = "HOMBRE";
            // 
            // MUJER
            // 
            this.MUJER.Text = "MUJER";
            // 
            // UNISEX
            // 
            this.UNISEX.Text = "UNISEX";
            // 
            // CMBColor
            // 
            this.CMBColor.DisplayMember = "Text";
            this.CMBColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBColor.ForeColor = System.Drawing.Color.Black;
            this.CMBColor.FormattingEnabled = true;
            this.CMBColor.ItemHeight = 17;
            this.CMBColor.Location = new System.Drawing.Point(9, 177);
            this.CMBColor.Name = "CMBColor";
            this.CMBColor.Size = new System.Drawing.Size(150, 23);
            this.CMBColor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CMBColor.TabIndex = 22;
            this.CMBColor.WatermarkText = "Color";
            this.CMBColor.TextChanged += new System.EventHandler(this.TXT_Nompro_TextChanged);
            // 
            // CMBMaterial
            // 
            this.CMBMaterial.DisplayMember = "Text";
            this.CMBMaterial.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBMaterial.ForeColor = System.Drawing.Color.Black;
            this.CMBMaterial.FormattingEnabled = true;
            this.CMBMaterial.ItemHeight = 17;
            this.CMBMaterial.Location = new System.Drawing.Point(9, 148);
            this.CMBMaterial.Name = "CMBMaterial";
            this.CMBMaterial.Size = new System.Drawing.Size(305, 23);
            this.CMBMaterial.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CMBMaterial.TabIndex = 21;
            this.CMBMaterial.WatermarkText = "Material";
            this.CMBMaterial.TextChanged += new System.EventHandler(this.TXT_Nompro_TextChanged);
            // 
            // CMBMarca
            // 
            this.CMBMarca.DisplayMember = "Text";
            this.CMBMarca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBMarca.ForeColor = System.Drawing.Color.Black;
            this.CMBMarca.FormattingEnabled = true;
            this.CMBMarca.ItemHeight = 17;
            this.CMBMarca.Location = new System.Drawing.Point(9, 119);
            this.CMBMarca.Name = "CMBMarca";
            this.CMBMarca.Size = new System.Drawing.Size(305, 23);
            this.CMBMarca.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CMBMarca.TabIndex = 20;
            this.CMBMarca.WatermarkText = "Marca";
            this.CMBMarca.TextChanged += new System.EventHandler(this.TXT_Nompro_TextChanged);
            // 
            // CMBNombreProducto
            // 
            this.CMBNombreProducto.DisplayMember = "Text";
            this.CMBNombreProducto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBNombreProducto.ForeColor = System.Drawing.Color.Black;
            this.CMBNombreProducto.FormattingEnabled = true;
            this.CMBNombreProducto.ItemHeight = 17;
            this.CMBNombreProducto.Location = new System.Drawing.Point(9, 90);
            this.CMBNombreProducto.Name = "CMBNombreProducto";
            this.CMBNombreProducto.Size = new System.Drawing.Size(305, 23);
            this.CMBNombreProducto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CMBNombreProducto.TabIndex = 19;
            this.CMBNombreProducto.WatermarkText = "Nombre del Producto";
            this.CMBNombreProducto.TextChanged += new System.EventHandler(this.TXT_Nompro_TextChanged);
            // 
            // BTNCodigoBarras
            // 
            this.BTNCodigoBarras.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNCodigoBarras.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNCodigoBarras.Image = global::SistemaDeGestion2026.Properties.Resources.ic_codigoBarras2;
            this.BTNCodigoBarras.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTNCodigoBarras.Location = new System.Drawing.Point(289, 2);
            this.BTNCodigoBarras.Margin = new System.Windows.Forms.Padding(0);
            this.BTNCodigoBarras.Name = "BTNCodigoBarras";
            this.BTNCodigoBarras.Size = new System.Drawing.Size(25, 23);
            this.BTNCodigoBarras.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNCodigoBarras.TabIndex = 18;
            this.BTNCodigoBarras.Click += new System.EventHandler(this.BTNCodigoBarras_Click);
            this.BTNCodigoBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BTNCodigoBarras_KeyPress);
            // 
            // CMBCategoria
            // 
            this.CMBCategoria.DisplayMember = "Text";
            this.CMBCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBCategoria.ForeColor = System.Drawing.Color.Black;
            this.CMBCategoria.FormattingEnabled = true;
            this.CMBCategoria.ItemHeight = 17;
            this.CMBCategoria.Location = new System.Drawing.Point(9, 60);
            this.CMBCategoria.Name = "CMBCategoria";
            this.CMBCategoria.Size = new System.Drawing.Size(277, 23);
            this.CMBCategoria.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CMBCategoria.TabIndex = 2;
            this.CMBCategoria.WatermarkText = "Categoría";
            this.CMBCategoria.TextChanged += new System.EventHandler(this.TXT_Nompro_TextChanged);
            // 
            // BTN_AgregarCategoria
            // 
            this.BTN_AgregarCategoria.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_AgregarCategoria.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_AgregarCategoria.Image = global::SistemaDeGestion2026.Properties.Resources.ic_agregar;
            this.BTN_AgregarCategoria.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTN_AgregarCategoria.Location = new System.Drawing.Point(289, 60);
            this.BTN_AgregarCategoria.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_AgregarCategoria.Name = "BTN_AgregarCategoria";
            this.BTN_AgregarCategoria.Size = new System.Drawing.Size(25, 23);
            this.BTN_AgregarCategoria.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_AgregarCategoria.TabIndex = 13;
            this.BTN_AgregarCategoria.Click += new System.EventHandler(this.BTN_AgregarCategoria_Click);
            // 
            // TXT_Descripcion
            // 
            this.TXT_Descripcion.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TXT_Descripcion.Border.Class = "TextBoxBorder";
            this.TXT_Descripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXT_Descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_Descripcion.DisabledBackColor = System.Drawing.Color.White;
            this.TXT_Descripcion.ForeColor = System.Drawing.Color.Black;
            this.TXT_Descripcion.Location = new System.Drawing.Point(9, 295);
            this.TXT_Descripcion.Multiline = true;
            this.TXT_Descripcion.Name = "TXT_Descripcion";
            this.TXT_Descripcion.PreventEnterBeep = true;
            this.TXT_Descripcion.Size = new System.Drawing.Size(305, 63);
            this.TXT_Descripcion.TabIndex = 12;
            this.TXT_Descripcion.WatermarkText = "Descripción";
            // 
            // GP_Fotografia
            // 
            this.GP_Fotografia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.GP_Fotografia.CanvasColor = System.Drawing.SystemColors.Control;
            this.GP_Fotografia.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GP_Fotografia.Controls.Add(this.BTN_AbrirFoto);
            this.GP_Fotografia.Controls.Add(this.BTN_LimpiarFoto);
            this.GP_Fotografia.Controls.Add(this.BTN_CapturarFoto);
            this.GP_Fotografia.Controls.Add(this.PCB_Fotografía);
            this.GP_Fotografia.Controls.Add(this.PCB_Camara);
            this.GP_Fotografia.DisabledBackColor = System.Drawing.Color.Empty;
            this.GP_Fotografia.Location = new System.Drawing.Point(320, 2);
            this.GP_Fotografia.Name = "GP_Fotografia";
            this.GP_Fotografia.Size = new System.Drawing.Size(150, 356);
            // 
            // 
            // 
            this.GP_Fotografia.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.GP_Fotografia.Style.BackColorGradientAngle = 90;
            this.GP_Fotografia.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.GP_Fotografia.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GP_Fotografia.Style.BorderBottomWidth = 1;
            this.GP_Fotografia.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GP_Fotografia.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GP_Fotografia.Style.BorderLeftWidth = 1;
            this.GP_Fotografia.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GP_Fotografia.Style.BorderRightWidth = 1;
            this.GP_Fotografia.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GP_Fotografia.Style.BorderTopWidth = 1;
            this.GP_Fotografia.Style.CornerDiameter = 4;
            this.GP_Fotografia.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.GP_Fotografia.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GP_Fotografia.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GP_Fotografia.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.GP_Fotografia.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.GP_Fotografia.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GP_Fotografia.TabIndex = 14;
            this.GP_Fotografia.Text = "Fotografía";
            // 
            // BTN_AbrirFoto
            // 
            this.BTN_AbrirFoto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_AbrirFoto.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_AbrirFoto.Image = ((System.Drawing.Image)(resources.GetObject("BTN_AbrirFoto.Image")));
            this.BTN_AbrirFoto.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTN_AbrirFoto.Location = new System.Drawing.Point(11, 292);
            this.BTN_AbrirFoto.Name = "BTN_AbrirFoto";
            this.BTN_AbrirFoto.Size = new System.Drawing.Size(125, 30);
            this.BTN_AbrirFoto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_AbrirFoto.TabIndex = 2;
            this.BTN_AbrirFoto.Text = "Buscar Imagen";
            this.BTN_AbrirFoto.Click += new System.EventHandler(this.BTN_AbrirFoto_Click);
            // 
            // BTN_LimpiarFoto
            // 
            this.BTN_LimpiarFoto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_LimpiarFoto.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_LimpiarFoto.Image = ((System.Drawing.Image)(resources.GetObject("BTN_LimpiarFoto.Image")));
            this.BTN_LimpiarFoto.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTN_LimpiarFoto.Location = new System.Drawing.Point(11, 256);
            this.BTN_LimpiarFoto.Name = "BTN_LimpiarFoto";
            this.BTN_LimpiarFoto.Size = new System.Drawing.Size(125, 30);
            this.BTN_LimpiarFoto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_LimpiarFoto.TabIndex = 1;
            this.BTN_LimpiarFoto.Text = "Limpiar";
            this.BTN_LimpiarFoto.Click += new System.EventHandler(this.BTN_LimpiarFoto_Click);
            // 
            // BTN_CapturarFoto
            // 
            this.BTN_CapturarFoto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_CapturarFoto.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_CapturarFoto.Image = ((System.Drawing.Image)(resources.GetObject("BTN_CapturarFoto.Image")));
            this.BTN_CapturarFoto.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTN_CapturarFoto.Location = new System.Drawing.Point(11, 220);
            this.BTN_CapturarFoto.Name = "BTN_CapturarFoto";
            this.BTN_CapturarFoto.Size = new System.Drawing.Size(125, 30);
            this.BTN_CapturarFoto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_CapturarFoto.TabIndex = 0;
            this.BTN_CapturarFoto.Text = "Capturar";
            this.BTN_CapturarFoto.Click += new System.EventHandler(this.BTN_CapturarFoto_Click);
            // 
            // PCB_Fotografía
            // 
            this.PCB_Fotografía.Image = ((System.Drawing.Image)(resources.GetObject("PCB_Fotografía.Image")));
            this.PCB_Fotografía.Location = new System.Drawing.Point(11, 114);
            this.PCB_Fotografía.Name = "PCB_Fotografía";
            this.PCB_Fotografía.Size = new System.Drawing.Size(125, 100);
            this.PCB_Fotografía.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PCB_Fotografía.TabIndex = 1;
            this.PCB_Fotografía.TabStop = false;
            // 
            // PCB_Camara
            // 
            this.PCB_Camara.Image = global::SistemaDeGestion2026.Properties.Resources.gif_no_camara2;
            this.PCB_Camara.Location = new System.Drawing.Point(11, 8);
            this.PCB_Camara.Name = "PCB_Camara";
            this.PCB_Camara.Size = new System.Drawing.Size(125, 100);
            this.PCB_Camara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PCB_Camara.TabIndex = 0;
            this.PCB_Camara.TabStop = false;
            // 
            // BTN_Salir
            // 
            this.BTN_Salir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Salir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Salir.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Salir.Image")));
            this.BTN_Salir.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTN_Salir.Location = new System.Drawing.Point(320, 364);
            this.BTN_Salir.Name = "BTN_Salir";
            this.BTN_Salir.Size = new System.Drawing.Size(150, 44);
            this.BTN_Salir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Salir.TabIndex = 17;
            this.BTN_Salir.Text = "&Salir";
            this.BTN_Salir.Click += new System.EventHandler(this.BTN_Salir_Click);
            // 
            // BTN_Limpiar
            // 
            this.BTN_Limpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Limpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Limpiar.Image")));
            this.BTN_Limpiar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTN_Limpiar.Location = new System.Drawing.Point(164, 364);
            this.BTN_Limpiar.Name = "BTN_Limpiar";
            this.BTN_Limpiar.Size = new System.Drawing.Size(150, 44);
            this.BTN_Limpiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Limpiar.TabIndex = 16;
            this.BTN_Limpiar.Text = "&Limpiar";
            this.BTN_Limpiar.Click += new System.EventHandler(this.BTN_Limpiar_Click);
            // 
            // BTN_Grabar
            // 
            this.BTN_Grabar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Grabar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Grabar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Grabar.Image")));
            this.BTN_Grabar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTN_Grabar.Location = new System.Drawing.Point(9, 364);
            this.BTN_Grabar.Name = "BTN_Grabar";
            this.BTN_Grabar.Size = new System.Drawing.Size(150, 44);
            this.BTN_Grabar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Grabar.TabIndex = 15;
            this.BTN_Grabar.Text = "&Grabar";
            this.BTN_Grabar.Click += new System.EventHandler(this.BTN_Grabar_Click);
            // 
            // TXT_Modelo
            // 
            this.TXT_Modelo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TXT_Modelo.Border.Class = "TextBoxBorder";
            this.TXT_Modelo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXT_Modelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_Modelo.DisabledBackColor = System.Drawing.Color.White;
            this.TXT_Modelo.ForeColor = System.Drawing.Color.Black;
            this.TXT_Modelo.Location = new System.Drawing.Point(9, 31);
            this.TXT_Modelo.Name = "TXT_Modelo";
            this.TXT_Modelo.PreventEnterBeep = true;
            this.TXT_Modelo.Size = new System.Drawing.Size(150, 23);
            this.TXT_Modelo.TabIndex = 5;
            this.TXT_Modelo.WatermarkText = "Modelo";
            this.TXT_Modelo.TextChanged += new System.EventHandler(this.TXT_Nompro_TextChanged);
            // 
            // SWB_Estado
            // 
            // 
            // 
            // 
            this.SWB_Estado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SWB_Estado.Location = new System.Drawing.Point(9, 2);
            this.SWB_Estado.Name = "SWB_Estado";
            this.SWB_Estado.OffBackColor = System.Drawing.Color.Red;
            this.SWB_Estado.OffText = "Inhabilitado";
            this.SWB_Estado.OffTextColor = System.Drawing.Color.White;
            this.SWB_Estado.OnBackColor = System.Drawing.Color.LimeGreen;
            this.SWB_Estado.OnText = "Habilitado";
            this.SWB_Estado.OnTextColor = System.Drawing.Color.White;
            this.SWB_Estado.Size = new System.Drawing.Size(150, 23);
            this.SWB_Estado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SWB_Estado.TabIndex = 0;
            this.SWB_Estado.Value = true;
            this.SWB_Estado.ValueObject = "Y";
            // 
            // OFDElegirImagen
            // 
            this.OFDElegirImagen.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png";
            this.OFDElegirImagen.Title = "Elegir Fotografía";
            // 
            // FRM_Producto_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Salir;
            this.ClientSize = new System.Drawing.Size(484, 439);
            this.Controls.Add(this.GP_Panel_Producto);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_Producto_Registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Producto_Registrar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_Producto_Registrar_FormClosing);
            this.Load += new System.EventHandler(this.FRM_Producto_Registrar_Load);
            this.GP_Panel_Producto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DINPrecioMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DINPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.INTStock)).EndInit();
            this.GP_Fotografia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PCB_Fotografía)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCB_Camara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel GP_Panel_Producto;
        private DevComponents.DotNetBar.Controls.GroupPanel GP_Fotografia;
        private DevComponents.DotNetBar.ButtonX BTN_AbrirFoto;
        private DevComponents.DotNetBar.ButtonX BTN_LimpiarFoto;
        private DevComponents.DotNetBar.ButtonX BTN_CapturarFoto;
        private System.Windows.Forms.PictureBox PCB_Fotografía;
        private System.Windows.Forms.PictureBox PCB_Camara;
        private DevComponents.DotNetBar.ButtonX BTN_Salir;
        private DevComponents.DotNetBar.ButtonX BTN_Limpiar;
        private DevComponents.DotNetBar.ButtonX BTN_Grabar;
        private DevComponents.DotNetBar.Controls.TextBoxX TXT_Modelo;
        private DevComponents.DotNetBar.Controls.SwitchButton SWB_Estado;
        private DevComponents.DotNetBar.Controls.TextBoxX TXT_Descripcion;
        private DevComponents.DotNetBar.ButtonX BTN_AgregarCategoria;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CMBCategoria;
        private System.Windows.Forms.OpenFileDialog OFDElegirImagen;
        private DevComponents.DotNetBar.ButtonX BTNCodigoBarras;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CMBColor;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CMBMaterial;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CMBMarca;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CMBNombreProducto;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CMBTalla;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CMBGenero;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.IntegerInput INTStock;
        private DevComponents.Editors.DoubleInput DINPrecioMinimo;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.Editors.DoubleInput DINPrecioVenta;
        private DevComponents.DotNetBar.LabelX LBLCodigoBarras;
        private DevComponents.Editors.ComboItem HOMBRE;
        private DevComponents.Editors.ComboItem MUJER;
        private DevComponents.Editors.ComboItem UNISEX;
    }
}