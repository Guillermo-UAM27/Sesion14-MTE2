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

namespace Sesion14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_Click(object sender, EventArgs e)
        {
            try
            {
                using (FileStream mArchivoEscritor = new FileStream("datos.dat", FileMode.OpenOrCreate, FileAccess.Write))
                using (BinaryWriter Escritor = new BinaryWriter(mArchivoEscritor))
                {
                   
                    {
                        string nombre = tbNombre.Text;
                        int edad = int.Parse(tbEdad.Text);
                        int nota = int.Parse(tbNota.Text);
                        char genero = char.Parse(tbSexo.Text);

                        Escritor.Write(nombre.Length); 
                        Escritor.Write(nombre.ToCharArray()); 
                        Escritor.Write(edad);
                        Escritor.Write(nota);
                        Escritor.Write(genero);

                        MessageBox.Show("Datos guardados correctamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al escribir los datos: " + ex.Message);
            }




        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                using (FileStream mArchivoLector = new FileStream("datos.dat", FileMode.Open, FileAccess.Read))
                using (BinaryReader Lector = new BinaryReader(mArchivoLector))
                {
                    while (mArchivoLector.Position != mArchivoLector.Length)
                    {
                        int length = Lector.ReadInt32(); 
                        char[] nombreArray = Lector.ReadChars(length);
                        string nombre = new string(nombreArray);
                        int edad = Lector.ReadInt32();
                        int nota = Lector.ReadInt32();
                        char genero = Lector.ReadChar();


                        {
                            listBox1.Items.Add($"Nombre: {nombre}");

                            listBox1.Items.Add($" Edad: {edad}");
                            listBox1.Items.Add($" Nota: {nota}");
                            listBox1.Items.Add($" Género: {genero}");
                            listBox1.Items.Add("-------------------");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer los datos: " + ex.Message);
            }

        }
    }
}
