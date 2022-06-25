using System;

namespace Dictionary_ExtensionsMethods
{
    public static class Extension
    {
        public static string Extenso(this DateTime dataNascimento)
        {
            return $"{dataNascimento.ToString("MMMM")}";
        }
    }
}
