using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Timers;
using System.Windows.Forms;

namespace KEYSPORT1._0
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

        }
        public class tomar
        {
            public void tomarAds(DataGridView dataGridView1)
            {
                dataGridView1.DataSource = null;
                DataTable dataTable = new DataTable();


                string lugar = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

                string[] lines = File.ReadAllLines(lugar + "/KEYSPORT1.0/bin/Info/ImageList.txt");

                dataTable.Columns.Add("Nombre");
                dataTable.Columns.Add("Dirección");

                foreach (string line in lines)
                {
                    string nomImagen = line.Split(' ').First();
                    string dirImagen = line.Split(' ').Last();

                    if (nomImagen != "")
                    {
                        DataRow dataRow = dataTable.NewRow();
                        dataRow["Nombre"] = nomImagen;
                        dataRow["Dirección"] = dirImagen;
                        dataTable.Rows.Add(dataRow);
                    }
                    else
                    {
                        break;
                    }
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            }

        }
        public void CargarAd (object sender, ElapsedEventArgs e)
        {
            string directory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            string[] lines = File.ReadAllLines(directory + "/KEYSPORT1.0/bin/Info/ImageList.txt");

            int amountAds = lines.Length;

            Random random = new Random();
            int adIndex = random.Next(0, amountAds);
            if (lines.Count() > 0)
            {
                string imageLocation = lines[adIndex].Split(' ').Last();
                pictureBox1.ImageLocation = imageLocation;
            }
            else
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Letras letras = new Letras();
            string equipo=txtEquipo.Text;
            letras.ConvertirTexto(equipo);
         
            DataTable origendatos;
            string mostrar = "select fecha, hora from partido, equipo where (partido.idequipo = equipo.idequipo) or (partido.Idequipo2=equipo.idEquipo)and equipo.nomEquipo='"+equipo+"';";
            MySqlCommand busqueda = new MySqlCommand(string.Format(mostrar), conexion.conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(busqueda);
            origendatos = new DataTable();
            adapter.Fill(origendatos);

            dataGridView1.DataSource = origendatos;
            
            }catch 
            {
                MessageBox.Show("Introduzca un equipo");
            }
        }
        


        private void button5_Click(object sender, EventArgs e)
        {
            Registro reg = new Registro();
            reg.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Resultados res = new Resultados();
            res.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Suscripcion sus = new Suscripcion();
            sus.Show();
            this.Hide();
        }

        private void txtEquipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            double interval = 2000;
            timer.Interval = interval;
            timer.AutoReset = true;
            timer.Elapsed += new ElapsedEventHandler(CargarAd);
            timer.Start();

        }
  

         


private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
        
            
        

        private void button3_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName);
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {



        }
    }
}

