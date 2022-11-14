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
    public partial class Cancelar : Form
    {
        public Cancelar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            Cancela cancela = new Cancela();
            cancela.cancelarSus(txtCi.Text);
                EnviarMail mail = new EnviarMail();
                conexion.conn.Close();
                conexion.conn.Open();
                string buscar = "select correo from persona where ci='" + txtCi.Text + "'";
                MySqlCommand comando = new MySqlCommand(buscar, conexion.conn);
                MySqlDataReader leer = comando.ExecuteReader();
                leer.Read();
                string correo = leer["correo"].ToString();
                conexion.conn.Close();
                mail.enviarMail(correo, "Se a eliminado su suscripcion a keysport", "Su suscripcion a sido eliminada correctamente");
                MessageBox.Show("Suscripcion eliminada correctamente");
            }catch 
            {
                MessageBox.Show("Error : Falto ingresar cedula");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuSus sus = new MenuSus();
            sus.Show();
            this.Hide();
        }

        private void Cancelar_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
