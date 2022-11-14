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
    public partial class Resultados : Form
    {
        public Resultados()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Resultados_Load(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Letras letras = new Letras();
            string equipo = txtE1.Text;
            letras.ConvertirTexto(equipo);
            
            
                DataTable origendatos;
                string mostrar = "select  resultadoPartido, fecha from partido, equipo where (partido.idEquipo = equipo.idEquipo) or (partido.idEquipo2 = equipo.idEquipo) and nomEquipo='" + equipo + "';";
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtE1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu volver = new Menu();
            volver.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Letras letras = new Letras();
            string camp = txtCamp.Text;
            letras.ConvertirTexto(camp);

            
                DataTable origendatos;
                string mostrar = "select localidad, fecha from campeonato where nomCampeonato='" + camp + "';";
                MySqlCommand busqueda = new MySqlCommand(string.Format(mostrar), conexion.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(busqueda);
                origendatos = new DataTable();
                adapter.Fill(origendatos);
                dataGridView2.DataSource = origendatos;

            }
            catch 
            {
                MessageBox.Show("Ingrese una fecha");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Letras letras = new Letras();
            string campR = textBox1.Text;
            letras.ConvertirTexto(campR);

            
                DataTable origendatos;
                string mostrar = "select resultado from campeonato where nomCampeonato='" + campR + "';";
                MySqlCommand busqueda = new MySqlCommand(string.Format(mostrar), conexion.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(busqueda);
                origendatos = new DataTable();
                adapter.Fill(origendatos);
                dataGridView3.DataSource = origendatos;

            }
            catch 
            {
                MessageBox.Show("Ingrese un campeonato");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try { 
            Letras letras = new Letras();
            string campR = txtCampTab.Text;
            letras.ConvertirTexto(campR);

            
            
                DataTable origendatos;
                string mostrar = "select posicion, nomEquipo from tabla, equipo, campeonato where equipo.idEquipo=tabla.idEquipo and  campeonato.idcampeonato=tabla.idcamp and nomcampeonato='"+txtCampTab.Text+"';";
                MySqlCommand busqueda = new MySqlCommand(string.Format(mostrar), conexion.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(busqueda);
                origendatos = new DataTable();
                adapter.Fill(origendatos);
                dataGridView4.DataSource = origendatos;

            } catch 
            {
                MessageBox.Show("Ingrese un campeonata");
            }

        }
    }
}
