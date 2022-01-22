using System;
using HEPAPOO.Models;

namespace HEPAPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculadora c = new Calculadora();
            System.Console.WriteLine("Resultado da soma 1 é: " + c.Somar(10, 10));
            System.Console.WriteLine("Resultado da soma 2 é: " + c.Somar(10, 10, 20));
            // Aluno p1 = new Aluno();
            // p1.Nome = "Rafael";
            // p1.Idade = 20;
            // p1.Nota = 10;

            // p1.Apresentação();

            // Professor p2 = new Professor();    
            // p2.Nome = "Rafael";
            // p2.Idade = 20;
            // p2.Salario = 10000;

            // p2.Apresentação();

            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30, 30);

            // System.Console.WriteLine($"Area é: {r.ObterArea()}");

            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Rafael";
            // p1.Idade = 20;

            // p1.Apresentação();
        }
    }
}
