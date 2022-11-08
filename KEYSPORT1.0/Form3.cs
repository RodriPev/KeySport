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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable origendatos;
            string mostrar = "select fecha, hora from partido, equipo  where (partido.idEquipo=equipo.idEquipo) and nomEquipo='"+txtEquipo.Text+"';";
            MySqlCommand busqueda = new MySqlCommand(string.Format(mostrar), conexion.conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(busqueda);
            origendatos = new DataTable();
            adapter.Fill(origendatos);
            dataGridView1.DataSource = origendatos;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 reg = new Form1();
            reg.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 log = new Form4();
            log.Show();
             

        }
    }
}
