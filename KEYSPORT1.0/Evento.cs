using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace KEYSPORT1._0
{
    public partial class Evento : Form
    {
        public Evento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            conexion.conn.Open();
            string consulta = "select * from puede, persona where (puede.ci=persona.ci) and persona.correo = '" + txtCorreo.Text + "'";
            MySqlCommand comando = new MySqlCommand(consulta, conexion.conn);
            MySqlDataReader leer;
            leer = comando.ExecuteReader();
            

            if (leer.HasRows == true)
            {
                conexion.conn.Close();



                conexion.conn.Open();
                string buscar = "select ci from persona where correo='" + txtCorreo.Text + "'";
                MySqlCommand comandoII = new MySqlCommand(buscar, conexion.conn);
                MySqlDataReader leerII = comandoII.ExecuteReader();
                leerII.Read();
                string ci = leerII["ci"].ToString();
                
                                              
                conexion.conn.Close();




                conexion.conn.Open();
                string buscarII = "select idcampeonato from campeonato where nomCampeonato='" + txtCam.Text + "';";
                MySqlCommand comandoIII = new MySqlCommand(buscarII, conexion.conn);
                MySqlDataReader leerIII = comandoIII.ExecuteReader();
                leerIII.Read();
                string idC = leerIII["idcampeonato"].ToString();
                conexion.conn.Close();
                SusEvento sus = new SusEvento(ci, idC);
                sus.suscribir();


                conexion.conn.Open();
                string buscarIV = "select fecha from campeonato where nomCampeonato='" + txtCam.Text + "';";
                MySqlCommand comandoIV = new MySqlCommand(buscarIV, conexion.conn);
                MySqlDataReader leerIV = comandoIV.ExecuteReader();
                leerIV.Read();
                string fecha = leerIV["fecha"].ToString();
                conexion.conn.Close();
                
                MessageBox.Show("Se a suscrito correctamente!");
                EnviarMail mail = new EnviarMail();
                mail.enviarMail(txtCorreo.Text, "Se a suscrito al campeonato: "+txtCam.Text+"", "El campeonato se disputará el dia: "+fecha+"");


            }
            else
            {
                MessageBox.Show("Usted no tiene derecho a este privilegio, compre KeySport Gold");
            }
                 }catch
            {
                if (txtCorreo.Text == "" || txtCam.Text == "")
                {
                    MessageBox.Show("Le falto rellenar algun campo");
                }
                else
                   
                
                { 
                    
                    MessageBox.Show("No se encontró wl mail o el campeonato");
                }
            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
            conexion.conn.Open();
            string buscarIV = "select fecha from campeonato where nomCampeonato='" + txtCam.Text + "';";
            MySqlCommand comandoIV = new MySqlCommand(buscarIV, conexion.conn);
            MySqlDataReader leerIV = comandoIV.ExecuteReader();
            leerIV.Read();
            string fecha = leerIV["fecha"].ToString();
            conexion.conn.Close();

            
            EnviarMail mail = new EnviarMail();
            mail.enviarMail(txtCorreo.Text, "" + txtCam.Text + "", "El campeonato se disputará el dia: " + fecha + "");
            } catch
            {
                MessageBox.Show("Error : usted no tiene permiso");
            }
        }

        private void Evento_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuSus menu = new MenuSus();
            menu.Show();
            this.Hide();
        }
    }
}
