using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentoClasseP.Model
{
    public class Calculadora
    {
       public void Somar(int x, int y)
        { Console.WriteLine($"{x} + {y} = {x+y}"); }

        public void Subtrair(int x, int y)
        { Console.WriteLine($"{x} - {y} = {x-y}"); }

        public void Multiplicar(int x, int y)
        { Console.WriteLine($"{x} x {y} = {x*y}"); }

        public void Dividir(double x, int y)
        { Console.WriteLine($"{x} / {y} = {x / y}"); }


        //Potenciação 

        public void Potencia(int x, int y)
        {
            double pot =  Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {pot}"); }


        //Funções Trigonométricas

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno, 4)}");
        }

        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo}° = {Math.Round(coseno, 4)}");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}° = {Math.Round(tangente, 4)}");
        }

        //Raíz Quadrada

        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raíz quadrada de {x} = {raiz}");

        }

    }

}