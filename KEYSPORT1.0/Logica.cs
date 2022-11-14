using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace KEYSPORT1._0
{
    public class conexion
    {
        public static MySqlConnection conn = new MySqlConnection("Server=127.0.0.1; Port=3306; Database=keysport; Uid=root; Pwd=");

        public static bool conectarse()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("error "+e);
                return false;
            }
        }
    }
    public class Letras
    {

       public string ConvertirTexto(String texto)
        {
           
            string textoLower = texto.ToLower(); 
            string letraUp = texto.Substring(0, 1).ToUpper();
            string exto = textoLower.Remove(0, 1);
            string textoFinal = letraUp + exto;
            return textoFinal;
             
        }
    }
    
    
    public class Logica
    {
        


        public string cedula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string fecha { get; set; }
        public string nacionalidad { get; set; }
        public string correo { get; set; }
        public string contra { get; set; }

        public Logica(string cedula, string nombre, string apellido, string fecha, string nacionalidad, string correo, string contra )
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
            try
            {
                if (correo == "admin" && contra == "1234")
                {
                    Back back = new Back();
                    back.Show();
                }
                else
                {
                    conexion.conn.Open();
                    string consulta = "select * from puede, persona where (puede.ci=persona.ci) and persona.correo = '" + correo + "' and contrasenia='" + contra + "'  ";
                    MySqlCommand comando = new MySqlCommand(consulta, conexion.conn);
                    MySqlDataReader leer;
                    leer = comando.ExecuteReader();

                    if (leer.HasRows == true)
                    {
                        MenuSus sus = new MenuSus();
                        sus.Show();

                        conexion.conn.Close();

                    }
                    else
                    {
                        conexion.conn.Close();
                        conexion.conn.Open();
                        string consultaII = "select * from persona where correo='" + correo + "' and contrasenia='" + contra + "'";
                        MySqlCommand comandoII = new MySqlCommand(consultaII, conexion.conn);
                        MySqlDataReader leerII;
                        leerII = comandoII.ExecuteReader();
                        if (leerII.HasRows == true)
                        {

                            MenuIngresados ing = new MenuIngresados();
                            ing.Show();




                            conexion.conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se encontro el usuario");
                        }

                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("error" + e);
            }
        
    }
         
        }
    public class suscripcion
    {
        public string idSuscripcion { get; set; }
        public string ci { get; set; }
        public string plan { get; set; }
        public string numTarjeta { get; set; }
        public string fechaVen { get; set; }

        public suscripcion(string idSuscripcion, string ci, string plan, string numTarjeta, string fechaVen)
        {
            this.idSuscripcion = idSuscripcion;
            this.ci = ci;
            this.plan = plan;
            this.numTarjeta = numTarjeta;
            this.fechaVen = fechaVen;
        }
        public void Union()
        {
            conexion.conn.Open();
            string suscribirse = "insert into puede values ('" + idSuscripcion+ "', '" + ci+ "')";
            MySqlCommand comando = new MySqlCommand(suscribirse, conexion.conn);
            comando.ExecuteNonQuery();
            conexion.conn.Close();
        }
        public void sus()
        {
            conexion.conn.Open();
            string suscribir = "insert into suscripcion values ('" + idSuscripcion + "', '" + plan + "', '" + numTarjeta + "')";
            MySqlCommand comandoII = new MySqlCommand(suscribir, conexion.conn);
            comandoII.ExecuteNonQuery();
            conexion.conn.Close();
        }

        public void tarjeta()
        {
            conexion.conn.Open();
            string tarjeta = "insert into tarjetacredito values ('"+numTarjeta+ "', "+fechaVen+")";
            MySqlCommand comandoIII = new MySqlCommand(tarjeta, conexion.conn);
            comandoIII.ExecuteNonQuery();
            conexion.conn.Close();
        }

        public void usa()
        {
            conexion.conn.Open();
            string usa = "insert into usa values ('" + numTarjeta + "', '" + ci + "')";
            MySqlCommand comandoIV = new MySqlCommand(usa, conexion.conn);
            comandoIV.ExecuteNonQuery();
            conexion.conn.Close();
        }
    }
    public class partido
    {
        public string id { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }
        public string resultado { get; set; }
        public string idArbitro { get; set; }
        public string idEquipo { get; set; }
        public string idEquipo2 { get; set; }
        public string idCampeonato { get; set; }

        public partido(string id, string fecha, string hora, string resultado, string idArbitro, string idEquipo, string idEquipo2, string idCampeonato)
        {
            this.id = id;
            this.fecha = fecha;
            this.hora = hora;
            this.resultado = resultado;
            this.idArbitro = idArbitro;
            this.idEquipo = idEquipo;
            this.idEquipo2 = idEquipo2;
            this.idCampeonato = idCampeonato;
        }

        public void GuardarPartido()
        {
            conexion.conn.Open();
            string guardar = "insert into partido value ("+id+", '"+fecha+"', '"+hora+"', '"+resultado+"', '"+idArbitro+"', '"+idEquipo+"', '"+idEquipo2+"', '"+idCampeonato+"')";
            MySqlCommand comando = new MySqlCommand(guardar, conexion.conn);
            comando.ExecuteNonQuery();
            conexion.conn.Close();
            
        }
    }
    
    public class Arbitro
    {
        public string id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string fecha { get; set; }


        public Arbitro(string id, string nombre, string apellido, string fecha)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fecha = fecha;

        }

        public void GuardarArbitro()
        {
            conexion.conn.Open();
            string guardar = "insert into Arbitro value ('"+id+"', '" + nombre + "', '" + apellido + "', '"+fecha+"')";
            MySqlCommand comando = new MySqlCommand(guardar, conexion.conn);
            comando.ExecuteNonQuery();
            conexion.conn.Close();

        }
    }
    public class Equipo
        {
            public string id { get; set; }
            public string nombre { get; set; }
            public string nacionalidad { get; set; }
            public string cede { get; set; }
            public string planilla { get; set; }
            public string deporte { get; set; }

            public Equipo(string id, string nombre, string nacionalidad, string cede, string planilla, string deporte)
            {
                this.id = id;
                this.nombre = nombre;
                this.nacionalidad = nacionalidad;
                this.cede = cede;
                this.planilla = planilla;
                this.deporte = deporte;

            }

            public void GuardarEquipo()
            {
                conexion.conn.Open();
                string guardar = "insert into equipo value (" + id + ", '" + nombre + "', '"+nacionalidad+"', '"+cede+"', '"+planilla+"', '"+deporte+"')";
                MySqlCommand comando = new MySqlCommand(guardar, conexion.conn);
                comando.ExecuteNonQuery();
                conexion.conn.Close();

            }
        
    }
        public class Jugador
            {
                public string id { get; set; }
                public string nombre { get; set; }
                public string apellido { get; set; }
                public string numero { get; set; }
                public string fecha { get; set; }
                public string idEquipo { get; set; }

                public Jugador(string id, string numero, string nombre, string apellido,  string idEquipo, string fecha)
                {
                    this.id = id;
                    this.numero = numero;
                    this.nombre = nombre;
                    this.apellido = apellido;           
                    this.fecha = fecha;
                    this.idEquipo = idEquipo;

                }

                public void GuardarJugador()
                {
                    conexion.conn.Open();
                    string guardar = "insert into jugador value ('" + id + "', '" + numero + "', '" + nombre + "', '" + apellido + "', '"+idEquipo+"' , '" + fecha + "')";
                    MySqlCommand comando = new MySqlCommand(guardar, conexion.conn);
                    comando.ExecuteNonQuery();
                    conexion.conn.Close();

                }
        
    }
    public class Campeonato
    {
        public string id { get; set; }
        public string localidad { get; set; }
        public string nombre { get; set; }
        public string resultado { get; set; }
        public string deporte { get; set; }
        public string fecha { get; set; }

        public Campeonato(string id, string localidad, string nombre, string resultado,  string fecha, string deporte)
        {
            this.id = id;
            this.localidad = localidad;
            this.nombre = nombre;
            this.resultado = resultado;            
            this.fecha = fecha;
            this.deporte = deporte;

        }
        public void guardarCampeonato()
        {
            conexion.conn.Open();
            string insertar = "insert into campeonato values ('"+id+"', '"+localidad+"', '"+nombre+"', '"+resultado+"', '"+fecha+"', '"+deporte+"')";
            MySqlCommand comando = new MySqlCommand(insertar, conexion.conn);
            comando.ExecuteNonQuery();
            conexion.conn.Close();
        }
        

    }
    public class Cancela
    {
        public void cancelarSus(string ci)
        {
            conexion.conn.Open();
            string borrar = "delete from puede where puede.ci="+ci+"";
            MySqlCommand comando = new MySqlCommand(borrar, conexion.conn);
            comando.ExecuteNonQuery();
            conexion.conn.Close();
        }
        public void cancelarUsa(string x)
        {
            conexion.conn.Open();
            string borrar = "delete from usa where numTarjeta ="+x+";";
            MySqlCommand comando = new MySqlCommand(borrar, conexion.conn);
            comando.ExecuteNonQuery();
            conexion.conn.Close();
        }
        public void cancelarSuscr(string x)
        {
            conexion.conn.Open();
            string borrar = "delete from suscripcion where numTarjeta ="+x+";";
            MySqlCommand comando = new MySqlCommand(borrar, conexion.conn);
            comando.ExecuteNonQuery();
            conexion.conn.Close();
        }
        
        public void cancelarTarjeta(string x)
        {
            conexion.conn.Open();
            string borrar = "delete from tarjetacredito where numTarjeta ="+x+";";
            MySqlCommand comando = new MySqlCommand(borrar, conexion.conn);
            comando.ExecuteNonQuery();
            conexion.conn.Close();
        }
    }
    public class SusEvento
        {
            public string ci { get; set; }
            public string idCampeonato { get; set; }

            public SusEvento(string ci, string idCampeonato)
            {
                this.ci = ci;
                this.idCampeonato = idCampeonato;
            }
            
            public void suscribir()
            {
                conexion.conn.Open();
                string suscribir = "insert into suscam values ('"+ci+"', '"+idCampeonato+"')";
                MySqlCommand comando = new MySqlCommand(suscribir, conexion.conn);
                comando.ExecuteNonQuery();
                conexion.conn.Close();
            }
        
       
    }
    public class EnviarMail
    {
        public void enviarMail(string to, string asunto, string body)
        {
            try { 
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.office365.com";
            smtp.Port = 587;
            smtp.Credentials=new System.Net.NetworkCredential("lolopevere@hotmail.com", "lolo1405");
            smtp.EnableSsl = true;

                MailMessage mail = new MailMessage();
            mail.From = new MailAddress("lolopevere@hotmail.com","Oficina AgeOfSoftware");
            mail.To.Add(to) ;
            mail.Subject = asunto;
            mail.IsBodyHtml = true;
            mail.Body = body;
            smtp.Send(mail);
                 }catch 
            {
                MessageBox.Show("No se encontro la direccion de correo");
                conexion.conn.Open();
                string insertar = "delete from persona where correo='" + to + "'";
                MySqlCommand comando = new MySqlCommand(insertar, conexion.conn);
                comando.ExecuteNonQuery();
                conexion.conn.Close();
            }
        }
    }
    public class tabla
    {
        public string id { get; set; }
        public string posicion { get; set; }
        public string idE { get; set; }
        public string idCam { get; set; }

        public tabla( string id, string idE, string idCam, string posicion)
        {
            this.id = id;
            this.posicion = posicion;
            this.idE = idE;
            this.idCam = idCam;
        }
        public void guardarTabla()
        {
            conexion.conn.Open();
            string guardar = "insert into tabla values ('"+id+"','"+idE+"','"+idCam+"', '"+posicion+"')";
            MySqlCommand comando = new MySqlCommand(guardar, conexion.conn);
            comando.ExecuteNonQuery();
            conexion.conn.Close();
        }
    }
     
    public class borrar
    {
        public string id { get; set; }

        public borrar(string id)
        {
            this.id = id;
        }
        public void eliminarCampeonato()
        {
            conexion.conn.Open();
            string insertar = "delete from campeonato where idcampeonato='" + id + "'";
            MySqlCommand comando = new MySqlCommand(insertar, conexion.conn);
            comando.ExecuteNonQuery();
            conexion.conn.Close();
        }
        public void eliminarJugador()
        {
            conexion.conn.Open();
            string insertar = "delete from jugador where idjugador='" + id + "'";
            MySqlCommand comando = new MySqlCommand(insertar, conexion.conn);
            comando.ExecuteNonQuery();
            conexion.conn.Close();
        }
        public void eliminarEquipo()
        {
            conexion.conn.Open();
            string insertar = "delete from equipo where idequipo='" + id + "'";
            MySqlCommand comando = new MySqlCommand(insertar, conexion.conn);
            comando.ExecuteNonQuery();
            conexion.conn.Close();
        }
        public void eliminarArbitro()
        {
            conexion.conn.Open();
            string insertar = "delete from arbitro where idArbitro='" + id + "'";
            MySqlCommand comando = new MySqlCommand(insertar, conexion.conn);
            comando.ExecuteNonQuery();
            conexion.conn.Close();
        }
        public void eliminarTabla()
        {
            conexion.conn.Open();
            string insertar = "delete from tabla where id='" + id + "'";
            MySqlCommand comando = new MySqlCommand(insertar, conexion.conn);
            comando.ExecuteNonQuery();
            conexion.conn.Close();
        }

    }
}

    
    
    
   


