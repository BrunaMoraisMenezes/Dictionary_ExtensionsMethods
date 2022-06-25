using System;
using System.Collections.Generic;

namespace Dictionary_ExtensionsMethods
{
    public interface IArquivo
    {
        List<Funcionario> ListaFuncionarios();
        Dictionary<int, string> ListaPrimeiroDictionary();
        Dictionary<int, string> ListaSegundoDictionary();
        Dictionary<int, string> ListaTerceiroDictionary();
    }
}
