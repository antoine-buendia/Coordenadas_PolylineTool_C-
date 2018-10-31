using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisCoordenadas
{
    public class Coordenadas
    {
        public double Latitud { get; set; }
        public double Longitud { get; set; }
    }
    public class Program
    {       
        static void Main(string[] args)
        {
            bool Continuar = true;
            Console.WriteLine("Hola, ingresa coordenadas (latitud, longitud) o x para salir:");
            Console.WriteLine("Ejemplo, -12.3444,14.2333 ");

            List<Coordenadas> coordenadas = new List<Coordenadas>();
            string NuevaCoordenada = "";
            while (Continuar)
            {
                string input = Console.ReadLine();
                if (input.ToLower().Equals("x"))
                {
                    Continuar = false;
                    continue;
                }
                if (input.Split(',').Length !=2)
                {
                    continue;
                }
                Double latitud;
                Double Longitud;
                Coordenadas MiCoordenada = new Coordenadas()
                {
                    Latitud = Double.TryParse(input.Split(',')[0], out latitud) ? latitud : 0,
                    Longitud = Double.TryParse(input.Split(',')[1], out Longitud) ? Longitud :0, 
                };
                coordenadas.Add(MiCoordenada);
            }
            foreach (Coordenadas Elemento in coordenadas)
            {
                NuevaCoordenada = NuevaCoordenada + Elemento.Latitud.ToString().Trim() + "%2C%20" + Elemento.Longitud.ToString().Trim() + "%0A";                 
            }
            
            System.Diagnostics.Process.Start("www.keene.edu/campus/maps/tool/?coordinates=" + NuevaCoordenada);
            Console.WriteLine("Has ingresado:{0} coordenadas, Adios!...", coordenadas.Count);
            }
    }
}
