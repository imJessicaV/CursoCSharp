using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Models
{
    public class Calculadora
    {
        public void Somar(int X, int Y){
            Console.WriteLine($"Soma: {X} + {Y} = {X + Y}");
        }

        public void Subtrair(int X, int Y){
            Console.WriteLine($"Subtração: {X} - {Y} = {X - Y}");
        }

        public void Multiplicar(int X, int Y){
            Console.WriteLine($"Multiplicação: {X} x {Y} = {X * Y}");
        }

        public void Dividir(int X, int Y){
            Console.WriteLine($"Divisão: {X} / {Y} = {X / Y}");
        }

        public void Potencia(int X, int Y){
            double Pot = Math.Pow(X, Y);
            Console.WriteLine($"Potencia: {X} ^ {Y} = {Pot}");
        }

        public void Seno(double Angulo){
            double Radiano = Angulo * Math.PI / 180;
            double Seno = Math.Sin(Radiano);
            Console.WriteLine($"O seno de {Angulo}° = {Math.Round(Seno, 4)}");
        }

        public void Coseno(double Angulo){
            double Radiano = Angulo * Math.PI / 180;
            double Coseno = Math.Cos(Radiano);
            Console.WriteLine($"O coseno de {Angulo}° = {Math.Round(Coseno, 4)}");
        }

        public void Tangente(double Angulo){
            double Radiano = Angulo * Math.PI / 180;
            double Tangente = Math.Tan(Radiano);
            Console.WriteLine($"A tangente de {Angulo}° = {Math.Round(Tangente, 4)}");
        }

        public void RaizQuadrada(double X){
            double Raiz = Math.Sqrt(X);
            Console.WriteLine($"A raiz quadrada de {X} é: {Raiz}");
        }
    }
}