using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Text;

namespace KEYSPORT1._0
{
    public partial class GestorPublicidad : Form
    {
        public GestorPublicidad()
        {
            InitializeComponent();
        }
        public class Anuncios
        {
            public void GetAds(DataGridView dataGridView1)
            {
                dataGridView1.DataSource = null;
                DataTable dataTable = new DataTable();
                string directory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

                string[] lines = File.ReadAllLines(directory + "/KEYSPORT1.0/bin/Info/ImageList.txt");

                dataTable.Columns.Add("Nombre");
                dataTable.Columns.Add("URL");

                foreach (string line in lines)
                {
                    string nombre = line.Split(' ').First();
                    string url = line.Split(' ').Last();

                    if (nombre != "")
                    {
                        DataRow dataRow = dataTable.NewRow();
                        dataRow["Nombre"] = nombre;
                        dataRow["URL"] = url;
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
            public void MostrarFoto()
            {

                OpenFileDialog open = new OpenFileDialog();


                open.Filter = "Image Files(*.png;*.jpg; *.jpeg; *.gif; *.bmp)|*.png;*.jpg; *.jpeg; *.gif; *.bmp";
                string directorio = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                string carpeta = directorio + "/KEYSPORT1.0/bin/Info/ImageList.txt";
                string Lugar = directorio + "/KEYSPORT1.0/bin/Info";

                List<string> lines = File.ReadAllLines(carpeta).ToList();

                string imageName;
                string imagePath;

                if (open.ShowDialog() == DialogResult.OK)
                {
                    imageName = open.FileName.Split('\\').Last();

                    imagePath = open.FileName;

                    if (lines.Count > 0)
                    {
                        foreach (string line in lines)
                        {
                            string imageNameInFile = line.Split(' ').First();

                            if (imageNameInFile == imageName)
                            {
                                MessageBox.Show("Error : Publicidad existente");
                                break;
                            }
                            else if (imageNameInFile == lines.Last().Split(' ').First())
                            {
                                lines.Add(imageName + " " + imagePath);
                                File.Delete(carpeta);
                                File.WriteAllLines(carpeta, lines.ToArray());
                                File.Copy(imagePath, Lugar + "/" + imageName);
                                break;
                            }
                        }
                    }
                    else
                    {
                        lines.Clear();
                        lines.Add(imageName + " " + imagePath);
                        File.Delete(carpeta);
                        File.WriteAllLines(carpeta, lines.ToArray());
                        File.Copy(imagePath, Lugar + "/" + imageName);
                    }
                }
                else
                {

                }
            }

    }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void GestorPublicidad_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anuncios n = new Anuncios();
            n.GetAds(dataGridView1);

            }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Anuncios n = new Anuncios();
           n.MostrarFoto();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Back back = new Back();
            back.Show();
       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int currentRow = dataGridView1.SelectedRows.Count;

            if (currentRow > 0)
            {
                string imageName = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string imagePath = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                string directory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                string file = directory + "/KEYSPORT1.0/bin/Info/ImageList.txt";
                string image = directory + "/KEYSPORT1.0/bin/Info" + imageName;

                List<string> lines = File.ReadAllLines(file).ToList();


                foreach (string line in lines)
                {
                    if (imagePath == line.Split(' ').Last())
                    {
                        lines.Remove(line);
                        break;
                    }
                }
                File.Delete(image);
                File.Delete(file);
                File.WriteAllLines(file, lines.ToArray());

                MessageBox.Show("Imagen eliminada correctamente");
            }
            else
            {
                MessageBox.Show("Debe seleccionar una imagen que desea eliminar primero!!");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}



