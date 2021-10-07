using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DixonCruzBlandon
{
    class BusquedaBinaria
    {
        public int cantidad, i = 0;

        public string[] nombres;
        public string[] identificacion;
        public int[] dias;
        public DateTime[] fecha;

        public BusquedaBinaria(int Cantidad)
        {
            this.cantidad = Cantidad;
            nombres = new string[Cantidad];
            identificacion = new string[Cantidad];
            dias = new int[Cantidad];
            fecha = new DateTime[Cantidad];
        }
        public void Agregar(string nomb, string ident, int diasE, DateTime fechaR)
        {
            if(i< cantidad)
            {
                this.nombres[i] = nomb;
                this.identificacion[i] = ident;
                this.dias[i] = diasE;
                this.fecha[i] = fechaR;
                i++;
            }
        }
        public void Binaria(string x)
        {
            int izq, cen = 0, der;
            bool band = false;

            izq = 0;
            der = cantidad - 1;
            band = false;
           while(izq<=der &&band==false)
            {
                if (x == identificacion[cen])
                {
                    band = true;
                }
                else
                {
                    cen++;
                }
                if (identificacion[cen].CompareTo(x) > 0)
                {
                    izq = cen + 1;
                }
                else
                {
                    der = cen - 1;
                }
            }
            if (band == true)
            {
                MessageBox.Show(string.Format("\n\nInformacion:\n \n-Nombres: {0} \n-Identificacion: {1} \n-Dias de estancia: {2} \n-Fecha de la reservacion: {3}"
                    , nombres[cen], identificacion[cen], dias[cen], fecha[cen]), "Busqueda encontrada");
            }
            else
            {
                MessageBox.Show("La informacion no ha sido encontrada");
            }
        }
    }
}
