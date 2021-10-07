using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DixonCruzBlandon
{
    class Quicksort
    {
        public int cantidad, i = 0;
        public string[] nombres;
        public string[] identificacion;
        public int[] dias;
        public DateTime[] fecha;

        public Quicksort ( int can)
        {
            this.cantidad = can;
            nombres = new string[can];
            identificacion = new string[can];
            dias = new int[can];
            fecha = new DateTime[can];
        }

        public void Agregar(string nom, string iden, int dia, DateTime fe)
        {
            if (i < cantidad)
            {
                this.nombres[i] = nom;
                this.identificacion[i] = iden;
                this.dias[i] = dia;
                this.fecha[i] = fe;
                i++;
            }
        }
        public void quicksort()
        {
            rapidoRecursivo();

            void rapidoRecursivo()
            {
                int i = 0, f = cantidad - 1;
                reduceRecursivo(i, f);
            }
            void reduceRecursivo(int ini, int fin)
            {
                int izq, der, pos;
                string auxinombre, auxiidentificacion;
                int auxidias;
                DateTime auxifecha;
                bool band = true;

                izq = ini;
                der = fin;
                pos = ini;
                while (band == true)
                {
                    band = false;
                    while(nombres[pos].CompareTo(nombres[der])<=0 && pos != der)
                    {
                        der--;
                    }
                    if (pos != der)
                    {
                        auxinombre = nombres[pos];
                        nombres[pos] = nombres[der];
                        nombres[der] = auxinombre;

                        auxiidentificacion = identificacion[pos];
                        identificacion[pos] = identificacion[der];
                        identificacion[der] = auxiidentificacion;

                        auxidias = dias[pos];
                        dias[pos] = dias[der];
                        dias[der] = auxidias;

                        auxifecha = fecha[pos];
                        fecha[pos] = fecha[der];
                        fecha[der] = auxifecha;

                        pos = der;

                        while(nombres[pos].CompareTo(nombres[izq])>=0 && pos != izq)
                        {
                            izq++;
                        }
                        if(pos!= izq)
                        {
                            band = true;

                            auxinombre = nombres[pos];
                            nombres[pos] = nombres[izq];
                            nombres[izq] = auxinombre;

                            auxiidentificacion = identificacion[pos];
                            identificacion[pos] = identificacion[izq];
                            identificacion[izq] = auxiidentificacion;

                            auxidias = dias[pos];
                            dias[pos] = dias[izq];
                            dias[izq] = auxidias;

                            auxifecha = fecha[pos];
                            fecha[pos] = fecha[izq];
                            fecha[izq] = auxifecha;

                            pos = izq;
                        }
                    }
                }
                if ((pos - 1) > ini)
                {
                    reduceRecursivo(ini, pos - 1);
                }
                if (fin > (pos + 1))
                {
                    reduceRecursivo(pos + 1, fin);
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
