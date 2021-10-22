using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Algorithms.Core.CaesarCipher
{
    public class MainLogic
    {
        public static string CaesarCipher(string pathIn)
        {
            var text = File.ReadAllText(pathIn);

            return text;
        }
    }
}
