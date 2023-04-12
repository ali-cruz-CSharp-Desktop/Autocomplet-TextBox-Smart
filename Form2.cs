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

namespace AutocompletTextBox_Smart
{
    public partial class Form2 : Form
    {
        private string[] names;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            InicializaTxbAndData();
        }

        private void InicializaTxbAndData()
        {
            names = File.ReadAllLines("People.txt");
            comboBox1.DataSource = names;            
            textBox1.TextChanged += textBox1_TextChanged;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("\n\n\ttextBox1_TextChanged ");

           
                comboBox1.DroppedDown = false;
            

            comboBox1.DroppedDown = true;
            //comboBox1.DroppedDown = false;
            //comboBox1.Visible = false;
            comboBox1.DataSource = null;
            string filter = textBox1.Text.ToLower();
            string[] filteredItems = names
                                        .Cast<string>()
                                        .Where(item => item.ToLower()
                                        .Contains(filter))
                                        .ToArray();

            if (filteredItems.Length > 0 && filteredItems.Length != names.Length)
            {
                comboBox1.DataSource = filteredItems;
                
                //comboBox1.DroppedDown = true;
                System.Diagnostics.Debug.WriteLine($"IF - filteredItems.Length: {filteredItems.Length}");
            }
            else
            {
                if (comboBox1.DroppedDown != false)
                {
                    //comboBox1.DroppedDown = false;
                    //comboBox1.Visible = false;
                    System.Diagnostics.Debug.WriteLine("ELSE");
                }
            }

            System.Diagnostics.Debug.WriteLine("TxbNombres_TextChanged END ");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                if (comboBox1.SelectedIndex != -1)
                    textBox1.Text = comboBox1.SelectedValue.ToString();
            }            
        }

    }
}
