namespace SistemaDeGestion2026
{
    partial class FRMCliente_Buscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMCliente_Buscar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.IIN_Filas = new DevComponents.Editors.IntegerInput();
            this.TXT_Filtrar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.EPN_Filtrar = new DevComponents.DotNetBar.ExpandablePanel();
            this.BTN_Okey = new DevComponents.DotNetBar.ButtonX();
            this.BTN_AgregarPersona = new DevComponents.DotNetBar.ButtonX();
            this.BTN_Buscar = new DevComponents.DotNetBar.ButtonX();
            this.DTG_Lista = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.IIN_Filas)).BeginInit();
            this.EPN_Filtrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_Lista)).BeginInit();
            this.SuspendLayout();
            // 
            // IIN_Filas
            // 
            // 
            // 
            // 
            this.IIN_Filas.BackgroundStyle.Class = "DateTimeInputBackground";
            this.IIN_Filas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IIN_Filas.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.IIN_Filas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IIN_Filas.Increment = 10;
            this.IIN_Filas.Location = new System.Drawing.Point(6, 50);
            this.IIN_Filas.MaxValue = 1000;
            this.IIN_Filas.MinValue = 0;
            this.IIN_Filas.Name = "IIN_Filas";
            this.IIN_Filas.ShowUpDown = true;
            this.IIN_Filas.Size = new System.Drawing.Size(80, 22);
            this.IIN_Filas.TabIndex = 4;
            this.IIN_Filas.Value = 50;
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
            this.TXT_Filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Filtrar.ForeColor = System.Drawing.Color.Black;
            this.TXT_Filtrar.Location = new System.Drawing.Point(92, 50);
            this.TXT_Filtrar.Name = "TXT_Filtrar";
            this.TXT_Filtrar.PreventEnterBeep = true;
            this.TXT_Filtrar.Size = new System.Drawing.Size(159, 22);
            this.TXT_Filtrar.TabIndex = 5;
            this.TXT_Filtrar.WatermarkText = "Datos a Buscar...";
            this.TXT_Filtrar.TextChanged += new System.EventHandler(this.TXT_Filtrar_TextChanged);
            // 
            // EPN_Filtrar
            // 
            this.EPN_Filtrar.CanvasColor = System.Drawing.SystemColors.Control;
            this.EPN_Filtrar.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.EPN_Filtrar.Controls.Add(this.BTN_Okey);
            this.EPN_Filtrar.Controls.Add(this.BTN_AgregarPersona);
            this.EPN_Filtrar.Controls.Add(this.BTN_Buscar);
            this.EPN_Filtrar.Controls.Add(this.TXT_Filtrar);
            this.EPN_Filtrar.Controls.Add(this.IIN_Filas);
            this.EPN_Filtrar.DisabledBackColor = System.Drawing.Color.Empty;
            this.EPN_Filtrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.EPN_Filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EPN_Filtrar.HideControlsWhenCollapsed = true;
            this.EPN_Filtrar.Location = new System.Drawing.Point(0, 0);
            this.EPN_Filtrar.Name = "EPN_Filtrar";
            this.EPN_Filtrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EPN_Filtrar.Size = new System.Drawing.Size(957, 99);
            this.EPN_Filtrar.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.EPN_Filtrar.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.EPN_Filtrar.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.EPN_Filtrar.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.EPN_Filtrar.Style.GradientAngle = 90;
            this.EPN_Filtrar.TabIndex = 19;
            this.EPN_Filtrar.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.EPN_Filtrar.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.EPN_Filtrar.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.EPN_Filtrar.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.EPN_Filtrar.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.EPN_Filtrar.TitleStyle.GradientAngle = 90;
            this.EPN_Filtrar.TitleStyleMouseOver.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EPN_Filtrar.TitleText = "Filtrar";
            // 
            // BTN_Okey
            // 
            this.BTN_Okey.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Okey.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Okey.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Okey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Okey.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Okey.Image")));
            this.BTN_Okey.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTN_Okey.Location = new System.Drawing.Point(318, 50);
            this.BTN_Okey.Name = "BTN_Okey";
            this.BTN_Okey.Size = new System.Drawing.Size(23, 22);
            this.BTN_Okey.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Okey.TabIndex = 17;
            this.BTN_Okey.Click += new System.EventHandler(this.BTN_Okey_Click);
            // 
            // BTN_AgregarPersona
            // 
            this.BTN_AgregarPersona.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_AgregarPersona.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_AgregarPersona.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_AgregarPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AgregarPersona.Image = ((System.Drawing.Image)(resources.GetObject("BTN_AgregarPersona.Image")));
            this.BTN_AgregarPersona.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTN_AgregarPersona.Location = new System.Drawing.Point(290, 50);
            this.BTN_AgregarPersona.Name = "BTN_AgregarPersona";
            this.BTN_AgregarPersona.Size = new System.Drawing.Size(22, 22);
            this.BTN_AgregarPersona.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_AgregarPersona.TabIndex = 16;
            this.BTN_AgregarPersona.Click += new System.EventHandler(this.BTN_AgregarCliente_Click);
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Buscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Buscar.Image = global::SistemaDeGestion2026.Properties.Resources.icons8_búsqueda_962;
            this.BTN_Buscar.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTN_Buscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_Buscar.Location = new System.Drawing.Point(257, 50);
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(27, 22);
            this.BTN_Buscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Buscar.TabIndex = 6;
            this.BTN_Buscar.Click += new System.EventHandler(this.BTN_Buscar_Click);
            // 
            // DTG_Lista
            // 
            this.DTG_Lista.AllowUserToAddRows = false;
            this.DTG_Lista.AllowUserToDeleteRows = false;
            this.DTG_Lista.AllowUserToResizeColumns = false;
            this.DTG_Lista.AllowUserToResizeRows = false;
            this.DTG_Lista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DTG_Lista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DTG_Lista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DTG_Lista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTG_Lista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DTG_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.nit,
            this.dir,
            this.Column4});
            this.DTG_Lista.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DTG_Lista.DefaultCellStyle = dataGridViewCellStyle2;
            this.DTG_Lista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTG_Lista.EnableHeadersVisualStyles = false;
            this.DTG_Lista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.DTG_Lista.Location = new System.Drawing.Point(0, 99);
            this.DTG_Lista.MultiSelect = false;
            this.DTG_Lista.Name = "DTG_Lista";
            this.DTG_Lista.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTG_Lista.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DTG_Lista.RowHeadersVisible = false;
            this.DTG_Lista.RowTemplate.Height = 30;
            this.DTG_Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTG_Lista.Size = new System.Drawing.Size(957, 338);
            this.DTG_Lista.TabIndex = 55;
            this.DTG_Lista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTG_Lista_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Razon Social";
            this.Column3.MinimumWidth = 100;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // nit
            // 
            this.nit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nit.HeaderText = "NIT";
            this.nit.MinimumWidth = 200;
            this.nit.Name = "nit";
            this.nit.ReadOnly = true;
            // 
            // dir
            // 
            this.dir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dir.HeaderText = "Direccion";
            this.dir.MinimumWidth = 120;
            this.dir.Name = "dir";
            this.dir.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Telefono";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // FRMClienteBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 437);
            this.Controls.Add(this.DTG_Lista);
            this.Controls.Add(this.EPN_Filtrar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMClienteBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMClienteBuscar";
            this.Load += new System.EventHandler(this.FRMClienteBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IIN_Filas)).EndInit();
            this.EPN_Filtrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTG_Lista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.Editors.IntegerInput IIN_Filas;
        private DevComponents.DotNetBar.Controls.TextBoxX TXT_Filtrar;
        private DevComponents.DotNetBar.ButtonX BTN_Buscar;
        private DevComponents.DotNetBar.ButtonX BTN_AgregarPersona;
        private DevComponents.DotNetBar.ButtonX BTN_Okey;
        private DevComponents.DotNetBar.ExpandablePanel EPN_Filtrar;
        private DevComponents.DotNetBar.Controls.DataGridViewX DTG_Lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}