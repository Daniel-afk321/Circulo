using System;
using System.Globalization;

namespace Circulo
{
    class Program
    {

        
        static void Main(string[] args)
        {

            // esta instanciando
            Calculadora calc = new Calculadora();

            //entrada pro usuario
            Console.WriteLine("Entre com o valor do raio: "); 
            //declarando o valor do raio e oque ele vai receber do usuario
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //valores da Circunferencia e do volume
            double circ = calc.Circuferencia(raio);
            double volume = calc.Volume(raio); 

            // resposta para o usuario sobre a Circunferencia,volume e valor de PI
            Console.WriteLine("Circuferência: " + circ.ToString("F2", CultureInfo.InvariantCulture)); 
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
        
    }

    } 




