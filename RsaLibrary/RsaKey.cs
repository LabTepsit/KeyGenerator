using System;

namespace RsaLibrary
{
    public class RsaKey
    {
        public int E { get; private set; }
        public int D { get; private set; }
        public int N { get; private set; }

        private int phi;
        public RsaKey(int p, int q)
        {
            N = p * q;
            phi = (p - 1) * (q - 1);
            CreatePublicKey();
            CreatePrivateKey();
        }
        private void CreatePublicKey()
        {
            int resto;
            Random random = new Random();
            do
            {
                E = random.Next(2, phi - 1);
                resto = CalcoloMCD(phi, E);
            } while (resto != 1);
        }
        private int CalcoloMCD(int a, int b)
        {
            int resto = 0;
            while (b != 0)
            {
                resto = a % b;
                a = b;
                b = resto;
            }
            return a;
        }
        private void CreatePrivateKey()
        {
            int k = 0;
            do
            {
                k += 1;
                D = (k * phi + 1) / E;
            } while ((D * E) != k * phi + 1);
        }
    }
}
