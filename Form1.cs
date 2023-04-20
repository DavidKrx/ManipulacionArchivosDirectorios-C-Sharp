using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ManipulacionArchivosDirectorios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtDirectorioActual_TextChanged(object sender, EventArgs e){
            Directory.GetCurrentDirectory();
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            String NewPath = "NewPath holds the path the user has entered";
            string ErrorMessage = null;

            listBox.Items.Clear();

            NewPath = txtDirectorioActual.Text;
            
            try
            {
                Directory.SetCurrentDirectory(NewPath);
                
                string sourceDirectory = NewPath;

                var txtFiles = Directory.EnumerateFiles(sourceDirectory);

                foreach (string currentfile in txtFiles)
                {

                    string Ultimocaracter = NewPath.Substring(NewPath.Length - 1);
                  
                    if ((Ultimocaracter.CompareTo("\\") == 0) || (Ultimocaracter.CompareTo(":") == 0))
                    {
                        string filename = currentfile.Substring(sourceDirectory.Length);
                        listBox.Items.Add(filename);
                    }
                    else
                    {
                        string filename = currentfile.Substring(sourceDirectory.Length + 1);
                        listBox.Items.Add(filename);
                    }
                    
                }

                var txtDirectory = Directory.EnumerateDirectories(sourceDirectory);

                foreach (string currentDirectory in txtDirectory)
                {

                    string Ultimocaracterd = NewPath.Substring(NewPath.Length - 1);
                   
                    if ((Ultimocaracterd.CompareTo("\\") == 0) || (Ultimocaracterd.CompareTo(":") == 0))
                    {
                        string directoryname = currentDirectory.Substring(sourceDirectory.Length);
                        listBox.Items.Add(directoryname);
                    }
                    else
                    {
                        string directoryname = currentDirectory.Substring(sourceDirectory.Length + 1);
                        listBox.Items.Add(directoryname);
                    }
                    
                }

            }
            catch (DirectoryNotFoundException f)
            {
                ErrorMessage = "You must enter a valid path. If trying to access a different drive";
            }

            catch {
                if (txtDirectorioActual.Text == "") {
                    ErrorMessage = "You must enter a valid path";
                }
            }
            finally
            {
                if (ErrorMessage != null) 
                    MessageBox.Show(ErrorMessage);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void buttonCrear_Click(object sender, EventArgs e)
        {
            try {
                string path = txtDirectorioActual.Text + "/" + txtDirectorioFichero.Text;

                if (checkboxFichero.Checked) {
                    if (File.Exists(@path))
                    {
                        MessageBox.Show("El fichero existe.");
                        return;
                    }
                    StreamWriter sw = File.CreateText(@path);
                    sw.Close();
                }

                if (checkboxCarpeta.Checked) {
                    if (Directory.Exists(@path)) {
                        MessageBox.Show("El Directorio existe.");
                        return;
                    }

                    DirectoryInfo di = Directory.CreateDirectory(@path);
                }
                buttonListar.PerformClick();
            }

            catch {
                MessageBox.Show("No se ha creado");
            }

        }


        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string path = txtDirectorioActual.Text + "/" + txtDirectorioFichero.Text;

                if (checkboxFichero.Checked)
                    File.Delete(@path);
                if (checkboxCarpeta.Checked) { 
                Directory.Delete(@path,true);
            }

                buttonListar.PerformClick();

               }
            catch { MessageBox.Show("No se ha eliminado"); }
        }

        private void buttonRenombrarMover_Click(object sender, EventArgs e)
        {
            try
            {
                string path1 = txtDirectorioActual.Text + "/" + listBox.SelectedItem.ToString();
                string path2 = txtDirectorioFichero.Text;

                if (checkboxFichero.Checked)
                    File.Move(path1, @path2);
                if (checkboxCarpeta.Checked)
                    Directory.Move(@path1, @path2);

                buttonListar.PerformClick();

            }

            catch { MessageBox.Show("No se a renombrado o movido"); }
        }


        private void checkboxFichero_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkboxCarpeta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtDirectorioFichero_TextChanged(object sender, EventArgs e)
        {

        }


        private void buttonVisualizarFichero_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox.SelectedItem == null) {
                    MessageBox.Show("Seleccione fichero.");
                    return;
                }
                
            
                FileInfo thisfile = new FileInfo(listBox.SelectedItem.ToString());
                textBox.Text = File.ReadAllText(thisfile.FullName); 
            }
            catch {
                MessageBox.Show("Es un directorio");
            }
        }

        private void buttonModificarFichero_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione fichero.");
                    return;
                }


                FileInfo thisfile = new FileInfo(listBox.SelectedItem.ToString());

                if (thisfile.Exists)
                    File.WriteAllText(thisfile.FullName, textBox.Text);
            }
            
            catch { MessageBox.Show("Es un directorio"); }
            }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDirectorioActual.Text = Directory.GetCurrentDirectory();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
