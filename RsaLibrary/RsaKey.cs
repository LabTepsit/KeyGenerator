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
            int mcd;
            Random random = new Random();
            do
            {
                E = random.Next(2, phi - 1);
                mcd = FindMCD(phi, E);
            } while (mcd != 1);
        }
        private int FindMCD(int a, int b)
        {
            int r = 0;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
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
            } while ((D * E) != k * phi + 1 /*|| D==E*/);
        }
    }
}
