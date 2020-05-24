using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/// <summary>
///   Clasa Form1.cs contine metodele din WinForm. Aceste functii evidentiaza functionalitatile API-ului.
/// </summary>

         
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void wait(int seconds)
        {

            DateTime now = DateTime.Now;
            while (now.AddSeconds(seconds) > DateTime.Now)
            {
                Application.DoEvents();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^ a-zA-Z+]"))
            {
                MessageBox.Show("Only letters!");
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "[^a-zA-Z+]"))
            {
                MessageBox.Show("Only Digits!");
                textBox5.Text = textBox5.Text.Remove(textBox5.Text.Length - 1);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox6.Text, "[^0-9a-zA-Z+]"))
            {
                MessageBox.Show("Only Letters and digits");
                textBox6.Text = textBox6.Text.Remove(textBox6.Text.Length - 1);
            }
        }

        private void insertPic_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                FileInfo fisier = new FileInfo(file);
                if (fisier.Extension.ToString().Equals(".jpg") || fisier.Extension.ToString().Equals(".png") || fisier.Extension.ToString().Equals(".jpeg") || fisier.Extension.ToString().Equals(".bmp"))
                {
                    textBox4.Text = "";
                    try
                    {
                        Image img = Image.FromFile(file);
                        int ok = 0;
                        var paths = Project1.Class1.GetPaths();
                        foreach (var x in paths)
                        {
                            if (String.Equals(x, fisier.FullName))
                            {
                                ok++;
                            }

                        }
                        if (ok > 0)
                        {
                            textBox4.Text += "Pic already exist";
                        }
                        else
                        {
                            Project1.Class1.Add(fisier.Name, fisier.FullName, fisier.Length.ToString(), fisier.CreationTime.ToString(), fisier.LastAccessTime.ToString(), fisier.Extension, img.Width + "x" + img.Height);
                            textBox4.Text += "Succes";
                        }
                    }
                    catch (IOException)
                    {
                    }
                }
            }
        }

        private void deletePic_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                int ok = 0;
                FileInfo fisier = new FileInfo(file);
                if (fisier.Extension.ToString().Equals(".jpg") || fisier.Extension.ToString().Equals(".png") || fisier.Extension.ToString().Equals(".jpeg"))
                {
                    textBox4.Text = "";
                    try
                    {
                        var paths = Project1.Class1.GetPaths();
                        foreach (var x in paths)
                        {
                            if (String.Equals(x, fisier.FullName))
                            {
                                ok++;
                            }
                        }
                        if (ok == 0)
                        {
                            textBox4.Text += "Pic doesn`t exist";
                        }
                        else
                        {
                            Project1.Class1.Remove(fisier.FullName);
                            textBox4.Text += "Succes";
                        }
                    }
                    catch (IOException)
                    {
                    }
                }
            }
        }

        private void checkDb_Click(object sender, EventArgs e)
        {
            var paths = Project1.Class1.GetPaths();
            textBox4.Text = "";
            foreach (var x in paths)
            {
                if (File.Exists(x))
                {
                    textBox4.Text += x + ":\n" + "File Exists" + Environment.NewLine;
                }
                else
                {
                    textBox4.Text += x + ":\n" + @"File Moved\Deleted" + Environment.NewLine;
                    Project1.Class1.Remove(x);
                }
            }
        }

        private void folderSee_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                int ok = 0;
                string path = folderBrowserDialog1.SelectedPath;
                textBox4.Text = "";
                if (Directory.Exists(path))
                {
                    foreach (String file in Directory.GetFiles(path))
                    {
                        if (file.Contains(".jpg") || file.Contains(".png") || file.Contains(".jpeg") || file.Contains(".ico"))
                        {
                            seePicture.Load(file);
                            ok++;
                            seePicture.SizeMode = PictureBoxSizeMode.StretchImage;
                            wait(2);
                        }
                    }
                    if (ok == 0)
                    {
                        textBox4.Text += "No pictures found!";
                    }
                }
            }
        }

        private void seePicture_Click(object sender, EventArgs e)
        {
              if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                FileInfo fisier = new FileInfo(file);
                if (fisier.Extension.ToString().Equals(".jpg") || fisier.Extension.ToString().Equals(".png") || fisier.Extension.ToString().Equals(".jpeg"))
                {
                    try
                    {
                        Image img = Image.FromFile(file);
                        textBox4.Text = "";
                        textBox4.Text += fisier.Name + Environment.NewLine;
                        textBox4.Text += fisier.CreationTime.ToString() + Environment.NewLine;
                        textBox4.Text += fisier.LastAccessTime.ToString() + Environment.NewLine;
                        textBox4.Text += fisier.Extension.ToString() + Environment.NewLine;
                        textBox4.Text += fisier.Length.ToString() + Environment.NewLine;
                        textBox4.Text += fisier.FullName + Environment.NewLine;
                        textBox4.Text += +img.Width + "x" + img.Height;
                        seePicture.Load(fisier.FullName);
                        seePicture.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (IOException)
                    {
                    }
                }
            }
        }

        private void selectAll_Click(object sender, EventArgs e)
        {
            var names = Project1.Class1.GetAll();
            textBox4.Text = "";
            int ok = 1;
            foreach (var x in names)
            {
                textBox4.Text += x + Environment.NewLine;
                if (ok % 8 == 0)
                {
                    textBox4.Text += Environment.NewLine;
                }
                ok++;

            }
            }

        private void getColumnNames_Click(object sender, EventArgs e)
        {
            var names = Project1.Class1.GetColumnNames();
            textBox4.Text = "";
            int ok = 0;
            foreach (var x in names)
            {
                textBox4.Text += ok.ToString() + ":\t" + x + Environment.NewLine;
                ok++;
            }
        }

        private void select_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            string textBoxValue = textBox5.Text;
            var result = Project1.Class1.Get(textBoxValue);
            if (result.Count() != 0)
            {
                int ok = 0;
                foreach (var x in result)
                {
                    textBox4.Text += ok.ToString() + ":\t" + x + Environment.NewLine;
                    ok++;
                }
            }
            else
            {
                textBox4.Text += "Column doesn`t exist!";
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            int ok = 0;
            var lista = Project1.Class1.GetAll();
            string textBoxValue = textBox6.Text;
            foreach (var file in lista)
            {
                if (file.Contains(textBoxValue))
                {
                    ok++;
                    textBox4.Text += "Found: "  + file + Environment.NewLine;
                }
            }
            if (ok == 0)
            {
                textBox4.Text += textBoxValue + " not found" + Environment.NewLine;
            }
        }
        private void updatePic_Click(object sender, EventArgs e)
        {
            string textBoxValue = textBox3.Text;
            textBox4.Text = "";
            string[] commands = textBoxValue.Split(' ');
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                int ok = 0;
                try
                {
                    FileInfo fisier = new FileInfo(file);
                    var paths = Project1.Class1.GetPaths();
                    foreach (var x in paths)
                    {
                        if (String.Equals(x, fisier.FullName))
                        {
                            ok++;
                        }
                    }
                    if (ok > 0)
                    {
                        Project1.Class1.Update(commands[0], commands[1], fisier.FullName);
                        textBox4.Text += "Succes";
                    }
                    else
                    {
                        textBox4.Text += "This pic isnt in the database";
                    }
                }
                catch (IOException)
                {
                }
            }
        }
    }
}

