using System;
using System.Collections.Generic;

namespace Cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários deseja cadastrar? ");
            int qntFunc = int.Parse(Console.ReadLine());

            List<Funcionarios> list = new List<Funcionarios>();

            int cont = 0;
            while(cont < qntFunc)
            {
                Console.WriteLine($"Funcionário #{cont + 1}: ");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário atual: R$ ");
                double salario = double.Parse(Console.ReadLine());
                list.Add(new Funcionarios(id, nome, salario));
                cont += 1;
            }
            Console.Write("Digite a ID do funcionário que terá aumento salarial: ");
            int searchId = int.Parse(Console.ReadLine());

            Funcionarios func = list.Find(x => x.Id == searchId);
            if (func != null)
            {
                Console.Write("Qual o percebtual de aumento? ");
                double percent = double.Parse(Console.ReadLine());
                func.AumentoSalarial(percent);
            }
            else
            {
                Console.WriteLine("Essa ID não foi cadastrada ou não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada de funcionários:");
            foreach (Funcionarios obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
