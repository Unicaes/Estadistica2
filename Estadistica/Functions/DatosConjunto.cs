using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estadistica.Functions
{
    public class DatosConjunto
    {
        private static DatosConjunto current;
        public static DatosConjunto Instance
        {
            get
            {
                if (current == null)
                {
                    current = new DatosConjunto();
                }
                return current;
            }
        }
        public double k, rango, ancho, varianza, desviacion,q1,q3;
        public List<double> Li = new List<double>();
        public List<double> Ls = new List<double>();
        public List<double> f = new List<double>();
        public List<double> Fa = new List<double>();
        public List<double> Fr = new List<double>();
        //x = marca de clase
        public List<double> x = new List<double>();
        public List<double> xf = new List<double>();
        public List<double> xmediaCuad = new List<double>();
        public List<double> xmediaCuadF = new List<double>();
        public double media, mediana, moda;
        private int mayor, medio;
        private bool bandera = true;
        public void CalcularClases(int n)
        {
            k = 1 + (3.322 * Math.Log10(n));
            var x = Math.Truncate(k);
            if (x % 2 == 0)
            {
                x++;
            }
            k = x;
        }
        public void CalcularRango(double vMax, double vMin)
        {
            rango = vMax - vMin;
        }
        public void CalcularAncho()
        {
            ancho = rango / k;
            ancho = Math.Ceiling(ancho);
        }
        public void CalcularCuartiles(List<double> datos)
        {
            datos.Sort();
            double pos = 0.25 * (datos.Count+1);
            double pos2 = 0.75 * (datos.Count+1);
            if (pos % 1 != 0)
            {
                var entero = (int)Math.Floor(pos);
                var decimala = 1-(Math.Ceiling(pos)-pos);
                var valor=datos[entero - 1];
                var decimas = decimala * (datos[entero] - datos[entero - 1]);
                q1 = valor + decimas;
            }
            else
            {
                q1 = datos[(int)(pos - 1)];
            }
            if (pos2%1!=0)
            {
                var entero = (int)Math.Floor(pos2);
                var decimala = 1 - (Math.Ceiling(pos2) - pos2);
                var valor = datos[entero - 1];
                var decimas = decimala * (datos[entero] - datos[entero - 1]);
                q3 = valor + decimas;
            }
            else
            {
                q3 = datos[(int)(pos - 1)];
            }
        }
        public void CalcularDatos(List<double> datos, double resta = 0)
        {
            var min = datos.Min();
            var max = datos.Max();
            IEnumerable<double> seleccion;
            for (int i = 0; i < k; i++)
            {
                Li.Add(min + (ancho * i));
                Ls.Add(min + (ancho * i) + ancho);
                x.Add((Li[i] + Ls[i]) / 2);
            }
            for (int i = 0; i < k; i++)
            {
                //if (i == k - 1)
                //{
                //    seleccion = from dato in datos
                //                where dato >= Li[i] && dato <= Ls[i]
                //                select dato;
                //}
                //else
                //{
                    seleccion = from dato in datos
                                where dato >= Li[i] && dato < Ls[i]
                                select dato;
                //}
                f.Add(seleccion.Count());
                xf.Add(x[i] * f[i]);
                Fr.Add(f[i] / datos.Count);
                if (i == 0)
                {
                    Fa.Add(f[i]);
                    mayor = i;
                }
                else
                {
                    Fa.Add(f[i] + Fa[i - 1]);
                    if (seleccion.Count() > f[mayor])
                    {
                        mayor = i;
                    }
                }
                if (bandera && Fa[i] >= (datos.Count / 2))
                {
                    medio = i;
                    bandera = false;
                }
            }
            media = xf.Sum() / datos.Count;
            if (mayor == 0)
            {
                moda = Li[mayor] + ((f[mayor] - 0) / ((f[mayor] - 0) + (f[mayor] - f[mayor + 1])) * ancho);
            }
            else if (mayor == k)
            {
                moda = Li[mayor] + ((f[mayor] - f[mayor - 1]) / ((f[mayor] - f[mayor - 1]) + (f[mayor] - 0)) * ancho);
            }
            else
            {
                moda = Li[mayor] + ((f[mayor] - f[mayor - 1]) / ((f[mayor] - f[mayor - 1]) + (f[mayor] - f[mayor + 1])) * ancho);
            }
            mediana = Li[medio] + ((((datos.Count / 2) - Fa[medio - 1]) / (f[medio])) * ancho);
            if (Configuracion.muestra)
            {
                resta = 1;
            }
            else
            {
                resta = 0;
            }
            for (int i = 0; i < k; i++)
            {
                var y = Math.Pow((x[i] - media), 2);
                xmediaCuad.Add(y);
                var z = y * f[i];
                xmediaCuadF.Add(z);
            }
            varianza = xmediaCuadF.Sum() / (datos.Count - resta);
            desviacion = Math.Sqrt(varianza);
        }
        public void Limpiar()
        {
            current = new DatosConjunto();
        }
    }
}
