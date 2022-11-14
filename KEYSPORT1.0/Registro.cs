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
    public partial class Registro : Form
    {
       
        public Registro()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            Letras letra = new Letras();
                string fecha = "" + txtyy.Text + "." + txtmm.Text + "." + txtdd.Text + "";


                    Logica usuario = new Logica(txtcedula.Text, letra.ConvertirTexto(txtNombre.Text), letra.ConvertirTexto(txtApellido.Text), fecha, txtNacionalidad.Text, txtCorreo.Text, txtContraeña.Text);
                    usuario.Registrarse();
                    EnviarMail a = new EnviarMail();
                    a.enviarMail(txtCorreo.Text, "Se a registrado en KeySport", "Gracias " + txtNombre.Text + " por registrarte en KeySport");
                    
                    conexion.conn.Close();


               
                   
                
            
            } catch
            {
                MessageBox.Show("Error : Le falto ingresar algun dato");
            }
        }

        private void txtyy_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login log = new Login();
            log.Show();
            
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }
    }
}
