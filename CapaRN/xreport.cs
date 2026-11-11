using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//librerías PDF
using iTextSharp.text;
using iTextSharp.text.pdf;
//libreria para crear y escribir en archivos
using System.IO;
using System.Windows.Forms;
//Libreria para acceso a datos
using System.Data.Common;
//Libreria para acceso a Capa de Acceso a Dato


namespace CapaRN
{
    public class xreport
    {
        #region Campos
        private string _titulo;
        private string _descripcion;
        private bool _hoja;
        private bool _orientacion;
        private int _letra = 10;
        #endregion

        #region Propiedades
        public string titulo { get => _titulo; set => _titulo = value; }
        public string descripcion { get => _descripcion; set => _descripcion = value; }
        public bool hoja { get => _hoja; set => _hoja = value; }
        public bool orientacion { get => _orientacion; set => _orientacion = value; }
        public int letra { get => _letra; set => _letra = value; }
        #endregion

        #region Constructor
        public xreport()
        {
            this.titulo = "";
            this.descripcion = "";
            this.hoja = true;
            this.orientacion = true;
            this.letra = 0;
        }
        #endregion

        #region Métodos
        public void generarReporte(int columnas, float[] anchoColumnas, List<string> titulosColumnas, List<aperson> Lista)
        {
            SaveFileDialog Guardar = new SaveFileDialog();
            Guardar.Title = "Nombre del archivo a guardar";
            Guardar.Filter = "Archivo PDF|*.pdf";

            if (Guardar.ShowDialog() == DialogResult.OK)
            {
                iTextSharp.text.Rectangle Hoja = new iTextSharp.text.Rectangle(0, 0, 0, 0);
                if (this.hoja)
                { Hoja = PageSize.A4; }
                else
                { Hoja = PageSize.LETTER; }

                if (this.orientacion)
                {
                    Hoja = Hoja.Rotate();
                }
                iTextSharp.text.Font Fondo11 = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN,
                                                                            9,
                                                                            iTextSharp.text.Font.BOLD | iTextSharp.text.Font.ITALIC,
                                                                            new iTextSharp.text.Color(System.Drawing.Color.Gray));
                //1er. PASO: Crear el Documento PDF
                iTextSharp.text.Document Documento = new iTextSharp.text.Document(Hoja, 24, 24, 24, 24);

                //2do. PASO: Crear un escritor de documento PDF
                PdfWriter escritor = PdfWriter.GetInstance(Documento, new FileStream(Guardar.FileName, FileMode.Create));

                HeaderFooter footer = new HeaderFooter(new Phrase("SurMarket V 1.0 - Página Nº ", Fondo11), true);
                footer.Alignment = Element.ALIGN_RIGHT;
                footer.BorderColor = new iTextSharp.text.Color(System.Drawing.Color.Gray);
                footer.BorderWidthBottom = 0;

                Documento.Footer = footer;

                //3er. PASO: Abrir el documento para escritura
                Documento.Open();

                iTextSharp.text.Font Fondo1 = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN,
                                                                            13,
                                                                            iTextSharp.text.Font.BOLD | iTextSharp.text.Font.ITALIC,
                                                                            new iTextSharp.text.Color(System.Drawing.Color.Gray));

                iTextSharp.text.Font Fondo2 = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN,
                                                                            letra,
                                                                            iTextSharp.text.Font.BOLD,
                                                                            new iTextSharp.text.Color(System.Drawing.Color.Black));

