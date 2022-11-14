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
    public partial class MenuSus : Form
    {
        public MenuSus()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Cancelar cancelar = new Cancelar();
            cancelar.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Letras letras = new Letras();
            string equipo = txtEquipo.Text;
            letras.ConvertirTexto(equipo);
            
                DataTable origendatos;
                string mostrar = "select fecha, hora from partido, equipo where (partido.idequipo = equipo.idequipo) or (partido.Idequipo2=equipo.idEquipo)and equipo.nomEquipo='" + equipo + "';";
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

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Evento eventoo = new Evento();
            eventoo.Show();
            this.Hide();
        }

        private void MenuSus_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Resultados resultados = new Resultados();
            resultados.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Info inf = new Info();
            inf.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        public void notificacion()
        {
            
            
        }
        private void notifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {

        }
    }
}
