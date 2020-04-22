using System;
using System.Numerics;
using RsaLibrary;


namespace AppKeyGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generatore chiavi RSA");

            int p = 5;
            int q = 11;
            RsaKey user = new RsaKey(p, q);        
            int e = user.E;    
            Console.WriteLine($"Chiave pubblica: {e},{user.N}"); 
            int d = user.D;
            Console.WriteLine($"Chiave privata: {d},{user.N}");

            //Console.WriteLine(BigInteger.ModPow(8, 3, 55));
            //Console.WriteLine(BigInteger.ModPow(17, 27, 55));

        }


    }
}
