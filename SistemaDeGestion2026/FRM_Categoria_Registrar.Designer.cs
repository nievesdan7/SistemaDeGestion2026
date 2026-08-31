namespace SistemaDeGestion2026
{
    partial class FRM_Categoria_Registrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Categoria_Registrar));
            this.GP_Panel_Categoria = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.BTN_Salir = new DevComponents.DotNetBar.ButtonX();
            this.BTN_Grabar = new DevComponents.DotNetBar.ButtonX();
            this.TXT_NombreCategoria = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SWB_Estado = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.GP_Panel_Categoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // GP_Panel_Categoria
            // 
            this.GP_Panel_Categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GP_Panel_Categoria.CanvasColor = System.Drawing.SystemColors.Control;
            this.GP_Panel_Categoria.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.GP_Panel_Categoria.Controls.Add(this.BTN_Salir);
            this.GP_Panel_Categoria.Controls.Add(this.BTN_Grabar);
            this.GP_Panel_Categoria.Controls.Add(this.TXT_NombreCategoria);
            this.GP_Panel_Categoria.Controls.Add(this.SWB_Estado);
            this.GP_Panel_Categoria.DisabledBackColor = System.Drawing.Color.Empty;
            this.GP_Panel_Categoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GP_Panel_Categoria.Location = new System.Drawing.Point(0, 0);
            this.GP_Panel_Categoria.Name = "GP_Panel_Categoria";
            this.GP_Panel_Categoria.Size = new System.Drawing.Size(258, 105);
            // 
            // 
            // 
            this.GP_Panel_Categoria.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.GP_Panel_Categoria.Style.BackColorGradientAngle = 90;
            this.GP_Panel_Categoria.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.GP_Panel_Categoria.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GP_Panel_Categoria.Style.BorderBottomWidth = 1;
            this.GP_Panel_Categoria.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GP_Panel_Categoria.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GP_Panel_Categoria.Style.BorderLeftWidth = 1;
            this.GP_Panel_Categoria.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GP_Panel_Categoria.Style.BorderRightWidth = 1;
            this.GP_Panel_Categoria.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GP_Panel_Categoria.Style.BorderTopWidth = 1;
            this.GP_Panel_Categoria.Style.CornerDiameter = 4;
            this.GP_Panel_Categoria.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.GP_Panel_Categoria.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GP_Panel_Categoria.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GP_Panel_Categoria.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.GP_Panel_Categoria.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.GP_Panel_Categoria.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GP_Panel_Categoria.TabIndex = 0;
            this.GP_Panel_Categoria.Text = "Categoria";
            // 
            // BTN_Salir
            // 
            this.BTN_Salir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Salir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Salir.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Salir.Image")));
            this.BTN_Salir.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTN_Salir.Location = new System.Drawing.Point(126, 41);
            this.BTN_Salir.Name = "BTN_Salir";
            this.BTN_Salir.Size = new System.Drawing.Size(116, 31);
            this.BTN_Salir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Salir.TabIndex = 3;
            this.BTN_Salir.Text = "&Salir";
            this.BTN_Salir.Click += new System.EventHandler(this.BTN_Salir_Click);
            // 
            // BTN_Grabar
            // 
            this.BTN_Grabar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Grabar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Grabar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Grabar.Image")));
            this.BTN_Grabar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTN_Grabar.Location = new System.Drawing.Point(9, 41);
            this.BTN_Grabar.Name = "BTN_Grabar";
            this.BTN_Grabar.Size = new System.Drawing.Size(111, 31);
            this.BTN_Grabar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Grabar.TabIndex = 2;
            this.BTN_Grabar.Text = "&Grabar";
            this.BTN_Grabar.Click += new System.EventHandler(this.BTN_Grabar_Click);
            // 
            // TXT_NombreCategoria
            // 
            this.TXT_NombreCategoria.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TXT_NombreCategoria.Border.Class = "TextBoxBorder";
            this.TXT_NombreCategoria.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXT_NombreCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_NombreCategoria.DisabledBackColor = System.Drawing.Color.White;
            this.TXT_NombreCategoria.ForeColor = System.Drawing.Color.Black;
            this.TXT_NombreCategoria.Location = new System.Drawing.Point(106, 12);
            this.TXT_NombreCategoria.Name = "TXT_NombreCategoria";
            this.TXT_NombreCategoria.PreventEnterBeep = true;
            this.TXT_NombreCategoria.Size = new System.Drawing.Size(136, 23);
            this.TXT_NombreCategoria.TabIndex = 1;
            this.TXT_NombreCategoria.WatermarkText = "Nombre de categoría";
            // 
            // SWB_Estado
            // 
            // 
            // 
            // 
            this.SWB_Estado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SWB_Estado.Location = new System.Drawing.Point(9, 12);
            this.SWB_Estado.Name = "SWB_Estado";
            this.SWB_Estado.OffBackColor = System.Drawing.Color.Red;
            this.SWB_Estado.OffText = "Inhabilitado";
            this.SWB_Estado.OffTextColor = System.Drawing.Color.White;
            this.SWB_Estado.OnBackColor = System.Drawing.Color.LimeGreen;
            this.SWB_Estado.OnText = "Habilitado";
            this.SWB_Estado.OnTextColor = System.Drawing.Color.White;
            this.SWB_Estado.Size = new System.Drawing.Size(91, 22);
            this.SWB_Estado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SWB_Estado.TabIndex = 0;
            this.SWB_Estado.Value = true;
            this.SWB_Estado.ValueObject = "Y";
            // 
            // FRM_Categoria_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 105);
            this.Controls.Add(this.GP_Panel_Categoria);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_Categoria_Registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Categoria";
            this.Load += new System.EventHandler(this.FRM_Categoria_Load);
            this.GP_Panel_Categoria.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel GP_Panel_Categoria;
        private DevComponents.DotNetBar.ButtonX BTN_Salir;
        private DevComponents.DotNetBar.ButtonX BTN_Grabar;
        private DevComponents.DotNetBar.Controls.TextBoxX TXT_NombreCategoria;
        private DevComponents.DotNetBar.Controls.SwitchButton SWB_Estado;
    }
}