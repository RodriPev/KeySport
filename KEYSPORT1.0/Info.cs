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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            Letras letras = new Letras();
            string equipo = txtJugador.Text;
            letras.ConvertirTexto(equipo);

            
                DataTable origendatos;
                string mostrar = "select fechaNac, numCamiseta, apelJugador, nomEquipo from jugador, equipo where jugador.idEquipo=equipo.idEquipo and nomJugador='"+txtJugador.Text+"'";
                MySqlCommand busqueda = new MySqlCommand(string.Format(mostrar), conexion.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(busqueda);
                origendatos = new DataTable();
                adapter.Fill(origendatos);
                dataGridView1.DataSource = origendatos;
            }catch 
            {
                MessageBox.Show("Ingrese un jugador");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
            Letras letras = new Letras();
            string equipo = txtbuscar2.Text;
            letras.ConvertirTexto(equipo);


            DataTable origendatos;
            string mostrar = "select nomequipo, cede, alineacion, nomCampeonato, posicion from equipo, tabla, campeonato where equipo.idequipo=tabla.idEquipo and tabla.idCamp=campeonato.idcampeonato and nomEquipo='"+txtbuscar2.Text+"';";
            MySqlCommand busqueda = new MySqlCommand(string.Format(mostrar), conexion.conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(busqueda);
            origendatos = new DataTable();
            adapter.Fill(origendatos);
            dataGridView2.DataSource = origendatos;
            } catch 
            {
                MessageBox.Show("Ingrese un equipo");
            }
        }

        private void Info_Load(object sender, EventArgs e)
        {

        }

        private void txtbuscar2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
