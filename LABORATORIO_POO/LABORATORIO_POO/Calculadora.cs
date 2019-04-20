using System;
using System.Collections.Generic;
namespace LABORATORIO_POO
{
    public class Calculadora
    {
        Random rnd = new Random();

        //atributos
        private int numero;
        public List<ICalcular> calculadoras;

        //met para obtener el numero porque es private
        public int GetNumero()
        {
            return numero;
        }

        //met que actualiza el numero utiizando una de las calculadoras al azar
        public void Calcular()
        {
            int indice = rnd.Next(0, 5);
            ICalcular cal = calculadoras[indice];
            numero = cal.Calcular(numero);

        }

        public void Calcular_extra(ICalcular cal)
        {
            numero = cal.Calcular(numero);
        }

        //constructor de la clase calculadora
        public Calculadora(int valor_inicial)
        {
            this.numero = valor_inicial;
            calculadoras = new List<ICalcular>();

        }
    }
}
