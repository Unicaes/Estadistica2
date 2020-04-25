using Bunifu.Framework.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estadistica.Functions
{
    public static class DatosSimples
    {
        private static double mediana, moda, media,varianza,desviacion;
        public static List<double> datosCuad = new List<double>();
        public static Dictionary<double, int> conteo = new Dictionary<double, int>();
        public static void CalcularMediana(List<Double> datos)
        {
            datos.Sort();
            if (datos.Count % 2 == 0)
            {
                // Si es par la cantidad de datos, al dividirlo entre 2 obtenemos un entero, por lo que 
                // tomamos esa pocision y la sumamos a la siguiente
                // Luego dividimos entre 2 para obtener la mediana
                mediana = (datos[(datos.Count / 2) - 1] + datos[datos.Count / 2]) / 2;
            }
            else
            {
                // Si es impar, obtenemos el entero menor EJ: 11/2 = 5.5 , con Floor obtenemos 5
                // luego solo obtenemos el valor en esa posicion
                int PuntoMedio = (int)Math.Floor((decimal)datos.Count / 2);
                mediana = datos[PuntoMedio];
            }
        }
        public static void CalcularModa(List<double> datos)
        {
            
            for (int i = 0; i < datos.Count; i++)
            {
                if (conteo.ContainsKey(datos[i]))
                {
                    conteo[datos[i]] += 1;
                }
                else
                {
                    conteo.Add(datos[i], 1);
                }
            }
            int cantidad = 0;
            foreach (KeyValuePair<double, int> item in conteo)
            {
                if (item.Value > cantidad)
                {
                    moda = item.Key;
                    cantidad = item.Value;
                }
            }
        }
        public static void CalcularMedia(List<double> datos)
        {
            double suma = 0;
            for (int i = 0; i < datos.Count; i++)
            {
                suma += datos[i];
            }
            media = suma / datos.Count;
        }
        public static void CalcularVarianza(List<double> datos)
        {
            int resta;
            if (Configuracion.muestra)
            {
                resta = 1;
            }
            else
            {
                resta = 0;
            }
            foreach (var item in datos)
            {
                var x = Math.Pow((item - media),2);
                datosCuad.Add(x);
            }
            varianza = datosCuad.Sum();
            varianza = varianza / (datos.Count-resta);
            desviacion = Math.Sqrt(varianza);
        }
        public static void CalcularDatos(List<double> datos)
        {
            CalcularMediana(datos);
            CalcularMedia(datos);
            CalcularModa(datos);
            CalcularVarianza(datos);
        }
    }
}
