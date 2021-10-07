using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DixonCruzBlandon
{
    class HeapShort
    {
        public int cantidad, i = 0;
        public string[] nombres;
        public string[] identificacion;
        public int[] dias;
        public DateTime[] fecha;

        public HeapShort(int Cantidad)
        {
            this.cantidad = Cantidad;
            nombres = new string[Cantidad];
            identificacion = new string[Cantidad];
            dias = new int[Cantidad];
            fecha = new DateTime[Cantidad];
        }
        public void Agregar(string nomb, string ident, int diasE, DateTime fechaR)
        {
            if (i < cantidad)
            {
                this.nombres[i] = nomb;
                this.identificacion[i] = ident;
                this.dias[i] = diasE;
                this.fecha[i] = fechaR;
                i++;
            }
        }
        public void heapshort()
        {
            int ultimo = cantidad - 1;
            string auxinombre, auxiidentificacion;
            int auxidias;
            DateTime auxifecha;
            for (int i = (ultimo - 1) / 2; i >= 0; i--)
            {
                sort(i, ultimo);
            }
            for(int i = ultimo; i >= 1; i--)
            {
                auxinombre = nombres[0];
                nombres[0] = nombres[i];
                nombres[i] = auxinombre;

                auxiidentificacion = identificacion[0];
                identificacion[0] = identificacion[i];
                identificacion[i] = auxiidentificacion;

                auxidias = dias[0];
                dias[0] = dias[i];
                dias[i] = auxidias;

                auxifecha = fecha[0];
                fecha[0] = fecha[i];
                fecha[i] = auxifecha;

                sort(0, i - 1);
            }
        }
        public void sort(int inicio, int n)
        {
            int i;
            int j;
            bool band = false;
            string auxinombre, auxiidentificacion;
            int auxidias;
            DateTime auxifecha;
            i = inicio;
            j = 2 * i + 1;

            auxinombre = nombres[i];
            auxiidentificacion = identificacion[i];
            auxidias = dias[i];
            auxifecha = fecha[i];

            while(j<=n && (!band))
            {
                if (j < n)
                {
                    if (dias[j] < dias[j + 1])
                    {
                        j++;
                    }
                }
                if (auxidias >= dias[j])
                {
                    band = true;
                }
                else
                {
                    nombres[i] = nombres[j];
                    identificacion[i] = identificacion[j];
                    dias[i] = dias[j];
                    fecha[i] = fecha[j];
                    i = j;
                    j = 2 * i + 1;
                }
            }
            nombres[i] = auxinombre;
            identificacion[i] = auxiidentificacion;
            dias[i] = auxidias;
            fecha[i] = auxifecha;
        }
        public void Mostrar(DataGridView dgvclientes)
        {
            dgvclientes.Rows.Clear();
            for(int i = 0; i<cantidad; i++)
            {
                dgvclientes.Rows.Add(nombres[i], identificacion[i], dias[i], fecha[i]);
            }
        }
       
    }
}
