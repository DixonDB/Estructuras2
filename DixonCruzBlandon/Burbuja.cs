using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DixonCruzBlandon
{
    class Burbuja
    {
        public int cantidad, i = 0;
        public string[] nombres;
        public string[] identificacion;
        public int[] dias;
        public DateTime[] fecha;

        public Burbuja (int Cant)
        {
            this.cantidad = Cant;
            nombres = new string[Cant];
            identificacion = new string[Cant];
            dias = new int[Cant];
            fecha = new DateTime[Cant];
        }
        public void Agregar(string nomb, string ident, int di, DateTime fec)
        {
            if(i< cantidad)
            {
                this.nombres[i] = nomb;
                this.identificacion[i] = ident;
                this.dias[i] = di;
                this.fecha[i] = fec;
                i++;
            }
        }
        public void burbuja()
        {
            string auxinombre, auxiidentificacion;
            int auxidias;
            DateTime auxifecha;
            for(int i=0; i < cantidad; i++)
            {
                for(int j = i + 1; j < cantidad; j++)
                {
                    if (nombres[i].CompareTo(nombres[j]) <= 0)
                    {
                        auxinombre = nombres[i];
                        nombres[i] = nombres[j];
                        nombres[j] = auxinombre;

                        auxiidentificacion = identificacion[i];
                        identificacion[i] = identificacion[j];
                        identificacion[j] = auxiidentificacion;

                        auxidias = dias[i];
                        dias[i] = dias[j];
                        dias[j] = auxidias;

                        auxifecha = fecha[i];
                        fecha[i] = fecha[j];
                        fecha[j] = auxifecha;
                    }
                }
            }
        }
        public void Mostrar(DataGridView dgv)
        {
            dgv.Rows.Clear();
            for(int i = 0; i < cantidad; i++)
            {
                dgv.Rows.Add(nombres[i], identificacion[i], dias[i], fecha[i]);
            }
        }
    }
}
