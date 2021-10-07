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

namespace DixonCruzBlandon
{
    public partial class Mezcla_Directa : Form
    {
        int cantidad;
        int i;
        static StreamReader A_Lectura;
        static StreamReader A1_Lectura;
        static StreamReader A2_Lectura;

        static StreamWriter A_Escritura;
        static StreamWriter A1_Escritura;
        static StreamWriter A2_Escritura;

        public struct Registro
        {
            public int elemento;
        }
        Registro[] dato;
        public Mezcla_Directa()
        {
            InitializeComponent();
            cantidad = 0;
            i = 0;
        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtCant.Text)|| int.Parse(txtCant.Text) <= 0)
            {
                MessageBox.Show("Ingresa el tamaño del arreglo", "Error");
            }
            else
            {
                cantidad = int.Parse(txtCant.Text);
                dato = new Registro[cantidad];
                A_Escritura = new StreamWriter("A.txt");
                txtCant.Enabled = false;
                btncontinuar.Enabled = false;
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                dato[i].elemento = int.Parse(txtelemento.Text);
                A_Escritura.WriteLine(txtelemento.Text);
                A_Escritura.Flush();
                ListaDesordenada.Items.Add(dato[i].elemento);
                i++;
                MessageBox.Show("Se guardo el elemento","Informacion", MessageBoxButtons.OK);
                txtelemento.Clear();
                txtelemento.Focus();
            }
            catch
            {
                MessageBox.Show("Limite de elementos","Error");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            A1_Lectura = new StreamReader("A.txt");
            while (!A1_Lectura.EndOfStream)
            {
                ListaOrdenada.Items.Add(A1_Lectura.ReadLine());
            }
            A1_Lectura.Close();
        }
        public static int ObtenerCantidad(StreamReader archivoPrincipal)
        {
            archivoPrincipal = new StreamReader("A.txt");
            int cantidad = 0;
            while (!archivoPrincipal.EndOfStream)
            {
                string cadena = archivoPrincipal.ReadLine();
                cantidad++;
            }
            archivoPrincipal.Close();
            return cantidad;
        }
        public static void Mezclar(StreamReader A_Lectura, StreamWriter A_Escritura, StreamReader A1_Lectura,StreamWriter A1_Escritura, StreamReader A2_Lectura, StreamWriter A2_Escritura)
        {
            int particion = 1, vueltas = ObtenerCantidad(A_Lectura);

            while (particion <= vueltas)
            {
                A_Lectura = new StreamReader("A.txt");
                A1_Escritura = new StreamWriter("A1.txt");
                A2_Escritura = new StreamWriter("A2.txt");

                Particionar(A_Lectura, A1_Escritura, A2_Escritura, particion);

                A_Lectura.Close();
                A1_Escritura.Close();
                A2_Escritura.Close();

                A_Escritura = new StreamWriter("A.txt");
                A1_Lectura = new StreamReader("A1.txt");
                A2_Lectura = new StreamReader("A2.txt");

                Fusionar(A_Escritura, A1_Lectura, A2_Lectura, particion);

                particion *= 2;
            }
            Console.WriteLine("\n*** Fin del archivo ***");
        }
        public static void Particionar(StreamReader A_Lectura, StreamWriter A1_Escritura, StreamWriter A2_Escritura, int particion)
        {
            int puntero = 0;

            while (!A_Lectura.EndOfStream)
            {
                int puntero_F1 = 0;
                while (puntero_F1 < particion && !A_Lectura.EndOfStream)
                {
                    puntero = Convert.ToInt32(A_Lectura.ReadLine());
                    A1_Escritura.WriteLine(puntero);
                    puntero_F1++;
                }

                int puntero_F2 = 0;
                while (puntero_F2 < particion && !A_Lectura.EndOfStream)
                {
                    puntero = Convert.ToInt32(A_Lectura.ReadLine());
                    A2_Escritura.WriteLine(puntero);
                    puntero_F2++;
                }
            }
        }
        public static void Fusionar(StreamWriter A_Escritura, StreamReader A1_Lectura, StreamReader A2_Lectura, int particion)
        {
            bool bandera_1 = true, bandera_2 = true;

            int read_1 = 0, read_2 = 0;


            if (!A1_Lectura.EndOfStream)
            {
                read_1 = Convert.ToInt32(A1_Lectura.ReadLine());
                bandera_1 = false;
            }

            if (!A2_Lectura.EndOfStream)
            {
                read_2 = Convert.ToInt32(A2_Lectura.ReadLine());
                bandera_2 = false;
            }

            while ((!A1_Lectura.EndOfStream || bandera_1 == false) && (!A2_Lectura.EndOfStream || bandera_2 == false))
            {
                int puntero_1 = 0, puntero_2 = 0;

                while ((puntero_1 < particion && bandera_1 == false) && (puntero_2 < particion && bandera_2 == false))
                {
                    if (read_1 <= read_2)
                    {
                        A_Escritura.WriteLine(read_1);
                        bandera_1 = true; puntero_1++;

                        if (!A1_Lectura.EndOfStream)
                        {
                            read_1 = Convert.ToInt32(A1_Lectura.ReadLine());
                            bandera_1 = false;
                        }
                    }
                    else
                    {
                        A_Escritura.WriteLine(read_2);
                        bandera_2 = true; puntero_2++;
                        if (!A2_Lectura.EndOfStream)
                        {
                            read_2 = Convert.ToInt32(A2_Lectura.ReadLine());
                            bandera_2 = false;
                        }
                    }
                }

                while (puntero_1 < particion && bandera_1 == false)
                {
                    A_Escritura.WriteLine(read_1);
                    bandera_1 = true; puntero_1++;

                    if (!A1_Lectura.EndOfStream)
                    {
                        read_1 = Convert.ToInt32(A1_Lectura.ReadLine());
                        bandera_1 = false;
                    }
                }

                while (puntero_2 < particion && bandera_2 == false)
                {
                    A_Escritura.WriteLine(read_2);
                    bandera_2 = true; puntero_2++;

                    if (!A2_Lectura.EndOfStream)
                    {
                        read_2 = Convert.ToInt32(A2_Lectura.ReadLine());
                        bandera_2 = false;
                    }
                }

            }

            if (bandera_1 == false) { A_Escritura.WriteLine(read_1); }

            if (bandera_2 == false) { A_Escritura.WriteLine(read_2); }

            while (!A1_Lectura.EndOfStream)
            {
                read_1 = Convert.ToInt32(A1_Lectura.ReadLine());
                A_Escritura.WriteLine(read_1);
            }

            while (!A2_Lectura.EndOfStream)
            {
                read_2 = Convert.ToInt32(A2_Lectura.ReadLine());
                A_Escritura.WriteLine(read_2);
            }

            A_Escritura.Close();
            A1_Lectura.Close();
            A2_Lectura.Close();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            try
            {
                A_Escritura.Close();
                Mezclar(A_Lectura, A_Escritura, A1_Lectura, A1_Escritura, A2_Lectura, A2_Escritura);
                MessageBox.Show("Los elementos han sido ordenados", "Informacion");
                btnMostrar.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido lo siguiente: " + ex);
            }
        }
    }
}
