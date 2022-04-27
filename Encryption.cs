using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    internal class Encryption
    {
        public static EncryptionResult Encrypt(int p, int q, string text, Label resultLabel)
        {
            int n = p * q;
            int fiN = FiN(p, q);
            int e = FindE(fiN);

            int d = 0;

            while(d * e % fiN != 1)
            {
                d++;
            }

            Cipher cipher = new Cipher();

            for (int i = 0; i < text.Length; i++)
            {
                BigInteger c = BigInteger.Pow(Convert.ToInt32(text[i]), e);
                c = c % n;

                cipher.AddValue((int)c);
            }

            resultLabel.Text = $"e: {e}, d: {d}, fi(n): {fiN}, n: {n}";

            return new EncryptionResult(cipher, n, d, e);
        }

        public static EncryptionResult DecodeWithoutPrivateKey(Cipher cipher, int n)
        {
            Tuple<int, int> result = FindPAndQ(n);

            int p = result.Item1;
            int q = result.Item2;

            int fiN = FiN(p, q);
            int e = FindE(fiN);

            int d = 0;

            while (d * e % fiN != 1)
            {
                d++;
            }

            return new EncryptionResult(cipher, n, d, e);
            //return new EncryptionResult();
        } 


        public static string Decrypt(EncryptionResult encryption)
        {
            string result = "";

            for (int i = 0; i < encryption.Cipher.Values.Count; i++)
            {
                BigInteger m = BigInteger.Pow(encryption.Cipher.Values[i], encryption.D);
                m = m % encryption.N;

                result += Convert.ToChar((int)(m));
            }

            return result;
        }

        private static Tuple<int, int> FindPAndQ(int n)
        {
            for (int i = 2; i < 1000; i++)
            {
                if (!IsPrime(i))
                    continue;

                for (int j = 2; j < 1000; j++)
                {
                    if (!IsPrime(j))
                        continue;

                    if (i == j)
                        continue;

                    if (i * j == n)
                    {             
                        return new Tuple<int, int>(i, j);
                    }
                }
            }

            return null;
        }

        static bool IsPrime(int n)
        {
            if (n > 1)
            {
                return Enumerable.Range(1, n).Where(x => n % x == 0)
                                 .SequenceEqual(new[] { 1, n });
            }

            return false;
        }

        private static int FiN(int p, int q)
        {
            return (p - 1) * (q - 1);
        }

        private static int FindE(int fiN)
        {
            int result = 2;

            while (result < fiN - 1)
            {
                if (Gcd(result, fiN) == 1)
                {
                    return result;
                }
                else
                {
                    result++;
                }
            }

            throw new Exception("e not found");
            return -1;
        }


        public static int Gcd(int a, int b)
        {
            if (a == 0)
                return b;

            return Gcd(b % a, a);
        }
    }
}
