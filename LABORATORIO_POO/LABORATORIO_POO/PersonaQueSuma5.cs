using System;
namespace LABORATORIO_POO
{
    public class PersonaQueSuma5: ICalcular
    {
        //toma el numero y retorna su suma con 5
        public int Calcular(int numero)
        {
            return numero + 5;
        }
    }
}
