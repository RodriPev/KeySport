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
    public partial class GestionSus : Form
    {
        public GestionSus()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string buscador = txtBuscar.Text;
            
            try
            {
                DataTable origendatos;
                string mostrar = "select suscripcion.* from suscripcion, puede, persona where (suscripcion.idSuscripcion=puede.idSuscripcion) and (persona.ci=puede.ci) and persona.correo='"+buscador+"';";
                MySqlCommand busqueda = new MySqlCommand(string.Format(mostrar), conexion.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(busqueda);
                origendatos = new DataTable();
                adapter.Fill(origendatos);
                dataGridView1.DataSource = origendatos;

            }
            catch
            {
                MessageBox.Show("Falto algun dato o algo esta mal escrito");
            }
}

        private void button3_Click(object sender, EventArgs e)
        {
            
            string buscador = txtBuscar.Text;
            
            try
            {
                DataTable origendatos;
                string mostrar = "select * from persona where correo='" + buscador + "';";
                MySqlCommand busqueda = new MySqlCommand(string.Format(mostrar), conexion.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(busqueda);
                origendatos = new DataTable();
                adapter.Fill(origendatos);
                dataGridView1.DataSource = origendatos;

            }
            catch
            {
                MessageBox.Show("Falto algun dato o algo esta mal escrito");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string buscador = txtBuscar.Text;
            
            try
            {
                DataTable origendatos;
                string mostrar = "select  tarjetacredito.* from tarjetacredito, usa, persona where (tarjetacredito.numTarjeta=usa.numTarjeta) and (persona.ci=usa.ci) and persona.correo='" + buscador + "';";
                MySqlCommand busqueda = new MySqlCommand(string.Format(mostrar), conexion.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(busqueda);
                origendatos = new DataTable();
                adapter.Fill(origendatos);
                dataGridView1.DataSource = origendatos;

            }
            catch
            {
                MessageBox.Show("Falto algun dato o algo esta mal escrito");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Back back = new Back();
            back.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try { 
            Cancela cancela = new Cancela();
            cancela.cancelarSus(txtCi.Text);
            cancela.cancelarUsa(txtnum.Text);
            }
            catch
            {
                MessageBox.Show("Error, intente nuevamente");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try {
            Cancela cancela = new Cancela();
            cancela.cancelarSuscr(txtnum.Text);
                cancela.cancelarTarjeta(txtnum.Text);
                conexion.conn.Open();
                string buscar = "select correo from persona where ci='" + txtCi.Text + "'";
                MySqlCommand comando = new MySqlCommand(buscar, conexion.conn);
                MySqlDataReader leer = comando.ExecuteReader();
                leer.Read();
                string correo = leer["correo"].ToString();
                conexion.conn.Close();
                EnviarMail mail = new EnviarMail();
                mail.enviarMail(correo, "Decidimos eliminar su suscripcion a KeySport Gold", txtMotivo.Text);
            }
            catch
            {
                MessageBox.Show("Error, intente nuevamente");
            }
        }

        private void txtMotivo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
