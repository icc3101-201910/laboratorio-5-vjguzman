using System;

namespace LABORATORIO_POO
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * BONUS: no pude hacer que el numero se guardara :(           
           while (true)
           {
               Calculadora calculadora = new Calculadora(0);

               PersonaQueSuma5 c_1 = new PersonaQueSuma5();
               calculadora.calculadoras.Add(c_1);
               Cubo c_2 = new Cubo();
               calculadora.calculadoras.Add(c_2);
               Cuadrado c_3 = new Cuadrado();
               calculadora.calculadoras.Add(c_3);
               RobotFibonacci c_4 = new RobotFibonacci();
               calculadora.calculadoras.Add(c_4);
               PerroFactorial c_5 = new PerroFactorial();
               calculadora.calculadoras.Add(c_5);


               Console.WriteLine("¿Qué tipo de calculo quiere realizar?");
               Console.WriteLine("[1] Sumar 5");
               Console.WriteLine("[2] Calcular el cuadrado");
               Console.WriteLine("[3] Calcular el cubo");
               Console.WriteLine("[4] Calcular serie de Fibonacci");
               Console.WriteLine("[5] Calcular factorial");
               Console.WriteLine("[0] Salir");


               string seleccion = Console.ReadLine();

               if (seleccion == "0")
               {
                   break;
               }

               if (seleccion == "1")
               {
                   ICalcular cal = calculadora.calculadoras[0];
                   calculadora.Calcular_extra(cal);
                   Console.WriteLine(calculadora.GetNumero());
               }

               if (seleccion == "2")
               {
                   ICalcular cal = calculadora.calculadoras[1];
                   calculadora.Calcular_extra(cal);
                   Console.WriteLine(calculadora.GetNumero());
               }


               if (seleccion == "3")
               {
                   ICalcular cal = calculadora.calculadoras[2];
                   calculadora.Calcular_extra(cal);
                   Console.WriteLine(calculadora.GetNumero());
               }

               if (seleccion == "4")
               {
                   ICalcular cal = calculadora.calculadoras[3];
                   calculadora.Calcular_extra(cal);
                   Console.WriteLine(calculadora.GetNumero());
               }

               if (seleccion == "5")
               {
                   ICalcular cal = calculadora.calculadoras[4];
                   calculadora.Calcular_extra(cal);
                   Console.WriteLine(calculadora.GetNumero());
               }
               }
               */


            Calculadora calculadora = new Calculadora(0);
            PersonaQueSuma5 c_1 = new PersonaQueSuma5();
            calculadora.calculadoras.Add(c_1);
            Cubo c_2 = new Cubo();
            calculadora.calculadoras.Add(c_2);
            Cuadrado c_3 = new Cuadrado();
            calculadora.calculadoras.Add(c_3);
            RobotFibonacci c_4 = new RobotFibonacci();
            calculadora.calculadoras.Add(c_4);
            PerroFactorial c_5 = new PerroFactorial();
            calculadora.calculadoras.Add(c_5);

            Console.WriteLine("Ingrese el numero de calculos a realizar: ");
            int operaciones = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i < operaciones; i++)
            {
                calculadora.Calcular();
                Console.WriteLine(calculadora.GetNumero());
            }
        }
    }
    }

