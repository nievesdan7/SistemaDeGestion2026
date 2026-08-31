using CapaRN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPFP;

namespace SistemaDeGestion2026
{
    public partial class FRM_Iniciar_Sesion_Huella : DevComponents.DotNetBar.Office2007Form
    {

        #region Variables
        public aususis usuario = new aususis();
        public aperson persona = new aperson();
        private lususis lusuario = new lususis();
        private List<lususis> lista_usuarios = new List<lususis>();
        public bool login_exitoso = false;

        #endregion

        #region Constructor
        public FRM_Iniciar_Sesion_Huella()
        {
            InitializeComponent();
        }


        #endregion

        private void VC_Huella_OnComplete(object Control, DPFP.FeatureSet FeatureSet, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            
            lista_usuarios = lusuario.Lista("causestusu=true");
            
            DPFP.Verification.Verification Ver = new DPFP.Verification.Verification();
            DPFP.Verification.Verification.Result Res = new DPFP.Verification.Verification.Result();

            DPFP.Template T = new DPFP.Template();
            bool ban = false;

            foreach (lususis u in lista_usuarios)
            {
                if (u.causnumhu1 > 0)
                {
                    T = new DPFP.Template();
                    T.DeSerialize(Convert.FromBase64String(u.causcodhu1));
                    Ver.Verify(FeatureSet, T, ref Res);
                    if (Res.Verified)
                    {
                        ban = true;
                        lusuario = u;
                        break;
                    }
                }
                else if (u.causnumhu2 > 0)
                {
                    T = new DPFP.Template();
                    T.DeSerialize(Convert.FromBase64String(u.causcodhu2));
                    Ver.Verify(FeatureSet, T, ref Res);
                    if (Res.Verified)
                    {
                        ban = true;
                        lusuario = u;
                        break;
                    }
                }
                else if (u.causnumhu3 > 0)
                {
                    T = new DPFP.Template();
                    T.DeSerialize(Convert.FromBase64String(u.causcodhu3));
                    Ver.Verify(FeatureSet, T, ref Res);
                    if (Res.Verified)
                    {
                        ban = true;
                        lusuario = u;
                        break;
                    }
                }
                else if (u.causnumhu4 > 0)
                {
                    T = new DPFP.Template();
                    T.DeSerialize(Convert.FromBase64String(u.causcodhu4));
                    Ver.Verify(FeatureSet, T, ref Res);
                    if (Res.Verified)
                    {
                        ban = true;
                        lusuario = u;
                        break;
                    }
                }
            }

            if (ban)
            {
                MessageBox.Show("Bienvenido" + lusuario.causnomlog + ""
                                             + lusuario.capsapepat + ""
                                             + lusuario.capsapemat + "",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                usuario.pauscodusu = lusuario.pauscodusu;
                usuario.ObtenerDatos();
                persona.papscodper = lusuario.papscodper;
                persona.ObtenerDatos();
                login_exitoso = true;
                this.Close();
            }
            else {
                MessageBox.Show("Huella no reconocida, por favor intente nuevamente.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
        }

        private void LBLMensaje_Click(object sender, EventArgs e)
        {

        }
    }
}
