using System;
using System.Collections.Generic;
using System.Text;
//Libreria para acceso a datos
using System.Data.Common; 
//Libreria para acceso a Capa de Acceso a Datos
using CapaAD;

namespace CapaRN
{
	public class aprovee {

		#region Campos
            private bool _capvestprv;
            private string _fapvcodper;
            private string _capvrazprv;
            private string _capvnirprv;
            private string _capvdirprv;
            private string _capvtelprv;
            //Instancia para conexion a PostgreSQL 8.2
            private CLConexionPGSQL Conexion;
		#endregion 

		#region Propiedades
		    public bool capvestprv
            { 
                get{ return this._capvestprv;}
                set{ this._capvestprv = value;}
            } 
		    public string fapvcodper
            { 
                get{ return this._fapvcodper;}
                set{ this._fapvcodper = value;}
            } 
		    public string capvrazprv
            { 
                get{ return this._capvrazprv;}
                set{ this._capvrazprv = value;}
            } 
		    public string capvnirprv
            { 
                get{ return this._capvnirprv;}
                set{ this._capvnirprv = value;}
            } 
		    public string capvdirprv
            { 
                get{ return this._capvdirprv;}
                set{ this._capvdirprv = value;}
            } 
		    public string capvtelprv
            { 
                get{ return this._capvtelprv;}
                set{ this._capvtelprv = value;}
            } 
        #endregion

        #region Constructor
            public aprovee()
            { 
		        this._capvestprv = true;
		        this._fapvcodper = "";
		        this._capvrazprv = "";
		        this._capvnirprv = "";
		        this._capvdirprv = "";
		        this._capvtelprv = "";
                this.Conexion = new CLConexionPGSQL();            } 
        #endregion

