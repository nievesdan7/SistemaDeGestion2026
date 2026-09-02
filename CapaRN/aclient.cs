using System;
using System.Collections.Generic;
using System.Text;
//Libreria para acceso a datos
using System.Data.Common; 
//Libreria para acceso a Capa de Acceso a Datos
using CapaAD;

namespace CapaRN
{
	public class aclient {

		#region Campos
            private bool _caclestcli;
            private string _faclcodper;
            private string _caclrazcli;
            private string _caclnitcli;
            private string _cacldircli;
            private string _cacltelcli;
            //Instancia para conexion a PostgreSQL 8.2
            private CLConexionPGSQL Conexion;
		#endregion 

		#region Propiedades
		    public bool caclestcli
            { 
                get{ return this._caclestcli;}
                set{ this._caclestcli = value;}
            } 
		    public string faclcodper
            { 
                get{ return this._faclcodper;}
                set{ this._faclcodper = value;}
            } 
		    public string caclrazcli
            { 
                get{ return this._caclrazcli;}
                set{ this._caclrazcli = value;}
            } 
		    public string caclnitcli
            { 
                get{ return this._caclnitcli;}
                set{ this._caclnitcli = value;}
            } 
		    public string cacldircli
            { 
                get{ return this._cacldircli;}
                set{ this._cacldircli = value;}
            } 
		    public string cacltelcli
            { 
                get{ return this._cacltelcli;}
                set{ this._cacltelcli = value;}
            } 
        #endregion

        #region Constructor
            public aclient()
            { 
		        this._caclestcli = true;
		        this._faclcodper = "";
		        this._caclrazcli = "";
		        this._caclnitcli = "";
		        this._cacldircli = "";
		        this._cacltelcli = "";
                this.Conexion = new CLConexionPGSQL();            } 
        #endregion

        #region Metodos
            public bool ObtenerDatos() 
            { 
                this.Conexion.Conectar();
			    string sql = "select " +
                                     "caclestcli," +
                                     "faclcodper," +
                                     "caclrazcli," +
                                     "caclnitcli," +
                                     "cacldircli," +
                                     "cacltelcli " + 
                             "from aclient " +
                             "where " +
                                    "faclcodper = @faclcodper";

                this.Conexion.PrepararComando(sql);

                this.Conexion.AsignarParametroCadena("@faclcodper", this._faclcodper);
                DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

                if (ResultadoConsulta.Read())
                {
                    this._caclestcli=ResultadoConsulta.GetBoolean(0);
                    this._faclcodper=ResultadoConsulta.GetString(1);
                    this._caclrazcli=ResultadoConsulta.GetString(2);
                    this._caclnitcli=ResultadoConsulta.GetString(3);
                    this._cacldircli=ResultadoConsulta.GetString(4);
                    this._cacltelcli=ResultadoConsulta.GetString(5);
                    this.Conexion.Desconectar();

                    return true;
                }
                else
                {
                    this.Conexion.Desconectar();
                    return false;
                }
            }
            public bool VerificarExistencia()
            { 
                this.Conexion.Conectar(); 
			    string sql = "select " + 
                                     "caclestcli," +
                                     "faclcodper," +
                                     "caclrazcli," +
                                     "caclnitcli," +
                                     "cacldircli," +
                                     "cacltelcli " + 
                             "from aclient " +
                             "where " +
                                    "faclcodper = @faclcodper";

                this.Conexion.PrepararComando(sql);
                this.Conexion.AsignarParametroCadena("@faclcodper", this._faclcodper);

                DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

                if (ResultadoConsulta.HasRows)
                {
                this.Conexion.Desconectar();

                    return true;
                }
                else 
                { 

                this.Conexion.Desconectar();
                    return false;
                } 
            } 
            public bool Grabar()
            {
                try
                {
                    if (this.VerificarExistencia())
                    {
                        return false;
                    }
                    else
                    {
                        this.Conexion.Conectar();
                        string sql = "insert into aclient (" +
                                                           "caclestcli," +
                                                           "faclcodper," +
                                                           "caclrazcli," +
                                                           "caclnitcli," +
                                                           "cacldircli," +
                                                           "cacltelcli" +
                                                           ") " +
                                     "values (" +
                                              "@caclestcli," +
                                              "@faclcodper," +
                                              "@caclrazcli," +
                                              "@caclnitcli," +
                                              "@cacldircli," +
                                              "@cacltelcli" +
                                                           ")";

                        this.Conexion.PrepararComando(sql);

                        this.Conexion.AsignarParametroLogico("@caclestcli", this._caclestcli);
                        this.Conexion.AsignarParametroCadena("@faclcodper", this._faclcodper);
                        this.Conexion.AsignarParametroCadena("@caclrazcli", this._caclrazcli);
                        this.Conexion.AsignarParametroCadena("@caclnitcli", this._caclnitcli);
                        this.Conexion.AsignarParametroCadena("@cacldircli", this._cacldircli);
                        this.Conexion.AsignarParametroCadena("@cacltelcli", this._cacltelcli);

                        this.Conexion.EjecutarTransaccion();
                        this.Conexion.Desconectar();

                        return true;
                    }
                }
                catch (Exception ex)
                {
                    this.Conexion.Desconectar();
                    System.Windows.Forms.MessageBox.Show("Error SQL en acatego: " + ex.Message, "Error BD");
                    return false;
                }
            }
            public bool Grabar2()
            {
                try
                {
                    
                        this.Conexion.Conectar();
                        string sql = "insert into aclient (" +
                                                           "caclestcli," +
                                                           "faclcodper," +
                                                           "caclrazcli," +
                                                           "caclnitcli," +
                                                           "cacldircli," +
                                                           "cacltelcli" +
                                                           ") " +
                                     "values (" +
                                              "@caclestcli," +
                                              "@faclcodper," +
                                              "@caclrazcli," +
                                              "@caclnitcli," +
                                              "@cacldircli," +
                                              "@cacltelcli" +
                                                           ")";

                        this.Conexion.PrepararComando(sql);

                        this.Conexion.AsignarParametroLogico("@caclestcli", this._caclestcli);
                        this.Conexion.AsignarParametroCadena("@faclcodper", this._faclcodper);
                        this.Conexion.AsignarParametroCadena("@caclrazcli", this._caclrazcli);
                        this.Conexion.AsignarParametroCadena("@caclnitcli", this._caclnitcli);
                        this.Conexion.AsignarParametroCadena("@cacldircli", this._cacldircli);
                        this.Conexion.AsignarParametroCadena("@cacltelcli", this._cacltelcli);

                        this.Conexion.EjecutarTransaccion();
                        this.Conexion.Desconectar();

                        return true;
                    
                }
                catch (Exception ex)
                {
                    this.Conexion.Desconectar();
                    System.Windows.Forms.MessageBox.Show("Error SQL en acatego: " + ex.Message, "Error BD");
                    return false;
                }
            }
            public bool Modificar()
            {
                try
                {
                    this.Conexion.Conectar();
			            string sql = "update aclient set " +
                                                         "caclestcli = @caclestcli, " +
                                                         "faclcodper = @faclcodper, " +
                                                         "caclrazcli = @caclrazcli, " +
                                                         "caclnitcli = @caclnitcli, " +
                                                         "cacldircli = @cacldircli, " +
                                                         "cacltelcli = @cacltelcli " +
                                     " ";

                    this.Conexion.PrepararComando(sql); 

                    this.Conexion.AsignarParametroLogico("@caclestcli",this._caclestcli);
                    this.Conexion.AsignarParametroCadena("@faclcodper",this._faclcodper);
                    this.Conexion.AsignarParametroCadena("@caclrazcli",this._caclrazcli);
                    this.Conexion.AsignarParametroCadena("@caclnitcli",this._caclnitcli);
                    this.Conexion.AsignarParametroCadena("@cacldircli",this._cacldircli);
                    this.Conexion.AsignarParametroCadena("@cacltelcli",this._cacltelcli);

                    this.Conexion.EjecutarTransaccion();
                    this.Conexion.Desconectar();

                    return true;
                }
                catch (Exception ex)
                {
                    this.Conexion.Desconectar();
                    System.Windows.Forms.MessageBox.Show("Error SQL en aclient: " + ex.Message, "Error BD");
                    return false;
                }
}

