using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double massa, altura, imc; 

            Console.Beep();
            Console.Clear();

            Console.Write("Digite seu peso (kg) : ");
            massa = double.Parse(Console.ReadLine()); 

            Console.Write("Digite sua altura (m) : ");
            altura = double.Parse(Console.ReadLine()); 

            imc = massa / Math.Pow(altura, 2); 
            
            if(imc < 17)
            {
                Console.WriteLine($"\nSeu imc é de {imc:N2} kg/m²");
                Console.WriteLine("Diagnóstoco: Muito abaixo do peso");
            }
            else if(imc >= 17 && imc < 18.5)
            {
                Console.WriteLine($"\nSeu imc é de {imc:N2} kg/m²");
                Console.WriteLine("Diagnóstoco: Abaixo do peso");
            }
            else if(imc >= 18.5 && imc < 25)
            {
                Console.WriteLine($"\nSeu imc é de {imc:N2} kg/m²");
                Console.WriteLine("Diagnóstoco: Peso normal");
            }
            else if(imc >= 25 && imc < 30)
            {
                Console.WriteLine($"\nSeu imc é de {imc:N2} kg/m²");
                Console.WriteLine("Diagnóstoco: Acima do peso");
            }
            else if(imc >= 30 && imc < 35)
            {
                Console.WriteLine($"\nSeu imc é de {imc:N2} kg/m²");
                Console.WriteLine("Diagnóstoco: Obesidade I");
            }
            else if(imc >= 35 && imc < 40)
            {
                Console.WriteLine($"\nSeu imc é de {imc:N2} kg/m²");
                Console.WriteLine("Diagnóstoco: Obesidade II (severa)");
            }
            else if(imc >= 40)
            {
                Console.WriteLine($"\nSeu imc é de {imc:N2} kg/m²");
                Console.WriteLine("Diagnóstoco: Obesidade III (mórbida)");
            }

        
        }
    }
}
