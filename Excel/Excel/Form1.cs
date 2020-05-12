using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excel
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        DataView ImportarDatos(String nombrearchivo)
        {
            string conexion = string.Format("provider = Microsoft.ACE.OLEDB.12.0; Data Source = {0}; Extended Properties = 'Excel 12.0;'", nombrearchivo);

            OleDbConnection conector = new OleDbConnection(conexion);

            conector.Open();

            OleDbCommand consulta = new OleDbCommand("select * from [Hoja1$]", conector);

            OleDbDataAdapter adaptador = new OleDbDataAdapter
            {
                SelectCommand = consulta
            };
            DataSet ds = new DataSet();

            adaptador.Fill(ds);

            DataTable table = ds.Tables[0];
            //DataRow[] rows = table.Select();

            for (int i = 0; i <= ds.Tables[0].Rows[0].ItemArray.Length -1; i++)
            {
                Console.WriteLine(ds.Tables[0].Rows[0].ItemArray[i] + " -- " + ds.Tables[0].Rows[0].Table.Columns[i]);
            }


            /*  for (int i = 0; i <= ds.Tables[0].Rows[0].ItemArray.Length - 1; i++)
              {
                  MessageBox.Show(ds.Tables[0].Rows[0].ItemArray[i] + " -- " + ds.Tables[0].Rows[0].Table.Columns[i]);
              }*/


            conector.Close();

            return ds.Tables[0].DefaultView;

        }

        private void ObtenerDatos()
        {
            
        }

        private void BtnImportarDatos_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel | *.xls;*.xlsx;",
                Title ="Select Archivo"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DataDetalles.DataSource = ImportarDatos(openFileDialog.FileName);
            }


        }
    }
}
