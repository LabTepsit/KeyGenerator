using System;
using CaesarCipherLibrary;

namespace CesarCodeApp
{
    class Program
    {
        static void Main(string[] args)
        {
			Caesar message = new Caesar("NetGeneration", 3);
			message.Encipher();
			Console.WriteLine(message.CipherMessage);
			message.Decipher();
			Console.WriteLine(message.PlainText);

			CaesarCode m1 = new CaesarCode("Vale Vale", 3);
			Console.WriteLine(m1.CipherText);
			CaesarDec p1 = new CaesarDec("Ydoh Ydoh", 3);
			Console.WriteLine(p1.PlainText);
        }      
    }
}

