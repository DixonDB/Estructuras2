using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DixonCruzBlandon
{
    class InsercionDirecta_Baraja
    {
        public int cant, i = 0;
        public string[] nombres;
        public string[] identificacion;
        public int[] dias;
        public DateTime[] fecha;

        public InsercionDirecta_Baraja(int Cant)
        {
            this.cant = Cant;
            nombres = new string[Cant];
            identificacion = new string[Cant];
            dias = new int[Cant];
            fecha = new DateTime[Cant];
        }
        public void Agregar(string Nomb, string Ident, int DiasE, DateTime fechaR)
        {
            if (i < cant)
            {
                this.nombres[i] = Nomb;
                this.identificacion[i] = Ident;
                this.dias[i] = DiasE;
                this.fecha[i] = fechaR;
                i++;
            }
        }
        public void Insercion()
        {
            for(int i = 0; i < cant; i++)
            {
                string nomb = nombres[i];
                string ident = identificacion[i];
                int di = dias[i];
                DateTime feh = fecha[i];

                int j = i - 1;
                while((j >= 0) && nombres[j].CompareTo(nombres[i]) > 0)
                {
                    nombres[j + 1] = nombres[j];
                    identificacion[j + 1] = identificacion[j];
                    dias[j + 1] = dias[j];
                    fecha[j + 1] = fecha[j];
                    j--;
                }
                nombres[j + 1] = nomb;
                identificacion[j + 1] = ident;
                dias[j + 1] = di;
                fecha[j + 1] = feh;
            }
        }
        public void Mostrar(DataGridView dgvclientes)
        {
            dgvclientes.Rows.Clear();
            for(int i=0; i < cant; i++)
            {
                dgvclientes.Rows.Add(nombres[i], identificacion[i], dias[i], fecha[i]);
            }
        }
    }
}
