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
        private static double k, rango, ancho, varianza, desviacion;
        private static List<double> Li = new List<double>();
        private static List<double> Ls = new List<double>();
        private static List<double> f = new List<double>();
        private static List<double> Fa = new List<double>();
        private static List<double> Fr = new List<double>();
        //x = marca de clase
        private static List<double> x = new List<double>();
        private static List<double> xf = new List<double>();
        private static List<double> xmediaCuad = new List<double>();
        private static List<double> xmediaCuadF = new List<double>();
        private static double media, mediana, moda;
        private static int mayor, medio;
        private static bool bandera = true;
        public static double CalcularClases(int n)
        {
            k = 1 + (3.322 * Math.Log10(n));
            var x = Math.Truncate(k);
            if (x % 2 == 0)
            {
                x++;
            }
            k = x;
            return k;
        }
        public static double CalcularRango(double vMax, double vMin)
        {
            rango = vMax - vMin;
            return rango;
        }
        public static double CalcularAncho(double Rango, double K)
        {
            ancho = Rango / K;
            return ancho;
        }
        public static void CalcularDatos(List<double> datos, double resta = 0)
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
                if (i == k - 1)
                {
                    seleccion = from dato in datos
                                where dato >= Li[i] && dato <= Ls[i]
                                select dato;
                }
                else
                {
                    seleccion = from dato in datos
                                where dato >= Li[i] && dato < Ls[i]
                                select dato;
                }
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
                }
            }
            media = xf.Sum() / datos.Count;
            moda = Li[mayor] + ((f[mayor] - f[mayor - 1]) / ((f[mayor] - f[mayor - 1]) + (f[mayor] - f[mayor + 1])) * ancho);
            mediana = Li[medio] + ((((datos.Count / 2) - Fa[medio - 1]) / (f[medio])) * ancho);
            for (int i = 0; i < k; i++)
            {
                var y = Math.Pow((x[i] - media), 2);
                xmediaCuad.Add(y);
                var z = y * f[i];
                xmediaCuadF.Add(z);
            }
            varianza = xmediaCuadF.Sum()/(datos.Count-resta);
            desviacion = Math.Sqrt(varianza);
        }
    }
}
