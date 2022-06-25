using System;
using System.Collections.Generic;
using System.IO;

namespace Dictionary_ExtensionsMethods
{
    class Arquivo : IArquivo
    {
        public string Endereco { get; set; }
        public List<Funcionario> Funcionarios = new List<Funcionario>();
        public Dictionary<int, string> PrimeiroDictionary = new Dictionary<int, string>();
        public Dictionary<int, string> SegundoDictionary = new Dictionary<int, string>();
        public Dictionary<int, string> TerceiroDictionary = new Dictionary<int, string>();

        public Arquivo(string endereco)
        {
            Endereco = endereco;
            Funcionarios = new List<Funcionario>();
            PrimeiroDictionary = new Dictionary<int, string>();
            SegundoDictionary = new Dictionary<int, string>();
            TerceiroDictionary = new Dictionary<int, string>();
        }

        public List<Funcionario> ListaFuncionarios()
        {
            Console.WriteLine("****************** Dados Funcionário ********************");

            using (StreamReader sr = File.OpenText(Endereco))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    var linhaArquivo = sr.ReadLine().Split(";");
                    Funcionarios.Add(new Funcionario() { Id = int.Parse(linhaArquivo[0]), NomeCompleto = linhaArquivo[1], DataNascimento = DateTime.Parse(linhaArquivo[2]), Salario = Decimal.Parse(linhaArquivo[3]) });
                }
            }
            Console.WriteLine("Id " + " Nome " + " Data de Nascimento " + " Salario ");
            foreach (Funcionario funcionario in Funcionarios)
            {
                Console.WriteLine(funcionario);
            }
            Console.WriteLine("*************************************************************");
            return Funcionarios;
        }

        public Dictionary<int, string> ListaPrimeiroDictionary()
        {
            Console.WriteLine("****************** Dados no Dictionary - ID e Nome ********************");

            using (StreamReader sr = File.OpenText(Endereco))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    var linhaArquivo = sr.ReadLine().Split(";");
                    PrimeiroDictionary[int.Parse(linhaArquivo[0])] = linhaArquivo[1];
                }
            }
            Console.WriteLine("Id " + " Nome ");
            foreach (var item in PrimeiroDictionary)
            {
                Console.WriteLine(item.Key.ToString() + " " + item.Value);
            }
            Console.WriteLine("*************************************************************");
            return PrimeiroDictionary;
        }
        public Dictionary<int, string> ListaSegundoDictionary()
        {
            Console.WriteLine("****************** Dados no Dictionary - ID e Data ********************");

            using (StreamReader sr = File.OpenText(Endereco))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    var linhaArquivo = sr.ReadLine().Split(";");
                    SegundoDictionary[int.Parse(linhaArquivo[0])] = Extension.Extenso(DateTime.Parse(linhaArquivo[2]));
                }
            }

            Console.WriteLine("Id " + "Data de nascimento por extenso ");
            foreach (var item in SegundoDictionary)
            {
                Console.WriteLine(item.Key.ToString() + " " + item.Value);
            }
            Console.WriteLine("*************************************************************");
            return SegundoDictionary;
        }

        public Dictionary<int, string> ListaTerceiroDictionary()
        {
            Console.WriteLine("****************** Dados no Dictionary - ID, Nome e Data ********************");

            using (StreamReader sr = File.OpenText(Endereco))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    var linhaArquivo = sr.ReadLine().Split(";");
                    TerceiroDictionary[int.Parse(linhaArquivo[0])] = linhaArquivo[1] + " Nasceu em " + Extension.Extenso(DateTime.Parse(linhaArquivo[2]));
                }
            }

            Console.WriteLine(" Id " + " Nome " + " Data de nascimento por extenso ");
            foreach (var item in TerceiroDictionary)
            {
                Console.WriteLine(item.Key.ToString() + " " + item.Value);
            }
            Console.WriteLine("*************************************************************");
            return TerceiroDictionary;
        }
    }
}

