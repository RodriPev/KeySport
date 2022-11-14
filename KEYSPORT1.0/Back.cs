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
    public partial class Back : Form
    {
        public Back()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionRes Ges = new GestionRes();
            Ges.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GestorPublicidad pub = new GestorPublicidad();
            pub.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GestionSus sus = new GestionSus();
            sus.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
