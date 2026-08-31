namespace SistemaDeGestion2026
{
    partial class FRM_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Principal));
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.BTN_Productos = new DevComponents.DotNetBar.ButtonItem();
            this.BTN_Categorias = new DevComponents.DotNetBar.ButtonItem();
            this.RBPAdministracion = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.BTN_Personas = new DevComponents.DotNetBar.ButtonItem();
            this.BTN_Usuarios = new DevComponents.DotNetBar.ButtonItem();
            this.applicationButton1 = new DevComponents.DotNetBar.ApplicationButton();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
            this.BTNLogin = new DevComponents.DotNetBar.ButtonItem();
            this.BTN_LoginHuella = new DevComponents.DotNetBar.ButtonItem();
            this.BTNActualizarPassword = new DevComponents.DotNetBar.ButtonItem();
            this.BTNCerrarSesion = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer4 = new DevComponents.DotNetBar.ItemContainer();
            this.BTNConfigurar = new DevComponents.DotNetBar.ButtonItem();
            this.BTNSalir = new DevComponents.DotNetBar.ButtonItem();
            this.RTB_Administracion = new DevComponents.DotNetBar.RibbonTabItem();
            this.RTB_Inventario = new DevComponents.DotNetBar.RibbonTabItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFechaHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.BTN_Clientes = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.RBPAdministracion.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel2);
            this.ribbonControl1.Controls.Add(this.RBPAdministracion);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.ForeColor = System.Drawing.Color.Black;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.applicationButton1,
            this.RTB_Administracion,
            this.RTB_Inventario});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(3, 3);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Size = new System.Drawing.Size(920, 136);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControl1.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel2.Controls.Add(this.ribbonBar2);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 54);
            this.ribbonPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(4, 0, 4, 2);
            this.ribbonPanel2.Size = new System.Drawing.Size(920, 82);
            // 
            // 
            // 
            this.ribbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel2.TabIndex = 2;
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.ContainerControlProcessDialogKey = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.DragDropSupport = true;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.BTN_Productos,
            this.BTN_Categorias,
            this.BTN_Clientes});
            this.ribbonBar2.Location = new System.Drawing.Point(4, 0);
            this.ribbonBar2.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(226, 80);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar2.TabIndex = 1;
            // 
            // 
            // 
            this.ribbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // BTN_Productos
            // 
            this.BTN_Productos.Image = global::SistemaDeGestion2026.Properties.Resources.icons8_producto_48;
            this.BTN_Productos.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.BTN_Productos.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_Productos.Name = "BTN_Productos";
            this.BTN_Productos.SubItemsExpandWidth = 14;
            this.BTN_Productos.Text = "Productos";
            this.BTN_Productos.Click += new System.EventHandler(this.BTN_Productos_Click);
            // 
            // BTN_Categorias
            // 
            this.BTN_Categorias.Image = global::SistemaDeGestion2026.Properties.Resources.ic_categoria;
            this.BTN_Categorias.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.BTN_Categorias.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_Categorias.Name = "BTN_Categorias";
            this.BTN_Categorias.SubItemsExpandWidth = 14;
            this.BTN_Categorias.Text = "Categorías";
            this.BTN_Categorias.Click += new System.EventHandler(this.BTN_Categorias_Click);
            // 
            // RBPAdministracion
            // 
            this.RBPAdministracion.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RBPAdministracion.Controls.Add(this.ribbonBar1);
            this.RBPAdministracion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RBPAdministracion.Location = new System.Drawing.Point(0, 54);
            this.RBPAdministracion.Margin = new System.Windows.Forms.Padding(4);
            this.RBPAdministracion.Name = "RBPAdministracion";
            this.RBPAdministracion.Padding = new System.Windows.Forms.Padding(4, 0, 4, 2);
            this.RBPAdministracion.Size = new System.Drawing.Size(920, 82);
            // 
            // 
            // 
            this.RBPAdministracion.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RBPAdministracion.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RBPAdministracion.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RBPAdministracion.TabIndex = 1;
            this.RBPAdministracion.Visible = false;
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.DragDropSupport = true;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.BTN_Personas,
            this.BTN_Usuarios});
            this.ribbonBar1.Location = new System.Drawing.Point(4, 0);
            this.ribbonBar1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(131, 80);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 0;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // BTN_Personas
            // 
            this.BTN_Personas.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Personas.Image")));
            this.BTN_Personas.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.BTN_Personas.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_Personas.Name = "BTN_Personas";
            this.BTN_Personas.SubItemsExpandWidth = 14;
            this.BTN_Personas.Text = "Personas";
            this.BTN_Personas.Click += new System.EventHandler(this.BTN_Personas_Click);
            // 
            // BTN_Usuarios
            // 
            this.BTN_Usuarios.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Usuarios.Image")));
            this.BTN_Usuarios.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.BTN_Usuarios.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_Usuarios.Name = "BTN_Usuarios";
            this.BTN_Usuarios.SubItemsExpandWidth = 14;
            this.BTN_Usuarios.Text = "Usuarios";
            this.BTN_Usuarios.Click += new System.EventHandler(this.BTN_Usuarios_Click);
            // 
            // applicationButton1
            // 
            this.applicationButton1.AutoExpandOnClick = true;
            this.applicationButton1.CanCustomize = false;
            this.applicationButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.applicationButton1.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.applicationButton1.ImagePaddingHorizontal = 0;
            this.applicationButton1.ImagePaddingVertical = 1;
            this.applicationButton1.Name = "applicationButton1";
            this.applicationButton1.ShowSubItems = false;
            this.applicationButton1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.applicationButton1.Text = "&Inicio";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.Class = "RibbonFileMenuContainer";
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer2,
            this.itemContainer4});
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // itemContainer2
            // 
            // 
            // 
            // 
            this.itemContainer2.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer";
            this.itemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer2.ItemSpacing = 0;
            this.itemContainer2.Name = "itemContainer2";
            this.itemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer3});
            // 
            // 
            // 
            this.itemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // itemContainer3
            // 
            // 
            // 
            // 
            this.itemContainer3.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
            this.itemContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer3.MinimumSize = new System.Drawing.Size(120, 0);
            this.itemContainer3.Name = "itemContainer3";
            this.itemContainer3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.BTNLogin,
            this.BTN_LoginHuella,
            this.BTNActualizarPassword,
            this.BTNCerrarSesion});
            // 
            // 
            // 
            this.itemContainer3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // BTNLogin
            // 
            this.BTNLogin.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BTNLogin.Image = ((System.Drawing.Image)(resources.GetObject("BTNLogin.Image")));
            this.BTNLogin.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTNLogin.Name = "BTNLogin";
            this.BTNLogin.SubItemsExpandWidth = 24;
            this.BTNLogin.Text = "&Iniciar Sesión";
            this.BTNLogin.Click += new System.EventHandler(this.BTNLogin_Click);
            // 
            // BTN_LoginHuella
            // 
            this.BTN_LoginHuella.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BTN_LoginHuella.Image = global::SistemaDeGestion2026.Properties.Resources.icons8_huella_dactilar_100;
            this.BTN_LoginHuella.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTN_LoginHuella.Name = "BTN_LoginHuella";
            this.BTN_LoginHuella.SubItemsExpandWidth = 24;
            this.BTN_LoginHuella.Text = "&Iniciar Con Huella";
            this.BTN_LoginHuella.Click += new System.EventHandler(this.BTN_LoginHuella_Click);
            // 
            // BTNActualizarPassword
            // 
            this.BTNActualizarPassword.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BTNActualizarPassword.Image = ((System.Drawing.Image)(resources.GetObject("BTNActualizarPassword.Image")));
            this.BTNActualizarPassword.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTNActualizarPassword.Name = "BTNActualizarPassword";
            this.BTNActualizarPassword.SubItemsExpandWidth = 24;
            this.BTNActualizarPassword.Text = "&Actualizar Password";
            // 
            // BTNCerrarSesion
            // 
            this.BTNCerrarSesion.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BTNCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("BTNCerrarSesion.Image")));
            this.BTNCerrarSesion.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTNCerrarSesion.Name = "BTNCerrarSesion";
            this.BTNCerrarSesion.SubItemsExpandWidth = 24;
            this.BTNCerrarSesion.Text = "&Cerrar Sesión";
            this.BTNCerrarSesion.Click += new System.EventHandler(this.BTNCerrarSesion_Click);
            // 
            // itemContainer4
            // 
            // 
            // 
            // 
            this.itemContainer4.BackgroundStyle.Class = "RibbonFileMenuBottomContainer";
            this.itemContainer4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer4.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.itemContainer4.Name = "itemContainer4";
            this.itemContainer4.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.BTNConfigurar,
            this.BTNSalir});
            // 
            // 
            // 
            this.itemContainer4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // BTNConfigurar
            // 
            this.BTNConfigurar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BTNConfigurar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNConfigurar.Image = ((System.Drawing.Image)(resources.GetObject("BTNConfigurar.Image")));
            this.BTNConfigurar.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTNConfigurar.Name = "BTNConfigurar";
            this.BTNConfigurar.SubItemsExpandWidth = 24;
            this.BTNConfigurar.Text = "Confi&gurar";
            // 
            // BTNSalir
            // 
            this.BTNSalir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BTNSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNSalir.Image = ((System.Drawing.Image)(resources.GetObject("BTNSalir.Image")));
            this.BTNSalir.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.SubItemsExpandWidth = 24;
            this.BTNSalir.Text = "&Salir";
            // 
            // RTB_Administracion
            // 
            this.RTB_Administracion.Name = "RTB_Administracion";
            this.RTB_Administracion.Panel = this.RBPAdministracion;
            this.RTB_Administracion.Text = "&Administración";
            // 
            // RTB_Inventario
            // 
            this.RTB_Inventario.Checked = true;
            this.RTB_Inventario.Name = "RTB_Inventario";
            this.RTB_Inventario.Panel = this.ribbonPanel2;
            this.RTB_Inventario.Text = "Inventario";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(116)))), ((int)(((byte)(71))))));
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.lblFechaHora});
            this.statusStrip1.Location = new System.Drawing.Point(3, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(920, 34);
            this.statusStrip1.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Padding = new System.Windows.Forms.Padding(5);
            this.lblUsuario.Size = new System.Drawing.Size(452, 29);
            this.lblUsuario.Spring = true;
            this.lblUsuario.Text = " Usuario:";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Padding = new System.Windows.Forms.Padding(5);
            this.lblFechaHora.Size = new System.Drawing.Size(452, 29);
            this.lblFechaHora.Spring = true;
            this.lblFechaHora.Text = " Fecha y Hora:";
            this.lblFechaHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonItem1
            // 
            this.buttonItem1.Image = global::SistemaDeGestion2026.Properties.Resources.icons8_producto_48;
            this.buttonItem1.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.buttonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItemsExpandWidth = 14;
            this.buttonItem1.Text = "Productos";
            // 
            // buttonItem2
            // 
            this.buttonItem2.Image = global::SistemaDeGestion2026.Properties.Resources.icons8_producto_48;
            this.buttonItem2.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.buttonItem2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.SubItemsExpandWidth = 14;
            this.buttonItem2.Text = "Productos";
            // 
            // BTN_Clientes
            // 
            this.BTN_Clientes.Image = global::SistemaDeGestion2026.Properties.Resources.ic_categoria;
            this.BTN_Clientes.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.BTN_Clientes.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_Clientes.Name = "BTN_Clientes";
            this.BTN_Clientes.SubItemsExpandWidth = 14;
            this.BTN_Clientes.Text = "Clientes";
            this.BTN_Clientes.Click += new System.EventHandler(this.BTN_Clientes_Click);
            // 
            // FRM_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 476);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_Principal";
            this.Opacity = 0D;
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA GESTION 2026";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_Principal_Load);
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel2.ResumeLayout(false);
            this.RBPAdministracion.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel RBPAdministracion;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ApplicationButton applicationButton1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.ItemContainer itemContainer3;
        private DevComponents.DotNetBar.ButtonItem BTNLogin;
        private DevComponents.DotNetBar.ButtonItem BTNActualizarPassword;
        private DevComponents.DotNetBar.ButtonItem BTNCerrarSesion;
        private DevComponents.DotNetBar.RibbonTabItem RTB_Administracion;
        private DevComponents.DotNetBar.RibbonTabItem RTB_Inventario;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonItem BTN_Personas;
        private DevComponents.DotNetBar.ButtonItem BTN_Usuarios;
        private DevComponents.DotNetBar.ItemContainer itemContainer4;
        private DevComponents.DotNetBar.ButtonItem BTNConfigurar;
        private DevComponents.DotNetBar.ButtonItem BTNSalir;
        private DevComponents.DotNetBar.ButtonItem BTN_LoginHuella;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.ButtonItem BTN_Productos;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblFechaHora;
        private System.Windows.Forms.Timer timer1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem BTN_Categorias;
        private DevComponents.DotNetBar.ButtonItem BTN_Clientes;
    }
}

