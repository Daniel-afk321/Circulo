using System;
using System.Globalization;

namespace Circulo
{
    class Program
    {
        // valor fixo do Pi
        static double Pi= 3.14;
        static void Main(string[] args)
        {
            //entrada pro usuario
            Console.WriteLine("Entre com o valor do raio: "); 
            //declarando o valor do raio e oque ele vai receber do usuario
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //valores da Circunferencia e do volume
            double circ = Circuferencia(raio);
            double volume = Volume(raio); 

            // resposta para o usuario sobre a Circunferencia,volume e valor de PI
            Console.WriteLine("Circuferência: " + circ.ToString("F2", CultureInfo.InvariantCulture)); 
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
        // calculo da Circunferencia
        static double Circuferencia(double r) {
            return 2.0 * Pi * r; 
        }
        // calculo do Volume
        static double Volume(double r) {
            
           return 4.0 / 3.0 * Pi * r * r * r;
        }
    }

    } 




