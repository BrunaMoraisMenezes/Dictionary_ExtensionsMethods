using System;
using System.IO;
using System.Collections.Generic;

namespace Dictionary_ExtensionsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o endereco do arquivo: ");
            string endereco = Console.ReadLine();

            Arquivo arquivo = new Arquivo(endereco);

            try
            {
                arquivo.ListaFuncionarios();
                arquivo.ListaPrimeiroDictionary();
                arquivo.ListaSegundoDictionary();
                arquivo.ListaTerceiroDictionary();
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Endereco Inválido");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Ocorreu um erro {exception.Message}");
            }
        }
    }
}
