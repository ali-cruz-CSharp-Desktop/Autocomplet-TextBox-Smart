using AutocompletTextBox_Smart.Core;
using AutocompletTextBox_Smart.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutocompletTextBox_Smart
{
    public partial class Form3 : Form
    {
        private DataTable dataUsers;
        private ListItem selectedItem;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            InicializaTxbAndData();
        }



        private DataTable GetDataFromDB()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_GetAllUsers", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();

                        DataTable dtUsers = new DataTable();
                        Response response = new Response();

                        SqlDataReader dataReader = cmd.ExecuteReader();

                        dtUsers.Load(dataReader);
                        //response.dt.Load(dataReader);


                        return dtUsers;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        private void InicializaTxbAndData()
        {
            dataUsers = new DataTable();
            dataUsers = GetDataFromDB();

            listBox13.DataSource = dataUsers;
            textBox1.TextChanged += textBox1_TextChanged;
            listBox13.MouseClick += listBox13_MouseClick;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("\n\n\ttextBox1_TextChanged ");
            //List<ListItem> items = new List<ListItem>();            

            string filter = textBox1.Text;
            // Filtrando
            ListItem[] filtered = dataUsers.AsEnumerable()
                            .Where(x =>
                                CultureInfo.InvariantCulture.CompareInfo
                                .IndexOf(x.Field<string>("Nombre"),
                                        filter,
                                        CompareOptions.IgnoreNonSpace |
                                        CompareOptions.IgnoreCase) >= 0)
                            //.Where(x => RemoveDiacritics(x.Field<string>("Nombre").ToLower())
                            //.Contains(RemoveDiacritics(textBox1.Text.Trim().ToLower())))
                            //.Select(x => new { Nombre = x.Field<string>("Nombre") }).ToArray();
                            //.Select(x => x.Field<string>("Nombre")).ToArray();
                            .Select(x => new ListItem
                            {
                                Clave = x.Field<int>("Clave"),
                                DisplayValue = x.Field<string>("Nombre")
                            })
                                    .ToArray();

            if (filtered.Length > 0)
            {
                // Get position of textbox
                Point textBoxLocation = textBox1.Location;
                int X = textBoxLocation.X;
                int Y = textBoxLocation.Y;

                listBox13.Location = new Point(X, Y + 35);

                // Existen coincidencias
                listBox13.Visible = true;
                listBox13.DataSource = filtered;
                selectedItem = (ListItem)listBox13.SelectedItem;
                listBox13.Height = 250;
                listBox13.BringToFront();
                System.Diagnostics.Debug.WriteLine($"IF - filteredItems.Length: {filtered.Length} - ID: {selectedItem.Clave}");
            }
            else
            {
                // NO coincidencias
                System.Diagnostics.Debug.WriteLine($"ELSE");
                listBox13.Visible = false;
                selectedItem = null;
            }

            System.Diagnostics.Debug.WriteLine("TxbNombres_TextChanged END ");
        }



        private void listBox13_MouseClick(object sender, MouseEventArgs e)
        {
            // Get the index of the item that was clicked
            int index = listBox13.IndexFromPoint(e.Location);

            // If an item was clicked, handle the click event
            if (index >= 0)
            {
                // Do something with the clicked item, e.g. display its text in a message box
                //selectedItem.DisplayValue
                textBox1.Text = listBox13.Items[index].ToString();
                //Console.WriteLine(listBox13.Items[index].ToString());
            }

            listBox13.Visible = false;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            UsuarioRegistrado usuarioRegistrado = new UsuarioRegistrado();
            if (!IsNullEmptyOrWhiteSpace(selectedItem))
            {
                usuarioRegistrado.Clave = selectedItem.Clave;
                usuarioRegistrado.Nombre = selectedItem.DisplayValue;
            }
            else
            {
                usuarioRegistrado.Nombre = textBox1.Text.Trim();
            }
            int res = InsertaNuevoEmpleadoRegistrado(usuarioRegistrado);

            if (res != -1)
            {
                MessageBox.Show("Ingresado con éxito");
            }
        }

        private int InsertaNuevoEmpleadoRegistrado(UsuarioRegistrado usuarioRegistrado)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("uspInsertaNuevoEmpleadoRegistrado", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.Parameters.Add("@Clave", SqlDbType.Int).Value = usuarioRegistrado.Clave > 0 ? DBNull.Value : usuarioRegistrado.Clave;
                        cmd.Parameters.Add("@Clave", SqlDbType.Int).Value = usuarioRegistrado.Clave > 0 ? usuarioRegistrado.Clave : 0;
                        cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100).Value = usuarioRegistrado.Nombre;

                        if (conn.State != ConnectionState.Open)
                            conn.Open();

                        int rowInserter = Convert.ToInt32(cmd.ExecuteNonQuery());
                        return rowInserter;
                    }
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
        }


        private bool IsNullEmptyOrWhiteSpace(object obj)
        {
            if (obj == null)
            {
                return true;
            }

            if (obj is string str)
            {
                return string.IsNullOrWhiteSpace(str);
            }

            return false;
        }


    }
}
