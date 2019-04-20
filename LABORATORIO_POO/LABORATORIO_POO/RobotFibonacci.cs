using System;
using System.Linq;
using System.Text;

namespace LABORATORIO_POO
{
    public class RobotFibonacci: ICalcular
    {
        int a = 0;
        int b = 1;
        int aux;

        //toma el numero y devuelve su fibonacci
        public int Calcular(int numero)
        {
            if (numero == 0)
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < numero; i++)
                {
                    aux = a;
                    a = b;
                    b = aux + a;
                }
                return a;
            }

        }
    }
}
