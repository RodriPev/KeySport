using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace KEYSPORT1._0
{
    public class conexion
    {
        public static MySqlConnection conn = new MySqlConnection("Server=127.0.0.1; Database=keysport; Uid=root; Pwd=");

        public static bool conectarse()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
   
    public class Register
    {
        


        public string cedula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string fecha { get; set; }
        public string nacionalidad { get; set; }
        public string correo { get; set; }
        public string contra { get; set; }

        public Register(string cedula, string nombre, string apellido, string fecha, string nacionalidad, string correo, string contra )
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fecha = fecha;
            this.nacionalidad = nacionalidad;
            this.correo = correo;
            this.contra = contra;
        }

        public void Registrarse ()
        {
            conexion.conn.Open();
            string ingreso = "insert into persona values ('" + cedula + "', '" + nombre + "', '" + apellido + "', '" + fecha + "', '" + nacionalidad + "', '" + correo + "', '" + contra + "')";
            MySqlCommand comando = new MySqlCommand(ingreso, conexion.conn);
            comando.ExecuteNonQuery();
            conexion.conn.Close();
        }

    }

    public class login
    {
        public string correo { get; set; }
        public string contra { get; set; }
        

        public login(string correo, string contra)
        {
            this.correo = correo;
            this.contra = contra;
        }

        public void Ingresar()
        {
            conexion.conn.Open();
            string consulta = "select idsuscripcion from puede, persona where (puede.ci=persona.ci) and persona.correo = '" + correo + "' and contrasenia='" + contra + "'  ";
            MySqlCommand comando = new MySqlCommand(consulta, conexion.conn);
            MySqlDataReader leer;
            leer = comando.ExecuteReader();
            
            if (leer.HasRows == true)
            {
                Form3 sus = new Form3();
                sus.Show();
                MessageBox.Show("Se a logueado");
                conexion.conn.Close();

            } else
            conexion.conn.Close();
            conexion.conn.Open();
            string consultaII = "select * from persona where correo='" + correo + "' and contrasenia='" + contra + "'";
                MySqlCommand comandoII = new MySqlCommand(consultaII, conexion.conn);
                MySqlDataReader leerII;
                leerII = comandoII.ExecuteReader();
                if (leerII.HasRows == true)
                {
                    
                    Form2 key = new Form2();
                    key.Show();
                    MessageBox.Show("Error");
                    conexion.conn.Close();
            }
                else
                {
                    Form4 log = new Form4();
                    log.Show();
                }
                
            }

        }
}
