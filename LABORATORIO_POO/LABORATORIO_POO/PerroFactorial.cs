using System;
namespace LABORATORIO_POO
{
    public class PerroFactorial: ICalcular
    {
        //toma el numero y retornara su factorial
        public int Calcular(int numero)
        {
            if (numero != 0)
            {
                for (int i = 1; i <= numero; i++)
                {
                    numero = numero * i;
                }
                return numero;
            }
            else
            {
                return 1;
            }
        }
    }
}
