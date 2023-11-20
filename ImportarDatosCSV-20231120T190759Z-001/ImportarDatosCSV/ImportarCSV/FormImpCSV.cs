using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImportarCSV
{
    public partial class formImpCSV : Form
    {
        public formImpCSV()
        {
            InitializeComponent();
           
        }

        private void btImportarCSV_Click(object sender, EventArgs e)
        {
            string separador= txtSeparador.Text;
            if (separador == "")
            {
                MessageBox.Show("Debe inidcar el separador de columna" +
                    "CSC. Se separa por cosas o puntos y comas ","Fichero CSV vacio",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSeparador.Focus();
            }
            else
            {
                OpenFileDialog selCSV = new OpenFileDialog();
                selCSV.InitialDirectory = "C\\";
                selCSV.Filter = "CSV(*.csv)|*.csv |Todos los archivos (*.*)|*.*";
                selCSV.FilterIndex = 1;
                selCSV.RestoreDirectory = true;
                
                if (selCSV.ShowDialog() == DialogResult.OK)

                {

                    string ficheroCSv = selCSV.FileName;
                    //Establecer las propiedades de listViews

                    lsCSV.View = View.Details;
                    lsCSV.GridLines = true; 
                    lsCSV.FullRowSelect = true;
                    lsCSV.Items.Clear();

                 try
                    {
                        //Obtener la codificacion de nuestro
                        Encoding codificacion = Encoding.UTF8;
                        if (lsCodificacion.Text == "UTF-8")
                            codificacion = Encoding.UTF8;

                        //Recorremos todas las filas del fichero CSV
                        var lineasCSv = File.ReadLines(ficheroCSv, codificacion);

                        //Comprobamos que el fichero no este vacio

                        if (lineasCSv.Count() == 0)
                            MessageBox.Show($"El fichero CSV seleccionado [{ficheroCSv}] esta vacio", "Intente con otro vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        else
                        {
                            string valorActual = "";

                            //Si tomamos la primera fila como titulo
                            if (opTitulos.Checked)
                            {
                                var lineaTitulos = File.ReadAllLines(ficheroCSv, codificacion).First();

                                string[] columnasTitulos = lineaTitulos.Split(Convert.ToChar(separador));

                                //Añadimos las columnas a nuestro ListViews

                                for (int i = 0; i < columnasTitulos.Count(); i++)
                                {
                                    if (opComillas.Checked)
                                        valorActual = columnasTitulos[i].Trim(Convert.ToChar(lsComillas.Text));
                                    else
                                        valorActual = columnasTitulos[i];
                                    lsCSV.Columns.Add(valorActual);
                                }
                            }
                            int numLinea = 0;
                            foreach (string lineaActual in lineasCSv)
                            {
                                numLinea++;
                                if (opTitulos.Checked && numLinea == 1)
                                    continue;

                                string[] columnasLineasCSV = lineaActual.Split(Convert.ToChar(separador));
                                if (opComillas.Checked)
                                    valorActual = columnasLineasCSV[0].Trim(Convert.ToChar(lsComillas.Text));
                                else
                                    valorActual = columnasLineasCSV[0];
                                ListViewItem filasListViews = new ListViewItem(valorActual);

                                for(int i = 1; i <columnasLineasCSV.Count(); i++)
                                {
                                    if (opComillas.Checked)
                                        filasListViews.SubItems.Add(columnasLineasCSV[i].Trim(Convert.ToChar(lsComillas.Text)));
                                    else
                                        filasListViews.SubItems.Add(columnasLineasCSV[i]);
                                }
                                lsCSV.Items.Add(filasListViews);
                            }
                        }
                    }
                    catch(Exception error)
                    {
                        MessageBox.Show($"Error al leer fichero CSV: {error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
