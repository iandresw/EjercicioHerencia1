using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Operaciones
    {
        public double AreaCuadrado(double num1, double num2) 
        {
            return num1* num2;
        }
        public double AreaCirculo(double radio)
        {
            double pi = 3.1416;
            return pi*radio*radio;
        }
        public double AreaTriangulo(double baseTria, double altura)
        {
            return (baseTria * altura) / 2;
        }
    }
}
