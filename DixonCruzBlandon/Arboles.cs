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
    public partial class Arboles : Form
    {
        int axu,
            posX,
            posY,
            i = 0;

        public int Precio = 150;

        //Variable de tipo arbol la cual servira para dibujar el arbol
        Arbol arbol;
        Graphics nodo;

        public int cantCL { get; set; }
        public struct Clientes
        {
            public string nombres { get; set; }
            public string identificacion { get; set; }
            public int dias { get; set; }
            public DateTime fecha { get; set; }
            public double total { get; set; }
        }


        Clientes[] datos;
        public Arboles()
        {
            InitializeComponent();
            nodo = CreateGraphics();
            arbol = new Arbol(nodo, Font);
            gbEliminar.Enabled = false;
            gbRecorridos.Enabled = false;
            gbDatos.Enabled = false;
        }

        private void Arboles_Paint(object sender, PaintEventArgs e)
        {
            arbol.MostrarArbol(e, this.BackColor);
        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {
            try
            {
                cantCL = Convert.ToInt32(txtCant.Text);
                axu = cantCL;

                if (cantCL < 0 || txtCant.Text.Length > 8)
                {
                    MessageBox.Show("Cantidad ingresada no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    datos = new Clientes[cantCL];
                    gbDatos.Enabled = true;
                    gbCantidad.Enabled = false;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Cantidad ingresada no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Limpiar()
        {
            txtnombre.Clear();
            txtidentificacion.Clear();
            txtdias.Clear();
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (i == cantCL)
            {
                MessageBox.Show("Limite de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                try
                {
                    datos[i].nombres = txtnombre.Text;
                    datos[i].identificacion = txtidentificacion.Text;
                    datos[i].dias = int.Parse(txtdias.Text);
                    datos[i].fecha = DateTime.Parse(txtfecha.Text);
                    datos[i].total = (datos[i].dias * Precio);

                    if (!arbol.InsertarDatos(datos[i].total))
                    {
                        MessageBox.Show("No se pueden ingresar valores duplicados.\nIngrese los dias nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtdias.Clear();
                        txtdias.Focus();
                    }
                    else
                    {
                        dataGridView1.Rows.Add(datos[i].nombres, datos[i].identificacion, datos[i].dias, datos[i].fecha, datos[i].total);
                        Refresh();
                        Limpiar();
                        txtnombre.Focus();
                        i++;
                    }
                    if (i > 0)
                    {
                        gbRecorridos.Enabled = true;
                    }
                    if (i == cantCL)
                    {
                        gbEliminar.Enabled = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Datos erroneos.\nRevisar los datos previamente ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
        }
    }
}
