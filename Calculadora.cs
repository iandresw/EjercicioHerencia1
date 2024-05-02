using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class Calculadora : Operaciones
    {
        public double radio { get; set; }   
        public double altura { get; set; }  
        public double baseTria {  get; set; }
        public double baseCuadrado { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"El Areas del Cuadrado es: {AreaCuadrado(altura, baseCuadrado)}");
            Console.WriteLine($"El Areas del Circulo es: {AreaCirculo(radio)}");
            Console.WriteLine($"El Areas del Tirangulo es: {AreaTriangulo(altura, baseTria)}");
        }

    }
}
