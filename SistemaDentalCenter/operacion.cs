using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using Dapper;
using SistemaDentalCenter.Models;


namespace SistemaDentalCenter
{
    class operacion
    {
        public string ConsultaSinResultado(string sql)
        {
            SQLiteConnection conn = new SQLiteConnection("Data source=C:\\DB\\ConsultorioDental.sqlite");
            try
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();
                //conn.Query<Class_patient>("insert into paciente (nombre, apellido, cedula, sexo, fecha_nacimiento, direccion, telefono, ARS, correo) values('txtNombre_CP','Colon','11111111111','F','09/23/2006','Calle Juan','809-809-0000,'Humano','roxio@correo.com')");
                return "Conexion hecha!";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }

          public DataTable Consultaconresultado(string sql)
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();
            SQLiteConnection conn = new SQLiteConnection("Data source=C:\\DB\\ConsultorioDental.sqlite");
            try
            {
                conn.Open();
                    SQLiteCommand cmd;
                    cmd = conn.CreateCommand();
                    cmd.CommandText = sql;
                    ad = new SQLiteDataAdapter(cmd);
                    ad.Fill(dt);
                }

            catch (Exception ex)
            {
             
            }
            conn.Close();
            return dt;
        }
        }

        }


