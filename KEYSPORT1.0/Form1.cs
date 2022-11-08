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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
                string fecha = "" + txtyy.Text + "." + txtmm.Text + "." + txtdd.Text + "";
                Register usuario = new Register(txtcedula.Text, txtNombre.Text, txtApellido.Text, fecha, txtNacionalidad.Text, txtCorreo.Text, txtContraeña.Text);
                usuario.Registrarse();  

        }

        private void txtyy_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 log = new Form4();
            log.Show();
        }
    }
}
