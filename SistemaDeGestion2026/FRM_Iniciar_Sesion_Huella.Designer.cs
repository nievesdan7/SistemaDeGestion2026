namespace SistemaDeGestion2026
{
    partial class FRM_Iniciar_Sesion_Huella
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
            this.GP_Panel_Usuario = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.VC_Huella = new DPFP.Gui.Verification.VerificationControl();
            this.LBLMensaje = new DevComponents.DotNetBar.LabelX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GP_Panel_Usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GP_Panel_Usuario
            // 
            this.GP_Panel_Usuario.CanvasColor = System.Drawing.SystemColors.Control;
            this.GP_Panel_Usuario.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GP_Panel_Usuario.Controls.Add(this.VC_Huella);
            this.GP_Panel_Usuario.Controls.Add(this.pictureBox1);
            this.GP_Panel_Usuario.Controls.Add(this.LBLMensaje);
            this.GP_Panel_Usuario.DisabledBackColor = System.Drawing.Color.Empty;
            this.GP_Panel_Usuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GP_Panel_Usuario.Location = new System.Drawing.Point(0, 0);
            this.GP_Panel_Usuario.Name = "GP_Panel_Usuario";
            this.GP_Panel_Usuario.Size = new System.Drawing.Size(579, 382);
            // 
            // 
            // 
            this.GP_Panel_Usuario.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.GP_Panel_Usuario.Style.BackColorGradientAngle = 90;
            this.GP_Panel_Usuario.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.GP_Panel_Usuario.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GP_Panel_Usuario.Style.BorderBottomWidth = 1;
            this.GP_Panel_Usuario.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GP_Panel_Usuario.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GP_Panel_Usuario.Style.BorderLeftWidth = 1;
            this.GP_Panel_Usuario.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GP_Panel_Usuario.Style.BorderRightWidth = 1;
            this.GP_Panel_Usuario.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GP_Panel_Usuario.Style.BorderTopWidth = 1;
            this.GP_Panel_Usuario.Style.CornerDiameter = 4;
            this.GP_Panel_Usuario.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.GP_Panel_Usuario.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GP_Panel_Usuario.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GP_Panel_Usuario.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.GP_Panel_Usuario.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.GP_Panel_Usuario.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GP_Panel_Usuario.TabIndex = 1;
            this.GP_Panel_Usuario.Text = "Usuario";
            // 
            // VC_Huella
            // 
            this.VC_Huella.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.VC_Huella.Location = new System.Drawing.Point(377, 104);
            this.VC_Huella.Margin = new System.Windows.Forms.Padding(4);
            this.VC_Huella.Name = "VC_Huella";
            this.VC_Huella.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000";
            this.VC_Huella.Size = new System.Drawing.Size(47, 47);
            this.VC_Huella.TabIndex = 24;
            this.VC_Huella.OnComplete += new DPFP.Gui.Verification.VerificationControl._OnComplete(this.VC_Huella_OnComplete);
            // 
            // LBLMensaje
            // 
            // 
            // 
            // 
            this.LBLMensaje.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.LBLMensaje.BackgroundStyle.BorderColor = System.Drawing.Color.Black;
            this.LBLMensaje.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.LBLMensaje.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.LBLMensaje.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.LBLMensaje.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBLMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLMensaje.Location = new System.Drawing.Point(9, 23);
            this.LBLMensaje.Name = "LBLMensaje";
            this.LBLMensaje.Size = new System.Drawing.Size(415, 74);
            this.LBLMensaje.TabIndex = 22;
            this.LBLMensaje.Text = "Coloque su huella en el lector biométrico";
            this.LBLMensaje.TextAlignment = System.Drawing.StringAlignment.Center;
            this.LBLMensaje.Click += new System.EventHandler(this.LBLMensaje_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaDeGestion2026.Properties.Resources.icons8_huella_dactilar_100__1_;
            this.pictureBox1.Location = new System.Drawing.Point(431, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // FRM_Iniciar_Sesion_Huella
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 382);
            this.Controls.Add(this.GP_Panel_Usuario);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Iniciar_Sesion_Huella";
            this.Text = "Iniciar Sesión con Huella";
            this.GP_Panel_Usuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel GP_Panel_Usuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.LabelX LBLMensaje;
        private DPFP.Gui.Verification.VerificationControl VC_Huella;
    }
}