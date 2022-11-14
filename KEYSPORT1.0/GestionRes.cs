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
    public partial class GestionRes : Form
    {
        public GestionRes()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            Random a = new Random();
            string x = Convert.ToString(a.Next(0, 1000000));
            
            string fecha = ""+txtaa.Text+"-"+txtmm.Text+"-"+txtdd.Text+"";
            partido juego = new partido(x, fecha, txtHora.Text, txtResultado.Text, txtAr.Text, txtEquipo.Text, txtequipo2.Text, txtIdCam.Text);
            juego.GuardarPartido();
            MessageBox.Show("El id partido es: " + x);
            }
            catch 
            {
                MessageBox.Show("Falto algun dato o algo esta mal escrito" );
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GestionRes_Load(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAr_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try { 
            
            Random aa = new Random();
            string xx = Convert.ToString(aa.Next(0, 1000000));
            string fecha = "" + txtaaAr.Text + "-" + txtmmAr.Text + "-" + txtddAr.Text + "";
            Arbitro ar = new Arbitro(xx, txtNameAr.Text, txtApeAr.Text, fecha);
            ar.GuardarArbitro();

            }catch 
            {
                MessageBox.Show("Falto algun dato o algo esta mal escrito");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Letras letras = new Letras();
            string nombre = txtbuscar.Text;
            letras.ConvertirTexto(nombre);
          
                DataTable origendatos;
                string mostrar = "select * from arbitro where nomArbitro='"+nombre+"'";
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

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                Letras letras = new Letras();
            string nombre = txtbuscar.Text;
            letras.ConvertirTexto(nombre);
            
                DataTable origendatos;
                string mostrar = "select * from Jugador where nomJugador='" + nombre + "'";
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

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                Letras letras = new Letras();
            string nombre = txtbuscar.Text;
            letras.ConvertirTexto(nombre);
            
                DataTable origendatos;
                string mostrar = "select * from equipo where nomEquipo='" + txtbuscar.Text + "'";
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

        private void button6_Click(object sender, EventArgs e)
        {
            Letras letra = new Letras();
            string nombre = txtbuscar.Text;
            letra.ConvertirTexto(nombre);
            try
            {
                DataTable origendatos;
                string mostrar = "select * from partido where nomPartido='" + nombre + "'";
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
            try { 
            Random a = new Random();
            string x = Convert.ToString(a.Next(0, 1000000));
            string deporte = Convert.ToString( comboBox1.SelectedItem);
            Equipo equipo = new Equipo(x, txtNomE.Text, txtNacE.Text, txtCede.Text, txtAl.Text, deporte );
            equipo.GuardarEquipo();
            }
            catch
            {
                MessageBox.Show("Falto algun dato o algo esta mal escrito");
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                Letras letra = new Letras();
            string nombre = txtbuscar.Text;
            letra.ConvertirTexto(nombre);
           
                DataTable origendatos;
                string mostrar = "select * from campeonato where nomCampeonato='" + nombre + "'";
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

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try { 
            Random a = new Random();
            string x = Convert.ToString(a.Next(0, 1000000));
            string fecha = "" + txtaaj.Text + "-" + txtmmj.Text + "-" + txtddj.Text + "";
            Jugador jugador = new Jugador(x, txtRemera.Text, txtNomJ.Text, txtApeJ.Text, txtIDee.Text, fecha);
            jugador.GuardarJugador();
                 } catch
            {
                MessageBox.Show("Falto algun dato o algo esta mal escrito");
            }

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try { 
            string deporte = Convert.ToString(comboBox2.SelectedItem);
            Random a = new Random();
            string x = Convert.ToString(a.Next(0, 1000000));
            string fecha = "" + txtaaca.Text + "-" + txtmmca.Text + "-" + txtddca.Text + "";
            Campeonato camp = new Campeonato(x, txtLocal.Text, txtCamp.Text, txtResCam.Text, fecha, deporte);
            camp.guardarCampeonato();
                 }catch
            {
                MessageBox.Show("Falto algun dato o algo esta mal escrito");
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                Letras letra = new Letras();
            string nombre = txtbuscar.Text;
            letra.ConvertirTexto(nombre);
            
                DataTable origendatos;
                string mostrar = "select * from partido where idPartido='" + nombre + "'";
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

        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Back back = new Back();
            back.Show();
            this.Hide();
        }

        private void txtEquipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            try { 
            Random a = new Random();
            string x = Convert.ToString(a.Next(0, 1000000));
            tabla tbl = new tabla(x, txtET.Text, txtCamT.Text , txtPosi.Text);
            tbl.guardarTabla();
                 }catch
            {
                MessageBox.Show("Falto algun dato o algo esta mal escrito");
            }
            

        }

        private void txtCamT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtET_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPosi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            try { 
            Letras letras = new Letras();
            string nombre = txtbuscar.Text;
            letras.ConvertirTexto(nombre);



            DataTable origendatos;
            string mostrar = "select tabla.id, tabla.idEquipo, tabla.idCamp, posicion from tabla, equipo, campeonato where equipo.idEquipo=tabla.idEquipo and  campeonato.idcampeonato=tabla.idcamp and nomcampeonato='" + nombre + "';";
            MySqlCommand busqueda = new MySqlCommand(string.Format(mostrar), conexion.conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(busqueda);
            origendatos = new DataTable();
            adapter.Fill(origendatos);
            dataGridView1.DataSource = origendatos;
                 }catch
            {
                MessageBox.Show("Falto algun dato o algo esta mal escrito");
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            try { 
            borrar borrar = new borrar(txtIdaBorrar.Text);
            borrar.eliminarArbitro();
            MessageBox.Show("Borrado exitosamente");
            }
            catch
            {
                MessageBox.Show("Falto algun dato o algo esta mal escrito");
            }

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            try { 
            Random a = new Random();
            string x = Convert.ToString(a.Next(0, 1000000));
            string fecha = "" + txtyyarb.Text + "-" + txtmmarb.Text + "-" + txtddarb.Text + "";
            Arbitro arbitro = new Arbitro(x, txtNomAr.Text, txtApelAr.Text, fecha);
            arbitro.GuardarArbitro();
                 }catch
            {
                MessageBox.Show("Falto algun dato o algo esta mal escrito");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try {
            borrar borrar = new borrar(txtIdaBorrar.Text);
            borrar.eliminarEquipo();
            MessageBox.Show("Borrado exitosamente");
            }
            catch
            {
                MessageBox.Show("Falto algun dato o algo esta mal escrito");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try { 
            borrar borrar = new borrar(txtIdaBorrar.Text);
            borrar.eliminarCampeonato();
            MessageBox.Show("Borrado exitosamente");
            }
            catch
            {
                MessageBox.Show("Falto algun dato o algo esta mal escrito");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try {
            borrar borrar = new borrar(txtIdaBorrar.Text);
            borrar.eliminarJugador();
            MessageBox.Show("Borrado exitosamente");
            }
            catch
            {
                MessageBox.Show("Falto algun dato o algo esta mal escrito");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try { 
            borrar borrar = new borrar(txtIdaBorrar.Text);
            borrar.eliminarTabla();
            MessageBox.Show("Borrado exitosamente");
            }
            catch
            {
                MessageBox.Show("Falto algun dato o algo esta mal escrito");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try { 
            conexion.conn.Open();
            string insertar = "delete from keysport";
            MySqlCommand comando = new MySqlCommand(insertar, conexion.conn);
            comando.ExecuteNonQuery();
            conexion.conn.Close();
            }
            catch
            {
                MessageBox.Show("Falto algun dato o algo esta mal escrito");
            }
        }
    }
}
