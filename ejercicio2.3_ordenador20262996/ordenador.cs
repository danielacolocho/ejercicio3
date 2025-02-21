using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2._3_ordenador20262996
{
    internal class ordenador
    {
        public string Marca { get; set; }
        public string Procesador { get; set; }
        public int Memoria { get; set; }
        public int DiscoDuro { get; set; }

        public ordenador(string marca, string procesador, int memoria, int discoDuro)
        {
            Marca = marca;
            Procesador = procesador;
            Memoria = memoria;
            DiscoDuro = discoDuro;
        }

        public void MayorCapacidad()
        {
            DiscoDuro += 100;
            Console.WriteLine("Capacidad del disco duro: " + DiscoDuro + " GB");
        }

        public void MenorCapacidad()
        {
            DiscoDuro = Math.Max(DiscoDuro - 100, 0);
            Console.WriteLine("Capacidad del disco duro: " + DiscoDuro + " GB");
        }

    }
}
