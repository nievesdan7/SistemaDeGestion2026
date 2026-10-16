namespace SistemaDeGestion2026
{
    partial class FRMProducto_Buscar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EPN_Filtrar = new DevComponents.DotNetBar.ExpandablePanel();
            this.BTN_Okey = new DevComponents.DotNetBar.ButtonX();
            this.BTN_AgregarProducto = new DevComponents.DotNetBar.ButtonX();
            this.BTN_Buscar = new DevComponents.DotNetBar.ButtonX();
            this.TXT_Filtrar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.IIN_Filas = new DevComponents.Editors.IntegerInput();
            this.DTGLista = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            this.Column7 = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.EPN_Filtrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IIN_Filas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGLista)).BeginInit();
            this.SuspendLayout();
            // 
            // EPN_Filtrar
            // 
            this.EPN_Filtrar.CanvasColor = System.Drawing.SystemColors.Control;
            this.EPN_Filtrar.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.EPN_Filtrar.Controls.Add(this.BTN_Okey);
            this.EPN_Filtrar.Controls.Add(this.BTN_AgregarProducto);
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
            this.EPN_Filtrar.Size = new System.Drawing.Size(976, 93);
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
            this.BTN_Okey.Image = global::SistemaDeGestion2026.Properties.Resources.ico_okey2;
            this.BTN_Okey.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTN_Okey.Location = new System.Drawing.Point(319, 50);
            this.BTN_Okey.Name = "BTN_Okey";
            this.BTN_Okey.Size = new System.Drawing.Size(25, 23);
            this.BTN_Okey.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Okey.TabIndex = 17;
            this.BTN_Okey.Click += new System.EventHandler(this.BTN_Okey_Click);
            // 
            // BTN_AgregarProducto
            // 
            this.BTN_AgregarProducto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_AgregarProducto.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_AgregarProducto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_AgregarProducto.Image = global::SistemaDeGestion2026.Properties.Resources.ic_agregar;
            this.BTN_AgregarProducto.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTN_AgregarProducto.Location = new System.Drawing.Point(288, 50);
            this.BTN_AgregarProducto.Name = "BTN_AgregarProducto";
            this.BTN_AgregarProducto.Size = new System.Drawing.Size(25, 23);
            this.BTN_AgregarProducto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_AgregarProducto.TabIndex = 16;
            this.BTN_AgregarProducto.Click += new System.EventHandler(this.BTN_AgregarProducto_Click);
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Buscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Buscar.Image = global::SistemaDeGestion2026.Properties.Resources.icons8_búsqueda_96;
            this.BTN_Buscar.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTN_Buscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_Buscar.Location = new System.Drawing.Point(257, 50);
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(25, 23);
            this.BTN_Buscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Buscar.TabIndex = 6;
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
            this.TXT_Filtrar.Location = new System.Drawing.Point(92, 50);
            this.TXT_Filtrar.Name = "TXT_Filtrar";
            this.TXT_Filtrar.PreventEnterBeep = true;
            this.TXT_Filtrar.Size = new System.Drawing.Size(159, 23);
            this.TXT_Filtrar.TabIndex = 5;
            this.TXT_Filtrar.WatermarkText = "Datos a Buscar...";
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
            this.IIN_Filas.Location = new System.Drawing.Point(6, 50);
            this.IIN_Filas.MaxValue = 1000;
            this.IIN_Filas.MinValue = 0;
            this.IIN_Filas.Name = "IIN_Filas";
            this.IIN_Filas.ShowUpDown = true;
            this.IIN_Filas.Size = new System.Drawing.Size(80, 23);
            this.IIN_Filas.TabIndex = 4;
            this.IIN_Filas.Value = 50;
            // 
            // DTGLista
            // 
            this.DTGLista.AllowUserToAddRows = false;
            this.DTGLista.AllowUserToDeleteRows = false;
            this.DTGLista.AllowUserToResizeColumns = false;
            this.DTGLista.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DTGLista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DTGLista.BackgroundColor = System.Drawing.Color.White;
            this.DTGLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DTGLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DTGLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTGLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DTGLista.ColumnHeadersHeight = 35;
            this.DTGLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DTGLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column1,
            this.Column11,
            this.Column3,
            this.Column2,
            this.Column12,
            this.Column4,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DTGLista.DefaultCellStyle = dataGridViewCellStyle3;
            this.DTGLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTGLista.EnableHeadersVisualStyles = false;
            this.DTGLista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DTGLista.Location = new System.Drawing.Point(0, 93);
            this.DTGLista.MultiSelect = false;
            this.DTGLista.Name = "DTGLista";
            this.DTGLista.ReadOnly = true;
            this.DTGLista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DTGLista.RowHeadersVisible = false;
            this.DTGLista.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DTGLista.RowTemplate.Height = 35;
            this.DTGLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGLista.Size = new System.Drawing.Size(976, 357);
            this.DTGLista.TabIndex = 119;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Código";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Estado";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.HeaderText = "Categoría";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 119.0927F;
            this.Column3.HeaderText = "Modelo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Marca";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column12.HeaderText = "Material";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Color";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            // 
            // 
            // 
            this.Column6.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.Column6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Column6.HeaderText = "Stock";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            // 
            // 
            // 
            this.Column7.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.Column7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Column7.HeaderText = "Precio Venta";
            this.Column7.Increment = 1D;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // FRMProducto_Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 450);
            this.Controls.Add(this.DTGLista);
            this.Controls.Add(this.EPN_Filtrar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FRMProducto_Buscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Producto_Buscar";
            this.Load += new System.EventHandler(this.FRM_Producto_Buscar_Load);
            this.EPN_Filtrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IIN_Filas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.ExpandablePanel EPN_Filtrar;
        private DevComponents.DotNetBar.ButtonX BTN_Okey;
        private DevComponents.DotNetBar.ButtonX BTN_AgregarProducto;
        private DevComponents.DotNetBar.ButtonX BTN_Buscar;
        private DevComponents.DotNetBar.Controls.TextBoxX TXT_Filtrar;
        private DevComponents.Editors.IntegerInput IIN_Filas;
        private System.Windows.Forms.DataGridView DTGLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn Column6;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn Column7;
    }
}