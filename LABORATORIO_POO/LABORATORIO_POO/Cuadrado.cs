using System;
namespace LABORATORIO_POO
{
    public class Cuadrado:ICalcular
    {
        //toma el numero y lo devuelve elevado a 2
        public int Calcular(int numero)
        {
            return (int)Math.Pow(numero, 2);
        }
    }
}