        #region Metodos
            public bool ObtenerDatos() 
            { 
                this.Conexion.Conectar();
			    string sql = "select " +
                                     "capvestprv," +
                                     "fapvcodper," +
                                     "capvrazprv," +
                                     "capvnirprv," +
                                     "capvdirprv," +
                                     "capvtelprv " + 
                             "from aprovee " +
                             "where " +
                                    "fapvcodper = @fapvcodper";

            this.Conexion.PrepararComando(sql);

            this.Conexion.AsignarParametroCadena("@fapvcodper", this._fapvcodper);
            DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

                if (ResultadoConsulta.Read())
                {
                    this._capvestprv=ResultadoConsulta.GetBoolean(0);
                    this._fapvcodper=ResultadoConsulta.GetString(1);
                    this._capvrazprv=ResultadoConsulta.GetString(2);
                    this._capvnirprv=ResultadoConsulta.GetString(3);
                    this._capvdirprv=ResultadoConsulta.GetString(4);
                    this._capvtelprv=ResultadoConsulta.GetString(5);
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
                                     "capvestprv," +
                                     "fapvcodper," +
                                     "capvrazprv," +
                                     "capvnirprv," +
                                     "capvdirprv," +
                                     "capvtelprv " + 
                             "from aprovee " +
                             "where " +
                                    "fapvcodper = @fapvcodper";

            this.Conexion.PrepararComando(sql);

            this.Conexion.AsignarParametroCadena("@fapvcodper", this._fapvcodper);
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
                if (this.VerificarExistencia())
                {
                    return false;
                }
                else 
                { 
                    this.Conexion.Conectar();
			        string sql = "insert into aprovee (" +
                                                       "capvestprv," +
                                                       "fapvcodper," +
                                                       "capvrazprv," +
                                                       "capvnirprv," +
                                                       "capvdirprv," +
                                                       "capvtelprv" +
                                                       ") " +
	                             "values (" + 
                                          "@capvestprv," +
                                          "@fapvcodper," +
                                          "@capvrazprv," +
                                          "@capvnirprv," +
                                          "@capvdirprv," +
                                          "@capvtelprv" +
                                                       ")";

                    this.Conexion.PrepararComando(sql);

                    this.Conexion.AsignarParametroLogico("@capvestprv",this._capvestprv);
                    this.Conexion.AsignarParametroCadena("@fapvcodper",this._fapvcodper);
                    this.Conexion.AsignarParametroCadena("@capvrazprv",this._capvrazprv);
                    this.Conexion.AsignarParametroCadena("@capvnirprv",this._capvnirprv);
                    this.Conexion.AsignarParametroCadena("@capvdirprv",this._capvdirprv);
                    this.Conexion.AsignarParametroCadena("@capvtelprv",this._capvtelprv);

                    this.Conexion.EjecutarTransaccion();
                    this.Conexion.Desconectar();

                    return true;
                } 
            }
            public bool Grabar2()
            {
                try
                {
                    this.Conexion.Conectar();
                    string sql = "insert into aprovee (" +
                                                       "capvestprv," +
                                                       "fapvcodper," +
                                                       "capvrazprv," +
                                                       "capvnirprv," +
                                                       "capvdirprv," +
                                                       "capvtelprv" +
                                                       ") " +
                                 "values (" +
                                          "@capvestprv," +
                                          "@fapvcodper," +
                                          "@capvrazprv," +
                                          "@capvnirprv," +
                                          "@capvdirprv," +
                                          "@capvtelprv" +
                                                       ")";

                    this.Conexion.PrepararComando(sql);

                    this.Conexion.AsignarParametroLogico("@capvestprv", this._capvestprv);
                    this.Conexion.AsignarParametroCadena("@fapvcodper", this._fapvcodper);
                    this.Conexion.AsignarParametroCadena("@capvrazprv", this._capvrazprv);
                    this.Conexion.AsignarParametroCadena("@capvnirprv", this._capvnirprv);
                    this.Conexion.AsignarParametroCadena("@capvdirprv", this._capvdirprv);
                    this.Conexion.AsignarParametroCadena("@capvtelprv", this._capvtelprv);

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
                if (!this.VerificarExistencia())
                {
                    return false;
                }
                else
                {
                    this.Conexion.Conectar();
                    string sql = "update aprovee set " +
                                                        "capvestprv = @capvestprv, " +
                                                        "fapvcodper = @fapvcodper, " +
                                                        "capvrazprv = @capvrazprv, " +
                                                        "capvnirprv = @capvnirprv, " +
                                                        "capvdirprv = @capvdirprv, " +
                                                        "capvtelprv = @capvtelprv" +
                                    " ";

                    this.Conexion.PrepararComando(sql);

                    this.Conexion.AsignarParametroLogico("@capvestprv", this._capvestprv);
                    this.Conexion.AsignarParametroCadena("@fapvcodper", this._fapvcodper);
                    this.Conexion.AsignarParametroCadena("@capvrazprv", this._capvrazprv);
                    this.Conexion.AsignarParametroCadena("@capvnirprv", this._capvnirprv);
                    this.Conexion.AsignarParametroCadena("@capvdirprv", this._capvdirprv);
                    this.Conexion.AsignarParametroCadena("@capvtelprv", this._capvtelprv);

                    this.Conexion.EjecutarTransaccion();
                    this.Conexion.Desconectar();

                    return true;
                }

            }
            public bool Modificar2(String a)
            {
                try
                {
                    this.Conexion.Conectar();
                        string sql = "update aprovee set " +
                                                            "capvestprv = @capvestprv, " +
                                                            "fapvcodper = '"+a+"', " +
                                                            "capvrazprv = @capvrazprv, " +
                                                            "capvnirprv = @capvnirprv, " +
                                                            "capvdirprv = @capvdirprv, " +
                                                            "capvtelprv = @capvtelprv " +
                                        " where " +
                                    "fapvcodper = @fapvcodper";

                this.Conexion.PrepararComando(sql);

                        this.Conexion.AsignarParametroLogico("@capvestprv", this._capvestprv);
                        this.Conexion.AsignarParametroCadena("@fapvcodper", this._fapvcodper);
                        this.Conexion.AsignarParametroCadena("@capvrazprv", this._capvrazprv);
                        this.Conexion.AsignarParametroCadena("@capvnirprv", this._capvnirprv);
                        this.Conexion.AsignarParametroCadena("@capvdirprv", this._capvdirprv);
                        this.Conexion.AsignarParametroCadena("@capvtelprv", this._capvtelprv);

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
            public List<aprovee> Lista(string where)
                { 
                    List<aprovee> ListaResultado = new List<aprovee>();
                    this.Conexion.Conectar(); 
			        string sql = "select " + 
                                         "capvestprv," +
                                         "fapvcodper," +
                                         "capvrazprv," +
                                         "capvnirprv," +
                                         "capvdirprv," +
                                         "capvtelprv " + 
                                 "from aprovee " ;
 
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
                              aprovee Auxiliar = new aprovee();
                              Auxiliar.capvestprv = ResultadoConsulta.GetBoolean(0);
                              Auxiliar.fapvcodper = ResultadoConsulta.GetString(1);
                              Auxiliar.capvrazprv = ResultadoConsulta.GetString(2);
                              Auxiliar.capvnirprv = ResultadoConsulta.GetString(3);
                              Auxiliar.capvdirprv = ResultadoConsulta.GetString(4);
                              Auxiliar.capvtelprv = ResultadoConsulta.GetString(5);
                              ListaResultado.Add(Auxiliar);
                        }

                    }
                    this.Conexion.Desconectar();
                    return ListaResultado;
                } 
        #endregion 

	}
}

