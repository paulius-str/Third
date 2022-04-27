using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    internal class EncryptionResult
    {
        public Cipher Cipher { get; set; }
        public int N { get; set; }
        public int D { get; set; }
        public int E { get; set; }

        public EncryptionResult(Cipher cipher, int n, int d, int e)
        {
            Cipher = cipher;
            N = n;
            D = d;
            E = e;
        }

        public EncryptionResult()
        {

        }
    }
}
