using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DixonCruzBlandon
{
    class Shell
    {
        public int cantidad, i = 0;
        public string[] nombres;
        public string[] identificacion;
        public int[] dias;
        public DateTime[] fecha;

        public Shell(int cant)
        {
            this.cantidad = cant;
            nombres = new string[cant];
            identificacion = new string[cant];
            dias = new int[cant];
            fecha = new DateTime[cant];
        }
        public void Agregar(string nom, string ident, int dia, DateTime fec)
        {
            if (i < cantidad)
            {
                this.nombres[i] = nom;
                this.identificacion[i] = ident;
                this.dias[i] = dia;
                this.fecha[i] = fec;
                i++;
            }
        }
        public void shell()
        {
            string auxinombre, auxiidentificacion;
            int auxidia;
            DateTime auxifecha;
            int intervalo, k, j;
            intervalo = cantidad / 2;
            while (intervalo > 0)
            {
                for(int i= intervalo; i < cantidad; i++)
                {
                    j = i - intervalo;
                    while (j >= 0)
                    {
                        k = j + intervalo;
                        if (fecha[j].CompareTo(fecha[k]) <= 0)
                        {
                            j =- 1;
                        }
                        else
                        {
                            auxinombre = nombres[j];
                            nombres[j] = nombres[k];
                            nombres[k] = auxinombre;

                            auxiidentificacion = identificacion[j];
                            identificacion[j] = identificacion[k];
                            identificacion[k] = auxiidentificacion;

                            auxidia = dias[j];
                            dias[j] = dias[k];
                            dias[k] = auxidia;

                            auxifecha = fecha[j];
                            fecha[j] = fecha[k];
                            fecha[k] = auxifecha;

                            j -= intervalo;
                        }
                    }
                }
                intervalo = intervalo / 2;
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
