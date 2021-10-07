using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DixonCruzBlandon
{
    class SeleccionDirecta
    {
        public int cantidad, i = 0;
        public string[] nombres;
        public string[] identificacion;
        public int[] dias;
        public DateTime[] fecha;

        public SeleccionDirecta(int Cant)
        {
            this.cantidad = Cant;
            nombres = new string[Cant];
            identificacion = new string[Cant];
            dias = new int[Cant];
            fecha = new DateTime[Cant];
        }
        public void Agregar(string nomb, string iden, int dia, DateTime fe)
        {
            if (i < cantidad)
            {
                this.nombres[i] = nomb;
                this.identificacion[i] = iden;
                this.dias[i] = dia;
                this.fecha[i] = fe;
                i++;
            }
        }
        public void Seleccion()
        {
            string auxinombre, auxiidentificacion;
            int auxidias;
            DateTime auxifecha;
            for(int i = 0; i < cantidad; i++)
            {
                int posMin = i;
                for(int j = i + 1; j < cantidad; j++)
                {
                    if (nombres[j].CompareTo(nombres[i]) >= 0)
                    {
                        posMin = j;
                    }
                    if (i != posMin)
                    {
                        auxinombre = nombres[i];
                        nombres[i] = nombres[posMin];
                        nombres[posMin] = auxinombre;

                        auxiidentificacion = identificacion[i];
                        identificacion[i] = identificacion[posMin];
                        identificacion[posMin] = auxiidentificacion;

                        auxidias = dias[i];
                        dias[i] = dias[posMin];
                        dias[posMin] = auxidias;

                        auxifecha = fecha[i];
                        fecha[i] = fecha[posMin];
                        fecha[posMin] = auxifecha;
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