            public bool Modificar2(String a)
            {
                try
                {
                    this.Conexion.Conectar();
                    string sql = "update aclient set " +
                                                     "caclestcli = @caclestcli, " +
                                                     "faclcodper = '" + a + "', " +
                                                     "caclrazcli = @caclrazcli, " +
                                                     "caclnitcli = @caclnitcli, " +
                                                     "cacldircli = @cacldircli, " +
                                                     "cacltelcli = @cacltelcli " +
                                 " where " +
                                    "faclcodper = @faclcodper";

                    this.Conexion.PrepararComando(sql);

                    this.Conexion.AsignarParametroLogico("@caclestcli", this._caclestcli);
                    this.Conexion.AsignarParametroCadena("@faclcodper", this._faclcodper);
                    this.Conexion.AsignarParametroCadena("@caclrazcli", this._caclrazcli);
                    this.Conexion.AsignarParametroCadena("@caclnitcli", this._caclnitcli);
                    this.Conexion.AsignarParametroCadena("@cacldircli", this._cacldircli);
                    this.Conexion.AsignarParametroCadena("@cacltelcli", this._cacltelcli);

                    this.Conexion.EjecutarTransaccion();
                    this.Conexion.Desconectar();

                    return true;
                }
                catch (Exception ex)
                {
                    this.Conexion.Desconectar();
                    System.Windows.Forms.MessageBox.Show("Error SQL en aclient: " + ex.Message, "Error BD");
                    return false;
                }
            }
            public List<aclient> Lista(string where)
                { 
                    List<aclient> ListaResultado = new List<aclient>();
                    this.Conexion.Conectar(); 
			        string sql = "select " + 
                                         "caclestcli," +
                                         "faclcodper," +
                                         "caclrazcli," +
                                         "caclnitcli," +
                                         "cacldircli," +
                                         "cacltelcli " + 
                                 "from aclient " ;
 
                    if (where.Replace(" ", "") != "")
                    {
                        sql+= "where " + where;
                    }

 
                    this.Conexion.PrepararComando(sql); 
                    DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

                    if (ResultadoConsulta!=null)
                    {
                        while (ResultadoConsulta.Read())
                        {
                              aclient Auxiliar = new aclient();
                              Auxiliar.caclestcli = ResultadoConsulta.GetBoolean(0);
                              Auxiliar.faclcodper = ResultadoConsulta.GetString(1);
                              Auxiliar.caclrazcli = ResultadoConsulta.GetString(2);
                              Auxiliar.caclnitcli = ResultadoConsulta.GetString(3);
                              Auxiliar.cacldircli = ResultadoConsulta.GetString(4);
                              Auxiliar.cacltelcli = ResultadoConsulta.GetString(5);
                              ListaResultado.Add(Auxiliar);
                        }

                    }
                    this.Conexion.Desconectar();
                    return ListaResultado;
                } 
        #endregion 

	}
}

