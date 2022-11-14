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
    public partial class Suscripcion : Form
    {
        public Suscripcion()
        {
            InitializeComponent();
            
            
        }
        

    private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
    private void button1_Click(object sender, EventArgs e)
        {
            Random a = new Random();
            string x = Convert.ToString(a.Next(0, 1000000));
            string plan = Convert.ToString(comboBox1.SelectedItem);

           
            try {
                

                conexion.conn.Open();
            string duda = "select * from persona where ci='" + txtCi.Text + "' and contrasenia='"+txtContra.Text+"' and correo='"+txtCorreo.Text+"'";
            MySqlCommand comando = new MySqlCommand(duda, conexion.conn);
            MySqlDataReader leer;
            leer = comando.ExecuteReader();
            if (leer.HasRows == true)
            {
                    conexion.conn.Close();
                    
                               
            

            string fecha = "'"+txtaa.Text+"-"+txtmm.Text+"-"+txtdd.Text+"'";
            suscripcion suscr = new suscripcion(x, txtCi.Text, plan, txtNum.Text, fecha);
                suscr.tarjeta();
                

                suscr.sus();

                suscr.Union();

                    suscr.usa();
                
                    conexion.conn.Open();
                    string buscar = "select nombre from persona where correo='" + txtCorreo.Text + "';";
                    MySqlCommand comandoII = new MySqlCommand(buscar, conexion.conn);
                    MySqlDataReader leerII = comando.ExecuteReader();
                    leer.Read();
                    string nombre = leerII["nombre"].ToString();
                    conexion.conn.Close();
                    EnviarMail mail = new EnviarMail();
                    mail.enviarMail(txtCorreo.Text, "Se a suscrito a KeySport Gold exitosamente", "Gracias " + nombre + " por suscribirte a KeySport Gold, su plan es "+plan+"");
                    MenuSus sus = new MenuSus();
                    sus.Show();
                    this.Hide();
            }else
            {
                MessageBox.Show("Contraseña, Correo o Ci incorrectos");
                conexion.conn.Close();
            }
                 }
            catch (Exception error)
            {
                MessageBox.Show("error"+error);
                conexion.conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cancelar cancelar = new Cancelar();
            cancelar.Show();
        }

        private void txtaa_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        private void Suscripcion_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MenuIngresados volver = new MenuIngresados();
            volver.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
