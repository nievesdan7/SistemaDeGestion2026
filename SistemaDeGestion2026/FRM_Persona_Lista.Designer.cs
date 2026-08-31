namespace SistemaDeGestion2026
{
    partial class FRM_Persona_Lista
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Persona_Lista));
            this.DTG_Lista = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.Nombre_Completo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EPN_Opciones = new DevComponents.DotNetBar.ExpandablePanel();
            this.BTN_Reporte = new DevComponents.DotNetBar.ButtonX();
            this.BTN_Modificar = new DevComponents.DotNetBar.ButtonX();
            this.BTN_Registrar = new DevComponents.DotNetBar.ButtonX();
            this.CMSMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inhabilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.groupPanelBusqueda = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.BTN_Buscar = new DevComponents.DotNetBar.ButtonX();
            this.TXT_Filtrar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.IIN_Filas = new DevComponents.Editors.IntegerInput();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_Lista)).BeginInit();
            this.EPN_Opciones.SuspendLayout();
            this.CMSMenu.SuspendLayout();
            this.expandablePanel1.SuspendLayout();
            this.groupPanelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IIN_Filas)).BeginInit();
            this.SuspendLayout();
            // 
            // DTG_Lista
            // 
            this.DTG_Lista.AllowUserToAddRows = false;
            this.DTG_Lista.AllowUserToDeleteRows = false;
            this.DTG_Lista.AllowUserToResizeColumns = false;
            this.DTG_Lista.AllowUserToResizeRows = false;
            this.DTG_Lista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTG_Lista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DTG_Lista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DTG_Lista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DTG_Lista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTG_Lista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DTG_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Nombre_Completo,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.DTG_Lista.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DTG_Lista.DefaultCellStyle = dataGridViewCellStyle3;
            this.DTG_Lista.EnableHeadersVisualStyles = false;
            this.DTG_Lista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.DTG_Lista.Location = new System.Drawing.Point(72, 106);
            this.DTG_Lista.MultiSelect = false;
            this.DTG_Lista.Name = "DTG_Lista";
            this.DTG_Lista.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTG_Lista.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DTG_Lista.RowHeadersVisible = false;
            this.DTG_Lista.RowTemplate.Height = 30;
            this.DTG_Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTG_Lista.Size = new System.Drawing.Size(913, 355);
            this.DTG_Lista.TabIndex = 65;
            this.DTG_Lista.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DTG_Lista_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.Checked = true;
            this.Column2.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.Column2.CheckValue = null;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Estado";
            this.Column2.MinimumWidth = 60;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 60;
            // 
            // Nombre_Completo
            // 
            this.Nombre_Completo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nombre_Completo.HeaderText = "Documento";
            this.Nombre_Completo.MinimumWidth = 80;
            this.Nombre_Completo.Name = "Nombre_Completo";
            this.Nombre_Completo.ReadOnly = true;
            this.Nombre_Completo.Width = 119;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Ape. Pat.";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 104;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Ape. Mat.";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 106;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Nombres";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Fec. Nac.";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Sexo";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "Celular";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // EPN_Opciones
            // 
            this.EPN_Opciones.CanvasColor = System.Drawing.SystemColors.Control;
            this.EPN_Opciones.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.EPN_Opciones.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.EPN_Opciones.Controls.Add(this.BTN_Reporte);
            this.EPN_Opciones.Controls.Add(this.BTN_Modificar);
            this.EPN_Opciones.Controls.Add(this.BTN_Registrar);
            this.EPN_Opciones.DisabledBackColor = System.Drawing.Color.Empty;
            this.EPN_Opciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.EPN_Opciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EPN_Opciones.HideControlsWhenCollapsed = true;
            this.EPN_Opciones.Location = new System.Drawing.Point(0, 0);
            this.EPN_Opciones.Name = "EPN_Opciones";
            this.EPN_Opciones.Size = new System.Drawing.Size(72, 461);
            this.EPN_Opciones.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.EPN_Opciones.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.EPN_Opciones.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.EPN_Opciones.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.EPN_Opciones.Style.GradientAngle = 90;
            this.EPN_Opciones.TabIndex = 64;
            this.EPN_Opciones.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.EPN_Opciones.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.EPN_Opciones.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.EPN_Opciones.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.EPN_Opciones.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.EPN_Opciones.TitleStyle.GradientAngle = 90;
            this.EPN_Opciones.TitleStyleMouseDown.BackColor1.Color = System.Drawing.Color.Transparent;
            this.EPN_Opciones.TitleText = "Opciones";
            // 
            // BTN_Reporte
            // 
            this.BTN_Reporte.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Reporte.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Reporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Reporte.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Reporte.Image")));
            this.BTN_Reporte.ImageFixedSize = new System.Drawing.Size(60, 60);
            this.BTN_Reporte.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_Reporte.Location = new System.Drawing.Point(0, 186);
            this.BTN_Reporte.Name = "BTN_Reporte";
            this.BTN_Reporte.Size = new System.Drawing.Size(72, 81);
            this.BTN_Reporte.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Reporte.TabIndex = 6;
            this.BTN_Reporte.Text = "Reporte";
            // 
            // BTN_Modificar
            // 
            this.BTN_Modificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Modificar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Modificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Modificar.Image")));
            this.BTN_Modificar.ImageFixedSize = new System.Drawing.Size(60, 60);
            this.BTN_Modificar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_Modificar.Location = new System.Drawing.Point(0, 106);
            this.BTN_Modificar.Name = "BTN_Modificar";
            this.BTN_Modificar.Size = new System.Drawing.Size(72, 80);
            this.BTN_Modificar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Modificar.TabIndex = 5;
            this.BTN_Modificar.Text = "Modificar ";
            this.BTN_Modificar.Click += new System.EventHandler(this.BTN_Modificar_Click);
            // 
            // BTN_Registrar
            // 
            this.BTN_Registrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Registrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Registrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Registrar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Registrar.Image")));
            this.BTN_Registrar.ImageFixedSize = new System.Drawing.Size(60, 60);
            this.BTN_Registrar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_Registrar.Location = new System.Drawing.Point(0, 26);
            this.BTN_Registrar.Name = "BTN_Registrar";
            this.BTN_Registrar.Size = new System.Drawing.Size(72, 80);
            this.BTN_Registrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Registrar.TabIndex = 4;
            this.BTN_Registrar.Text = "Registrar ";
            this.BTN_Registrar.Click += new System.EventHandler(this.BTN_Registrar_Click);
            // 
            // CMSMenu
            // 
            this.CMSMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem,
            this.inhabilitarToolStripMenuItem,
            this.habilitarToolStripMenuItem});
            this.CMSMenu.Name = "CMSMenu";
            this.CMSMenu.Size = new System.Drawing.Size(128, 70);
            this.CMSMenu.Opening += new System.ComponentModel.CancelEventHandler(this.CMSMenu_Opening);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.modificarToolStripMenuItem.Text = "&Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // inhabilitarToolStripMenuItem
            // 
            this.inhabilitarToolStripMenuItem.Name = "inhabilitarToolStripMenuItem";
            this.inhabilitarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.inhabilitarToolStripMenuItem.Text = "&Inhabilitar";
            this.inhabilitarToolStripMenuItem.Click += new System.EventHandler(this.inhabilitarToolStripMenuItem_Click);
            // 
            // habilitarToolStripMenuItem
            // 
            this.habilitarToolStripMenuItem.Name = "habilitarToolStripMenuItem";
            this.habilitarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.habilitarToolStripMenuItem.Text = "&Habilitar";
            this.habilitarToolStripMenuItem.Click += new System.EventHandler(this.habilitarToolStripMenuItem_Click);
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel1.Controls.Add(this.groupPanelBusqueda);
            this.expandablePanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.expandablePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.expandablePanel1.HideControlsWhenCollapsed = true;
            this.expandablePanel1.Location = new System.Drawing.Point(72, 0);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(913, 106);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 76;
            this.expandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "Filtrar";
            // 
            // groupPanelBusqueda
            // 
            this.groupPanelBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.groupPanelBusqueda.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelBusqueda.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelBusqueda.Controls.Add(this.BTN_Buscar);
            this.groupPanelBusqueda.Controls.Add(this.TXT_Filtrar);
            this.groupPanelBusqueda.Controls.Add(this.IIN_Filas);
            this.groupPanelBusqueda.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanelBusqueda.Location = new System.Drawing.Point(6, 26);
            this.groupPanelBusqueda.Name = "groupPanelBusqueda";
            this.groupPanelBusqueda.Size = new System.Drawing.Size(326, 74);
            // 
            // 
            // 
            this.groupPanelBusqueda.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelBusqueda.Style.BackColorGradientAngle = 90;
            this.groupPanelBusqueda.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelBusqueda.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelBusqueda.Style.BorderBottomWidth = 1;
            this.groupPanelBusqueda.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelBusqueda.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelBusqueda.Style.BorderLeftWidth = 1;
            this.groupPanelBusqueda.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelBusqueda.Style.BorderRightWidth = 1;
            this.groupPanelBusqueda.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelBusqueda.Style.BorderTopWidth = 1;
            this.groupPanelBusqueda.Style.CornerDiameter = 4;
            this.groupPanelBusqueda.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelBusqueda.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelBusqueda.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelBusqueda.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelBusqueda.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanelBusqueda.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanelBusqueda.TabIndex = 14;
            this.groupPanelBusqueda.Text = "Búsqueda";
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Buscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Buscar.Image = global::SistemaDeGestion2026.Properties.Resources.icons8_búsqueda_96;
            this.BTN_Buscar.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTN_Buscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_Buscar.Location = new System.Drawing.Point(272, 12);
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(25, 23);
            this.BTN_Buscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Buscar.TabIndex = 14;
            // 
            // TXT_Filtrar
            // 
            this.TXT_Filtrar.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TXT_Filtrar.Border.Class = "TextBoxBorder";
            this.TXT_Filtrar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXT_Filtrar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_Filtrar.DisabledBackColor = System.Drawing.Color.White;
            this.TXT_Filtrar.ForeColor = System.Drawing.Color.Black;
            this.TXT_Filtrar.Location = new System.Drawing.Point(107, 12);
            this.TXT_Filtrar.Name = "TXT_Filtrar";
            this.TXT_Filtrar.PreventEnterBeep = true;
            this.TXT_Filtrar.Size = new System.Drawing.Size(159, 22);
            this.TXT_Filtrar.TabIndex = 13;
            this.TXT_Filtrar.WatermarkText = "Datos a Buscar...";
            this.TXT_Filtrar.TextChanged += new System.EventHandler(this.TXT_Filtrar_TextChanged);
            // 
            // IIN_Filas
            // 
            // 
            // 
            // 
            this.IIN_Filas.BackgroundStyle.Class = "DateTimeInputBackground";
            this.IIN_Filas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IIN_Filas.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.IIN_Filas.Increment = 10;
            this.IIN_Filas.Location = new System.Drawing.Point(21, 12);
            this.IIN_Filas.MaxValue = 1000;
            this.IIN_Filas.MinValue = 0;
            this.IIN_Filas.Name = "IIN_Filas";
            this.IIN_Filas.ShowUpDown = true;
            this.IIN_Filas.Size = new System.Drawing.Size(80, 22);
            this.IIN_Filas.TabIndex = 10;
            this.IIN_Filas.Value = 50;
            // 
            // FRM_Persona_Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 461);
            this.ControlBox = false;
            this.Controls.Add(this.expandablePanel1);
            this.Controls.Add(this.DTG_Lista);
            this.Controls.Add(this.EPN_Opciones);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_Persona_Lista";
            this.Text = "FRM_Persona_Lista2";
            this.Load += new System.EventHandler(this.FRM_Persona_Lista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTG_Lista)).EndInit();
            this.EPN_Opciones.ResumeLayout(false);
            this.CMSMenu.ResumeLayout(false);
            this.expandablePanel1.ResumeLayout(false);
            this.groupPanelBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IIN_Filas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.DataGridViewX DTG_Lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Completo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private DevComponents.DotNetBar.ExpandablePanel EPN_Opciones;
        private DevComponents.DotNetBar.ButtonX BTN_Reporte;
        private DevComponents.DotNetBar.ButtonX BTN_Modificar;
        private DevComponents.DotNetBar.ButtonX BTN_Registrar;
        private System.Windows.Forms.ContextMenuStrip CMSMenu;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inhabilitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habilitarToolStripMenuItem;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelBusqueda;
        private DevComponents.DotNetBar.ButtonX BTN_Buscar;
        private DevComponents.DotNetBar.Controls.TextBoxX TXT_Filtrar;
        private DevComponents.Editors.IntegerInput IIN_Filas;
    }
}