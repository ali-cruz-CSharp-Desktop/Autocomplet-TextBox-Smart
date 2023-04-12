using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutocompletTextBox_Smart
{
    public partial class Form1 : Form
    {
        private string[] names;
        //private Thread thread1 = new Thread(Form1.InicializaTxbAndData);

        public Form1()
        {
            InitializeComponent();

            System.Diagnostics.Debug.WriteLine("Form1 ");
            
            InicializaTxbAndData();

            CmbNames.DataSource = names;
            comboBox1_.DataSource = names;

            

            System.Diagnostics.Debug.WriteLine("Form1 END");
        }

        private void InicializaTxbAndData()
        {

            names = File.ReadAllLines("People.txt");
            TxbNombres.TextChanged += TxbNombres_TextChanged;


            ToolTip tooltip = new ToolTip();
            tooltip.InitialDelay = 2;
            tooltip.ToolTipTitle = "Ingrese un nombre";
            tooltip.ToolTipIcon = ToolTipIcon.Info;
            tooltip.IsBalloon = true;
            tooltip.ShowAlways = true;
            //tooltip.SetToolTip(TxbNombres, "Seleccione un nombre.");
        }

        private void TxbNombres_TextChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("\n\n\nTxbNombres_TextChanged ");
            CmbNames.MouseClick += CmbNames_MouseClick1;
            CmbNames.DroppedDown = false;
            CmbNames.Visible = false;
            CmbNames.DataSource = null;
            string filter = TxbNombres.Text.ToLower();
            string[] filteredItems = names
                                        .Cast<string>()
                                        .Where(item => item.ToLower()
                                        .Contains(filter))
                                        .ToArray();

            if (filteredItems.Length > 0 && filteredItems.Length != names.Length)
            {
                CmbNames.DataSource = filteredItems;
                CmbNames.DroppedDown = true;
                System.Diagnostics.Debug.WriteLine($"IF - filteredItems.Length: {filteredItems.Length}");
            } else
            {
                if (CmbNames.DroppedDown != false)
                {
                    CmbNames.DroppedDown = false;
                    CmbNames.Visible = false;
                    System.Diagnostics.Debug.WriteLine("ELSE");
                }

            }

            System.Diagnostics.Debug.WriteLine("TxbNombres_TextChanged END ");
        }

        private void CmbNames_MouseClick1(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("CmbNames_MouseClick1");
            throw new NotImplementedException();
        }

        private void CmbNames_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("***CmbNames_MouseClick");
            int index = 0;// CmbNames.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                // An item was clicked
                MessageBox.Show("Item clicked: " + CmbNames.Items[index].ToString());
            }
        }

        private void CmbNames_MouseCaptureChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("*** CmbNames_MouseCaptureChanged");
        }

        private void CmbNames_MouseHover(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("*** CmbNames_MouseHover");

        }

        private void CmbNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Type eventType = e.GetType();

            //System.Diagnostics.Debug.WriteLine($"\n\n\n************* CmbNombres_SelectedIndexChanged - sender {sender.ToString()} : e {e.ToString()} - eventType.FullName: {eventType.Name}");
            //try
            //{
            //    //TxbNombres.Text = CmbNombres.SelectedItem;
            //    if (CmbNames.SelectedItem.ToString() != string.Empty)
            //    {
            //        TxbNombres.Text = CmbNames.SelectedItem.ToString();
            //        System.Diagnostics.Debug.WriteLine("SelectedItem " + CmbNames.SelectedItem);
            //        System.Diagnostics.Debug.WriteLine("SelectedValue " + CmbNames.SelectedValue.ToString());
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("\nError: " + ex);
            //}

            //System.Diagnostics.Debug.WriteLine("CmbNombres_SelectedIndexChanged END");

        }

        private void CmbNames_MouseMove(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("**** CmbNames_MouseMove");
        }

        private void CmbNames_DropDown(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("**** CmbNames_DropDown");
        }

        private void CmbNames_MouseDown(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("**** CmbNames_MouseDown");
            
            CmbNames = ((ComboBox)sender);
            Point point = new Point(e.X, e.Y);
            //int index = CmbNames.IndexFromPoint(point);

        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("**** comboBox1_MouseClick");
        }

        private void comboBox1_MouseDown(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("**** comboBox1_MouseDown");
        }
    }
}
