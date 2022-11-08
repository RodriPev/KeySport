using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEYSPORT1._0
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 reg = new Form1();
            reg.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "admin" && txtContra.Text == "Administrador1234")
            {
                Form5 back = new Form5();
                back.Show();
            }
            login ingreso = new login(txtCorreo.Text, txtContra.Text);
            ingreso.Ingresar();
            conexion.conn.Close();
        }
    }
}
