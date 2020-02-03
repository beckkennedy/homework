using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {

        //C:\Users\beck\Source\Repos\Assignment1\Assignment1\bin\Debug
        string fileName = "list.txt";

        public Form1()
        {
            InitializeComponent();
            if (File.Exists(fileName))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(fileName))
                    {
                        string line;
                        
                        while ((line = sr.ReadLine()) != null)
                        {
                            listBox1.DataSource = File.ReadAllLines(fileName);
                        }
                    }
                }

                catch (Exception ex)
                {
                    labelError.Text = "The file could not be read:";
                    Console.WriteLine(ex.Message);
                }
            } else
            {
                labelError.Text = "ERROR: File does not exist.";
            }
         
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                labelError.Text = "ERROR: Type in item you want to add.";
            }
            else
            {
                string alreadyAdded = textBox1.Text;
                var list = File.ReadAllLines(fileName);
                if (list.Contains(alreadyAdded))
                {
                    labelError.Text = "ERROR: Item already exists";
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(fileName))
                    {
                        sw.WriteLine(textBox1.Text);
                        labelError.Text = "Added Successfully!";
                    }
                }

                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        listBox1.DataSource = File.ReadAllLines(fileName);
                    }
                }

                //clear textbox after entry
                textBox1.Text = "";
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            
            string deleteThis = textBox1.Text;
            var list = File.ReadAllLines(fileName);
            if (list.Contains(deleteThis))
            {
                var newList = list.Where(line => !line.Contains(deleteThis));
                File.WriteAllLines(fileName, newList);

                listBox1.DataSource = File.ReadAllLines(fileName);

                labelError.Text = "Removed Successfully!";
            }

            else
            {
                if (textBox1.Text.Equals(""))
                {
           
                    labelError.Text = "ERROR: Type in item you want to delete.";
                }

                else
                {
                    labelError.Text = "ERROR: Item Not Found";
                }
            }

            textBox1.Text = "";
            //textBox1.Text = Environment.CurrentDirectory;
            //Console.WriteLine(Environment.CurrentDirectory);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
