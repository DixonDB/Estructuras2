using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DixonCruzBlandon
{
    public partial class Form1 : Form
    {
        public int cantCL, i = 0;
        public struct Clientes
        {
            public string nombres;
            public string identificacion;
            public int dias;
            public DateTime fecha;
        }
        Clientes[] datos;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (i < cantCL)
            {
                datos[i].nombres = txtnombres.Text;
                datos[i].identificacion = txtidentificacion.Text;
                datos[i].dias = int.Parse(txtdias.Text);
                datos[i].fecha = DateTime.Parse(txtfecha.Text);
                dgvclientes.Rows.Add(datos[i].nombres, datos[i].identificacion, datos[i].dias, datos[i].fecha);
                i++;
                MessageBox.Show("Se Agrego un nuevo Registro", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Limpiar();
            }
            else
            {
                MessageBox.Show("Limite de datos", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnordenar_Click(object sender, EventArgs e)
        {
            //Metodo Shell
            if (rdbshell.Checked)
            {
                Shell shell = new Shell(cantCL);
                for(int i = 0; i < cantCL; i++)
                {
                    shell.Agregar(datos[i].nombres, datos[i].identificacion, datos[i].dias, datos[i].fecha);
                }
                shell.shell();
                shell.Mostrar(dgvclientes);
            }
            //Metodo Seleccion directa
            if (rdbselecciondirecta.Checked)
            {
                SeleccionDirecta seleccion = new SeleccionDirecta(cantCL);
                for(int i=0; i < cantCL; i++)
                {
                    seleccion.Agregar(datos[i].nombres, datos[i].identificacion, datos[i].dias, datos[i].fecha);
                }
                seleccion.Seleccion();
                seleccion.Mostrar(dgvclientes);
            }
            //Metodo intercambio directo o burbuja
            if (rdbburbuja.Checked)
            {
                Burbuja burbuja = new Burbuja(cantCL);
                for(int i =0; i < cantCL; i++)
                {
                    burbuja.Agregar(datos[i].nombres, datos[i].identificacion, datos[i].dias, datos[i].fecha);
                }
                burbuja.burbuja();
                burbuja.Mostrar(dgvclientes);
            }
            //Metodo Heapsort
            if (rdbHeapshort.Checked)
            {
                HeapShort heap = new HeapShort(cantCL);
                for(int i = 0; i < cantCL; i++)
                {
                    heap.Agregar(datos[i].nombres, datos[i].identificacion, datos[i].dias, datos[i].fecha);
                }
                heap.heapshort();
                heap.Mostrar(dgvclientes);
            }
            //Metodo insercion directa o baraja
            if (rdbbaraja.Checked)
            {
                InsercionDirecta_Baraja baraja = new InsercionDirecta_Baraja(cantCL);
                for(int i=0; i < cantCL; i++)
                {
                    baraja.Agregar(datos[i].nombres, datos[i].identificacion, datos[i].dias, datos[i].fecha);
                }
                baraja.Insercion();
                baraja.Mostrar(dgvclientes);
            }
            //Metodo quicksort
            if (rdbquicksort.Checked)
            {
                Quicksort quicksort = new Quicksort(cantCL);
                for (int i = 0; i < cantCL; i++)
                {
                    quicksort.Agregar(datos[i].nombres, datos[i].identificacion, datos[i].dias, datos[i].fecha);
                }
                quicksort.quicksort();
                quicksort.Mostrar(dgvclientes);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (rdbintercalacion.Checked)
            {
                Intercalacion_de_archivos intercalacion = new Intercalacion_de_archivos();
                intercalacion.Show();
            }
            if (rdbMezcla.Checked)
            {
                Mezcla_Directa mezcla = new Mezcla_Directa();
                mezcla.Show();
            }
        }

        private void btnbusqueda_Click(object sender, EventArgs e)
        {
            BusquedaBinaria busqueda = new BusquedaBinaria(cantCL);
            for(int i=0; i < cantCL; i++)
            {
                busqueda.Agregar(datos[i].nombres, datos[i].identificacion, datos[i].dias, datos[i].fecha);
            }
            busqueda.Binaria(txtbusqueda.Text);
        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {
            if( string.IsNullOrWhiteSpace(txtcant.Text) || int.Parse(txtcant.Text) <= 0)
            {
                MessageBox.Show("Ingresa un valor valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcant.Clear();
                txtcant.Focus();
            }
            else
            {
                cantCL = int.Parse(txtcant.Text);
                datos = new Clientes[cantCL];
                txtcant.Enabled = false;
                btncontinuar.Enabled = false;
                gbcliente.Enabled = true;
                txtnombres.Focus();
            }
            
        }
        private void Limpiar()
        {
            txtnombres.Clear();
            txtidentificacion.Clear();
            txtdias.Clear();
        }
    }
}
