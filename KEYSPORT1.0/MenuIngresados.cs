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
    public partial class MenuIngresados : Form
    {
        public MenuIngresados()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
             
           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Suscripcion sus = new Suscripcion();
            sus.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                Letras letras = new Letras();
            string equipo = txtEquipo.Text;
            letras.ConvertirTexto(equipo);
            
                DataTable origendatos;
                string mostrar = "select fecha, hora from partido, equipo  where (partido.idequipo = equipo.idequipo)  or (partido.idequipo2 = equipo.idequipo) and nomEquipo='" + equipo + "';";
                MySqlCommand busqueda = new MySqlCommand(string.Format(mostrar), conexion.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(busqueda);
                origendatos = new DataTable();
                adapter.Fill(origendatos);
                dataGridView1.DataSource = origendatos;

            }
            catch
            {
                MessageBox.Show("Ingrese un equipo");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
             
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Info inf = new Info();
            inf.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Resultados resultados = new Resultados();
            resultados.Show();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Suscripcion suscripcion = new Suscripcion();
            suscripcion.Show();
            this.Close();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