                iTextSharp.text.Font Fondo3 = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN,
                                                                            letra,
                                                                            iTextSharp.text.Font.NORMAL,
                                                                            new iTextSharp.text.Color(System.Drawing.Color.Black));

                iTextSharp.text.Font Fondo22 = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN,
                                                                            12,
                                                                            iTextSharp.text.Font.BOLD,
                                                                            new iTextSharp.text.Color(System.Drawing.Color.Black));

                iTextSharp.text.Font Fondo33 = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN,
                                                                            12,
                                                                            iTextSharp.text.Font.NORMAL,
                                                                            new iTextSharp.text.Color(System.Drawing.Color.Black));


                iTextSharp.text.Font FondoT = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN,
                                                                            14,
                                                                            iTextSharp.text.Font.BOLD,
                                                                            new iTextSharp.text.Color(System.Drawing.Color.Black));

                //4to. PASO: Escribir en el Documento

                //Encabezado del reporte
                Table Tabla = new Table(2);
                Tabla.Width = 50;
                Tabla.Alignment = Element.ALIGN_LEFT;
                float[] AnchosDeTabla = { 20, 80 };
                Tabla.Widths = AnchosDeTabla;
                Tabla.BorderColor = new iTextSharp.text.Color(System.Drawing.Color.White);

                iTextSharp.text.Image Foto = iTextSharp.text.Image.GetInstance(
                                            Application.StartupPath + "\\imagenes\\ic_cliente.png");
                Foto.Alignment = Element.ALIGN_CENTER;
                Foto.ScaleToFit(50, 70);

                Cell Celda = new Cell(Foto);
                Celda.BorderColor = new iTextSharp.text.Color(System.Drawing.Color.White);
                Tabla.AddCell(Celda);

                Celda = new Cell();
                Celda.Add(new Paragraph(13, "Sistema de Gestión SUR MARKET \n" +
                                        "Entre Rios - Bolivia \n", Fondo1));
                Celda.Add(new Paragraph(9, "Rep.Gen.: " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss") + " \n", Fondo11));

                Celda.VerticalAlignment = Element.ALIGN_MIDDLE;
                Celda.BorderColor = new iTextSharp.text.Color(System.Drawing.Color.White);
                Tabla.AddCell(Celda);
                Documento.Add(Tabla);

                //Titulo del reporte
                Paragraph Parrafo = new Paragraph(titulo + " \n", FondoT);
                Parrafo.Alignment = Element.ALIGN_CENTER;
                Documento.Add(Parrafo);

                //Descripción del reporte
                Tabla = new Table(2);
                Tabla.Width = 100;
                Tabla.Alignment = Element.ALIGN_LEFT;
                float[] AnchosDeTabla3 = { 20, 80 };
                Tabla.Widths = AnchosDeTabla3;
                Tabla.BorderColor = new iTextSharp.text.Color(System.Drawing.Color.White);

                Celda = new Cell(new Phrase(12, "Descripción del Reporte: ", Fondo22));
                Celda.HorizontalAlignment = Element.ALIGN_LEFT;
                Celda.VerticalAlignment = Element.ALIGN_MIDDLE;
                Celda.BorderColor = new iTextSharp.text.Color(System.Drawing.Color.White);
                Tabla.AddCell(Celda);

                Celda = new Cell(new Phrase(12, this.descripcion, Fondo33));
                Celda.HorizontalAlignment = Element.ALIGN_LEFT;
                Celda.VerticalAlignment = Element.ALIGN_MIDDLE;
                Celda.BorderColor = new iTextSharp.text.Color(System.Drawing.Color.White);
                Tabla.AddCell(Celda);

                Documento.Add(Tabla);

                //Contenido del reporte - Titulos de columnas
                Tabla = new Table(columnas);

                Tabla.Widths = anchoColumnas;
                Tabla.Alignment = Element.ALIGN_LEFT;
                Tabla.BorderColor = new iTextSharp.text.Color(System.Drawing.Color.Black);
                Tabla.BorderWidth = 1.5F;
                Tabla.Width = 100;
                Tabla.DefaultCellBorderColor = new iTextSharp.text.Color(System.Drawing.Color.Black);
                Tabla.Cellpadding = 2;


                foreach (string a in titulosColumnas)
                {
                    Celda = new Cell(new Phrase(10, a, Fondo2));
                    Celda.BorderWidth = 1.5F;
                    Celda.HorizontalAlignment = Element.ALIGN_CENTER;
                    Celda.VerticalAlignment = Element.ALIGN_MIDDLE;
                    Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.LightGray);
                    Tabla.AddCell(Celda);
                }


                //Contenido del reporte - Datos de las columnas


                int j = 0;
                bool ban = false;
                foreach (aperson P in Lista)
                {
                    Celda = new Cell(new Paragraph(P.papscodper.Substring(0, 7) + Convert.ToInt32(P.papscodper.Substring(7, P.papscodper.Length - 7)).ToString(), Fondo3));
                    if (!P.capsestper) { Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.AliceBlue); }
                    else if (j % 2 == 0) { Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.AliceBlue); }
                    Tabla.AddCell(Celda);

                    if (P.capsestper)
                    {
                        Celda = new Cell(new Paragraph("Habilitado", Fondo3));
                        if (j % 2 == 0) { Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.AliceBlue); }
                    }
                    else
                    {
                        Celda = new Cell(new Paragraph("Inhabilitado", Fondo3));
                        if (j % 2 == 0) { Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.AliceBlue); }
                    }
                    Celda.HorizontalAlignment = Element.ALIGN_CENTER;
                    Tabla.AddCell(Celda);

                    Celda = new Cell(new Paragraph(P.capsnumcid, Fondo3));
                    if (j % 2 == 0) { Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.AliceBlue); }
                    Tabla.AddCell(Celda);

                    Celda = new Cell(new Paragraph(P.capsapepat, Fondo3));
                    if (j % 2 == 0) { Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.AliceBlue); }
                    Tabla.AddCell(Celda);

                    Celda = new Cell(new Paragraph(P.capsapemat, Fondo3));
                    if (j % 2 == 0) { Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.AliceBlue); }
                    Tabla.AddCell(Celda);

                    Celda = new Cell(new Paragraph(P.capsnomper, Fondo3));
                    if (j % 2 == 0) { Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.AliceBlue); }
                    Tabla.AddCell(Celda);

                    Celda = new Cell(new Paragraph(P.capsfecnac.ToShortDateString(), Fondo3));
                    if (j % 2 == 0) { Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.AliceBlue); }
                    Celda.HorizontalAlignment = Element.ALIGN_CENTER;
                    Tabla.AddCell(Celda);

                    if (P.capssexper)
                    {
                        Celda = new Cell(new Paragraph("Masculino", Fondo3));
                        if (j % 2 == 0) { Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.AliceBlue); }
                    }
                    else
                    {
                        Celda = new Cell(new Paragraph("Femenino", Fondo3));
                        if (j % 2 == 0) { Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.AliceBlue); }

                    }
                    Celda.HorizontalAlignment = Element.ALIGN_CENTER;
                    Tabla.AddCell(Celda);
                    j++;


                }












                Documento.Add(Tabla);

                //5to. PASO: Cerrar el Documento
                Documento.Close();

                //MOSTRAR MENSAJE

                // iniciamos la instancia de la clase process
                System.Diagnostics.Process proc = new System.Diagnostics.Process();

                // nombre del archivo a abrir
                proc.StartInfo.FileName = Guardar.FileName;

                // arrancamos el proceso
                proc.Start();

                // liberamos recursos
                proc.Close();   // atención: close no termina el proceso
            }
        }
        public void generarReporte(int columnas, float[] anchoColumnas, List<string> titulosColumnas, List<lproduc> Lista)
        {
        SaveFileDialog Guardar = new SaveFileDialog();
        Guardar.Title = "Nombre del archivo a guardar";
        Guardar.Filter = "Archivo PDF|*.pdf";

        if (Guardar.ShowDialog() == DialogResult.OK)
        {
            iTextSharp.text.Rectangle Hoja = new iTextSharp.text.Rectangle(0, 0, 0, 0);
            if (this.hoja)
            { Hoja = PageSize.A4; }
            else
            { Hoja = PageSize.LETTER; }

            if (this.orientacion)
            {
                Hoja = Hoja.Rotate();
            }
            iTextSharp.text.Font Fondo11 = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN,
                                                                        9,
                                                                        iTextSharp.text.Font.BOLD | iTextSharp.text.Font.ITALIC,
                                                                        new iTextSharp.text.Color(System.Drawing.Color.Gray));
            //1er. PASO: Crear el Documento PDF
            iTextSharp.text.Document Documento = new iTextSharp.text.Document(Hoja, 24, 24, 24, 24);

            //2do. PASO: Crear un escritor de documento PDF
            PdfWriter escritor = PdfWriter.GetInstance(Documento, new FileStream(Guardar.FileName, FileMode.Create));

            HeaderFooter footer = new HeaderFooter(new Phrase("SurMarket V 1.0 - Página Nº ", Fondo11), true);
            footer.Alignment = Element.ALIGN_RIGHT;
            footer.BorderColor = new iTextSharp.text.Color(System.Drawing.Color.Gray);
            footer.BorderWidthBottom = 0;

            Documento.Footer = footer;

            //3er. PASO: Abrir el documento para escritura
            Documento.Open();

            iTextSharp.text.Font Fondo1 = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN,
                                                                        13,
                                                                        iTextSharp.text.Font.BOLD | iTextSharp.text.Font.ITALIC,
                                                                        new iTextSharp.text.Color(System.Drawing.Color.Gray));

            iTextSharp.text.Font Fondo2 = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN,
                                                                        letra,
                                                                        iTextSharp.text.Font.BOLD,
                                                                        new iTextSharp.text.Color(System.Drawing.Color.Black));

            iTextSharp.text.Font Fondo3 = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN,
                                                                        letra,
                                                                        iTextSharp.text.Font.NORMAL,
                                                                        new iTextSharp.text.Color(System.Drawing.Color.Black));

            iTextSharp.text.Font Fondo22 = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN,
                                                                        12,
                                                                        iTextSharp.text.Font.BOLD,
                                                                        new iTextSharp.text.Color(System.Drawing.Color.Black));

            iTextSharp.text.Font Fondo33 = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN,
                                                                        12,
                                                                        iTextSharp.text.Font.NORMAL,
                                                                        new iTextSharp.text.Color(System.Drawing.Color.Black));


            iTextSharp.text.Font FondoT = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN,
                                                                        14,
                                                                        iTextSharp.text.Font.BOLD,
                                                                        new iTextSharp.text.Color(System.Drawing.Color.Black));

            //4to. PASO: Escribir en el Documento

            //Encabezado del reporte
            Table Tabla = new Table(2);
            Tabla.Width = 50;
            Tabla.Alignment = Element.ALIGN_LEFT;
            float[] AnchosDeTabla = { 20, 80 };
            Tabla.Widths = AnchosDeTabla;
            Tabla.BorderColor = new iTextSharp.text.Color(System.Drawing.Color.White);

            iTextSharp.text.Image Foto = iTextSharp.text.Image.GetInstance(
                                        Application.StartupPath + "\\imagenes\\ic_cliente.png");
            Foto.Alignment = Element.ALIGN_CENTER;
            Foto.ScaleToFit(50, 70);

            Cell Celda = new Cell(Foto);
            Celda.BorderColor = new iTextSharp.text.Color(System.Drawing.Color.White);
            Tabla.AddCell(Celda);

            Celda = new Cell();
            Celda.Add(new Paragraph(13, "Sistema de Gestión SUR MARKET \n" +
                                    "Entre Rios - Bolivia \n", Fondo1));
            Celda.Add(new Paragraph(9, "Rep.Gen.: " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss") + " \n", Fondo11));

            Celda.VerticalAlignment = Element.ALIGN_MIDDLE;
            Celda.BorderColor = new iTextSharp.text.Color(System.Drawing.Color.White);
            Tabla.AddCell(Celda);
            Documento.Add(Tabla);

            //Titulo del reporte
            Paragraph Parrafo = new Paragraph(titulo + " \n", FondoT);
            Parrafo.Alignment = Element.ALIGN_CENTER;
            Documento.Add(Parrafo);

            //Descripción del reporte
            Tabla = new Table(2);
            Tabla.Width = 100;
            Tabla.Alignment = Element.ALIGN_LEFT;
            float[] AnchosDeTabla3 = { 20, 80 };
            Tabla.Widths = AnchosDeTabla3;
            Tabla.BorderColor = new iTextSharp.text.Color(System.Drawing.Color.White);

            Celda = new Cell(new Phrase(12, "Descripción del Reporte: ", Fondo22));
            Celda.HorizontalAlignment = Element.ALIGN_LEFT;
            Celda.VerticalAlignment = Element.ALIGN_MIDDLE;
            Celda.BorderColor = new iTextSharp.text.Color(System.Drawing.Color.White);
            Tabla.AddCell(Celda);

            Celda = new Cell(new Phrase(12, this.descripcion, Fondo33));
            Celda.HorizontalAlignment = Element.ALIGN_LEFT;
            Celda.VerticalAlignment = Element.ALIGN_MIDDLE;
            Celda.BorderColor = new iTextSharp.text.Color(System.Drawing.Color.White);
            Tabla.AddCell(Celda);

            Documento.Add(Tabla);

            //Contenido del reporte - Titulos de columnas
            Tabla = new Table(columnas);

            Tabla.Widths = anchoColumnas;
            Tabla.Alignment = Element.ALIGN_LEFT;
            Tabla.BorderColor = new iTextSharp.text.Color(System.Drawing.Color.Black);
            Tabla.BorderWidth = 1.5F;
            Tabla.Width = 100;
            Tabla.DefaultCellBorderColor = new iTextSharp.text.Color(System.Drawing.Color.Black);
            Tabla.Cellpadding = 2;


            foreach (string a in titulosColumnas)
            {
                Celda = new Cell(new Phrase(10, a, Fondo2));
                Celda.BorderWidth = 1.5F;
                Celda.HorizontalAlignment = Element.ALIGN_CENTER;
                Celda.VerticalAlignment = Element.ALIGN_MIDDLE;
                Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.LightGray);
                Tabla.AddCell(Celda);
            }


            //Contenido del reporte - Datos de las columnas


            int j = 0;
            bool ban = false;
            foreach (lproduc P in Lista)
            {
                Celda = new Cell(new Paragraph(P.papdcodpro.Substring(0, 7) + Convert.ToInt32(P.papdcodpro.Substring(7, P.papdcodpro.Length - 7)).ToString(), Fondo3));
                if (!P.capdestpro) { Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.AliceBlue); }
                else if (j % 2 == 0) { Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.AliceBlue); }
                Tabla.AddCell(Celda);

                if (P.capdestpro)
                {
                    Celda = new Cell(new Paragraph("Habilitado", Fondo3));
                    if (j % 2 == 0) { Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.AliceBlue); }
                }
                else
                {
                    Celda = new Cell(new Paragraph("Inhabilitado", Fondo3));
                    if (j % 2 == 0) { Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.AliceBlue); }
                }
                Celda.HorizontalAlignment = Element.ALIGN_CENTER;
                Tabla.AddCell(Celda);

                Celda = new Cell(new Paragraph(P.capdmodpro, Fondo3));
                if (j % 2 == 0) { Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.AliceBlue); }
                Tabla.AddCell(Celda);

                Celda = new Cell(new Paragraph(P.capdcodbar, Fondo3));
                if (j % 2 == 0) { Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.AliceBlue); }
                Tabla.AddCell(Celda);

                Celda = new Cell(new Paragraph(P.capdnompro, Fondo3));
                if (j % 2 == 0) { Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.AliceBlue); }
                Tabla.AddCell(Celda);

                Celda = new Cell(new Paragraph(P.cacpnomcat, Fondo3));
                if (j % 2 == 0) { Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.AliceBlue); }
                Tabla.AddCell(Celda);

                Celda = new Cell(new Paragraph(P.capdgenpro, Fondo3));
                if (j % 2 == 0) { Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.AliceBlue); }
                Tabla.AddCell(Celda);

                Celda = new Cell(new Paragraph(P.capdmarpro, Fondo3));
                if (j % 2 == 0) { Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.AliceBlue); }
                Tabla.AddCell(Celda);

                Celda = new Cell(new Paragraph(P.capdcolpro, Fondo3));
                if (j % 2 == 0) { Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.AliceBlue); }
                Tabla.AddCell(Celda);

                Celda = new Cell(new Paragraph(P.capdtalpro, Fondo3));
                if (j % 2 == 0) { Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.AliceBlue); }
                Tabla.AddCell(Celda);

                Celda = new Cell(new Paragraph(P.capdstopro.ToString(), Fondo3));
                if (j % 2 == 0) { Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.AliceBlue); }
                Tabla.AddCell(Celda);

                Celda = new Cell(new Paragraph(P.capdpreven.ToString(), Fondo3));
                if (j % 2 == 0) { Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.AliceBlue); }
                Tabla.AddCell(Celda);

                Celda = new Cell(new Paragraph(P.capddespro, Fondo3));
                if (j % 2 == 0) { Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.AliceBlue); }
                Tabla.AddCell(Celda);

                j++;

            }












            Documento.Add(Tabla);

            //5to. PASO: Cerrar el Documento
            Documento.Close();

            //MOSTRAR MENSAJE

            // iniciamos la instancia de la clase process
            System.Diagnostics.Process proc = new System.Diagnostics.Process();

            // nombre del archivo a abrir
            proc.StartInfo.FileName = Guardar.FileName;

            // arrancamos el proceso
            proc.Start();

            // liberamos recursos
            proc.Close();   // atención: close no termina el proceso
        }
        }

        public void generarReporte(int columnas, float[] anchoColumnas, List<string> titulosColumnas, List<lususis> Lista)
        {
            SaveFileDialog Guardar = new SaveFileDialog();
            Guardar.Title = "Nombre del archivo a guardar";
            Guardar.Filter = "Archivo PDF|*.pdf";

            if (Guardar.ShowDialog() == DialogResult.OK)
            {
                iTextSharp.text.Rectangle Hoja = new iTextSharp.text.Rectangle(0, 0, 0, 0);
                if (this.hoja)
                { Hoja = PageSize.A4; }
                else
                { Hoja = PageSize.LETTER; }

                if (this.orientacion)
                {
                    Hoja = Hoja.Rotate();
                }
                iTextSharp.text.Font Fondo11 = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN,
                                                                            9,
                                                                            iTextSharp.text.Font.BOLD | iTextSharp.text.Font.ITALIC,
                                                                            new iTextSharp.text.Color(System.Drawing.Color.Gray));
                //1er. PASO: Crear el Documento PDF
                iTextSharp.text.Document Documento = new iTextSharp.text.Document(Hoja, 24, 24, 24, 24);

                //2do. PASO: Crear un escritor de documento PDF
                PdfWriter escritor = PdfWriter.GetInstance(Documento, new FileStream(Guardar.FileName, FileMode.Create));

                HeaderFooter footer = new HeaderFooter(new Phrase("SurMarket V 1.0 - Página Nº ", Fondo11), true);
                footer.Alignment = Element.ALIGN_RIGHT;
                footer.BorderColor = new iTextSharp.text.Color(System.Drawing.Color.Gray);
                footer.BorderWidthBottom = 0;

                Documento.Footer = footer;

                //3er. PASO: Abrir el documento para escritura
                Documento.Open();

                iTextSharp.text.Font Fondo1 = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN,
                                                                            13,
                                                                            iTextSharp.text.Font.BOLD | iTextSharp.text.Font.ITALIC,
                                                                            new iTextSharp.text.Color(System.Drawing.Color.Gray));

                iTextSharp.text.Font Fondo2 = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN,
                                                                            letra,
                                                                            iTextSharp.text.Font.BOLD,
                                                                            new iTextSharp.text.Color(System.Drawing.Color.Black));

                iTextSharp.text.Font Fondo3 = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN,
                                                                            letra,
                                                                            iTextSharp.text.Font.NORMAL,
                                                                            new iTextSharp.text.Color(System.Drawing.Color.Black));

                iTextSharp.text.Font Fondo22 = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN,
                                                                            12,
                                                                            iTextSharp.text.Font.BOLD,
                                                                            new iTextSharp.text.Color(System.Drawing.Color.Black));

                iTextSharp.text.Font Fondo33 = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN,
                                                                            12,
                                                                            iTextSharp.text.Font.NORMAL,
                                                                            new iTextSharp.text.Color(System.Drawing.Color.Black));


                iTextSharp.text.Font FondoT = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN,
                                                                            14,
                                                                            iTextSharp.text.Font.BOLD,
                                                                            new iTextSharp.text.Color(System.Drawing.Color.Black));

                //4to. PASO: Escribir en el Documento

                //Encabezado del reporte
                Table Tabla = new Table(2);
                Tabla.Width = 50;
                Tabla.Alignment = Element.ALIGN_LEFT;
                float[] AnchosDeTabla = { 20, 80 };
                Tabla.Widths = AnchosDeTabla;
                Tabla.BorderColor = new iTextSharp.text.Color(System.Drawing.Color.White);

                iTextSharp.text.Image Foto = iTextSharp.text.Image.GetInstance(
                                            Application.StartupPath + "\\imagenes\\ic_cliente.png");
                Foto.Alignment = Element.ALIGN_CENTER;
                Foto.ScaleToFit(50, 70);

                Cell Celda = new Cell(Foto);
                Celda.BorderColor = new iTextSharp.text.Color(System.Drawing.Color.White);
                Tabla.AddCell(Celda);

                Celda = new Cell();
                Celda.Add(new Paragraph(13, "Sistema de Gestión SUR MARKET \n" +
                                        "Entre Rios - Bolivia \n", Fondo1));
                Celda.Add(new Paragraph(9, "Rep.Gen.: " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss") + " \n", Fondo11));

                Celda.VerticalAlignment = Element.ALIGN_MIDDLE;
                Celda.BorderColor = new iTextSharp.text.Color(System.Drawing.Color.White);
                Tabla.AddCell(Celda);
                Documento.Add(Tabla);

                //Titulo del reporte
                Paragraph Parrafo = new Paragraph(titulo + " \n", FondoT);
                Parrafo.Alignment = Element.ALIGN_CENTER;
                Documento.Add(Parrafo);

                //Descripción del reporte
                Tabla = new Table(2);
                Tabla.Width = 100;
                Tabla.Alignment = Element.ALIGN_LEFT;
                float[] AnchosDeTabla3 = { 20, 80 };
                Tabla.Widths = AnchosDeTabla3;
                Tabla.BorderColor = new iTextSharp.text.Color(System.Drawing.Color.White);

                Celda = new Cell(new Phrase(12, "Descripción del Reporte: ", Fondo22));
                Celda.HorizontalAlignment = Element.ALIGN_LEFT;
                Celda.VerticalAlignment = Element.ALIGN_MIDDLE;
                Celda.BorderColor = new iTextSharp.text.Color(System.Drawing.Color.White);
                Tabla.AddCell(Celda);

                Celda = new Cell(new Phrase(12, this.descripcion, Fondo33));
                Celda.HorizontalAlignment = Element.ALIGN_LEFT;
                Celda.VerticalAlignment = Element.ALIGN_MIDDLE;
                Celda.BorderColor = new iTextSharp.text.Color(System.Drawing.Color.White);
                Tabla.AddCell(Celda);

                Documento.Add(Tabla);

                //Contenido del reporte - Titulos de columnas
                Tabla = new Table(columnas);

                Tabla.Widths = anchoColumnas;
                Tabla.Alignment = Element.ALIGN_LEFT;
                Tabla.BorderColor = new iTextSharp.text.Color(System.Drawing.Color.Black);
                Tabla.BorderWidth = 1.5F;
                Tabla.Width = 100;
                Tabla.DefaultCellBorderColor = new iTextSharp.text.Color(System.Drawing.Color.Black);
                Tabla.Cellpadding = 2;


                foreach (string a in titulosColumnas)
                {
                    Celda = new Cell(new Phrase(10, a, Fondo2));
                    Celda.BorderWidth = 1.5F;
                    Celda.HorizontalAlignment = Element.ALIGN_CENTER;
                    Celda.VerticalAlignment = Element.ALIGN_MIDDLE;
                    Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.LightGray);
                    Tabla.AddCell(Celda);
                }


                //Contenido del reporte - Datos de las columnas


                int j = 0;
                bool ban = false;
                foreach (lususis P in Lista)
                {
                    Celda = new Cell(new Paragraph(P.pauscodusu.Substring(0, 7) + Convert.ToInt32(P.pauscodusu.Substring(7, P.pauscodusu.Length - 7)).ToString(), Fondo3));
                    if (!P.causestusu) { Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.AliceBlue); }
                    else if (j % 2 == 0) { Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.AliceBlue); }
                    Tabla.AddCell(Celda);

                    if (P.causestusu)
                    {
                        Celda = new Cell(new Paragraph("Habilitado", Fondo3));
                        if (j % 2 == 0) { Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.AliceBlue); }
                    }
                    else
                    {
                        Celda = new Cell(new Paragraph("Inhabilitado", Fondo3));
                        if (j % 2 == 0) { Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.AliceBlue); }
                    }
                    Celda.HorizontalAlignment = Element.ALIGN_CENTER;
                    Tabla.AddCell(Celda);

                    Celda = new Cell(new Paragraph(P.capsnumcid, Fondo3));
                    if (j % 2 == 0) { Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.AliceBlue); }
                    Tabla.AddCell(Celda);

                    Celda = new Cell(new Paragraph(P.capsapepat+" "+P.capsapemat+" "+P.capsnomper, Fondo3));
                    if (j % 2 == 0) { Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.AliceBlue); }
                    Tabla.AddCell(Celda);

                    Celda = new Cell(new Paragraph(P.causnomlog, Fondo3));
                    if (j % 2 == 0) { Celda.BackgroundColor = new iTextSharp.text.Color(System.Drawing.Color.AliceBlue); }
                    Tabla.AddCell(Celda);
                    j++;


                }












                Documento.Add(Tabla);

                //5to. PASO: Cerrar el Documento
                Documento.Close();

                //MOSTRAR MENSAJE

                // iniciamos la instancia de la clase process
                System.Diagnostics.Process proc = new System.Diagnostics.Process();

                // nombre del archivo a abrir
                proc.StartInfo.FileName = Guardar.FileName;

                // arrancamos el proceso
                proc.Start();

                // liberamos recursos
                proc.Close();   // atención: close no termina el proceso
            }
        }
        #endregion

    }
}
