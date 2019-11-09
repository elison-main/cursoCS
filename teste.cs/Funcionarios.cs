using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro
{
    class Funcionarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionarios(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }
        public void AumentoSalarial(double percent)
        {
            Salario += Salario * percent / 100.0;
        }

        public override string ToString()
        {
            return Id
                + " - "
                + Nome
                + ", salário atual = R$ "
                + Salario.ToString("F2");
        }
    }
}
