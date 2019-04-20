using System;
namespace LABORATORIO_POO
{
    public class Cubo: ICalcular
    {
        //toma el numero y lo devuelve elevado a 3
        public int Calcular(int numero)
        {
            return (int)Math.Pow(numero, 3);
        }
    }
}
