using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarCipherLibrary
{
   public class CaesarDec:CaesarBase
    {
        public string PlainText { get; set; }
        public CaesarDec(string message, int key)
        {         
            Key = 26 - key;
            PlainText = DoWork(message);
        }
    }
}
