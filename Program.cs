using System;
using System.Globalization;
using task05;

namespace Task05{
    class Program{
        static void Main(String[] args){
            Funcionario f = new Funcionario();

            System.Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            System.Console.Write("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());
            System.Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Funcionário: "+f);
            System.Console.Write("Digite a porcentagem para aumentar o salário: ");
            double Porcentagem = double.Parse(Console.ReadLine());
            f.AumentarSalario(Porcentagem);
            System.Console.WriteLine("Dados atualizado: "+f);
        }
    }
}