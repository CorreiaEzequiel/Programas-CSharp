using System;

namespace PrimeiroProjeto // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o salario base :");
            double salarioFunc = double.Parse(Console.ReadLine());
            double ajusteSal = 0.0;

            if (salarioFunc <= 2000)
            {
                ajusteSal = salarioFunc * 0.1;
            }
            else if (salarioFunc > 2000 && salarioFunc <= 5200)
            {
                ajusteSal = salarioFunc * 0.08;
            }
            else if (salarioFunc > 5200 &&  salarioFunc <= 10000){
                ajusteSal = salarioFunc * 0.05;
            }else
            {  
                Console.WriteLine("Esse valor não sofre alteração, pois se trata de um serviço PJ");
            }
            double salarioAjustado = salarioFunc + ajusteSal;
            Console.WriteLine($"O salario informado após o ajuste será de : {salarioAjustado}");
        }
    }
}