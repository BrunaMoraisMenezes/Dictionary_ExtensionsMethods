using System;

namespace Dictionary_ExtensionsMethods
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Salario { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(int id, string nomeCompleto, DateTime dataNascimento, decimal salario)
        {
            Id = id;
            NomeCompleto = nomeCompleto;
            DataNascimento = dataNascimento;
            Salario = salario;
        }

        public override string ToString()
        {
            return $"{Id} {NomeCompleto} {DataNascimento:dd/MM/yyyy} {Salario}";
        }
    }
}
