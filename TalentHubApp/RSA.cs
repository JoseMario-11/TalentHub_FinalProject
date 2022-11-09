using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace TalentHubApp
{
    public class RSA
    {
        public string generateKeys(int p, int q)
        {
            int n, phi, e, d;

            n = p * q;
            phi = (p - 1) * (q - 1);
            e = generateCoprime(phi);
            d = euclidesExt(e, phi);
            while (d < 0) d += phi;

            return n + "," + e + "," + d;
        }

        int generateCoprime(int phi)
        {
            int e = 2;
            do
            {
                Random random = new Random();
                e = random.Next(2, phi);
            } while (!isCoprime(e, phi));

            return e;
        }

        bool isCoprime(int e, int phi)
        {
            if (mcd(e, phi) == 1)
                return true;
            else
                return false;
        }

        static int mcd(int a, int b)
        {
            // Everything divides 0
            if (a == 0 || b == 0)
                return 0;

            // base case
            if (a == b)
                return a;

            // a is greater
            if (a > b)
                return mcd(a - b, b);

            return mcd(a, b - a);
        }

        int euclidesExt(int e, int phi)
        {
            return (1 / e) % phi;

        }

        public long encryptMessage(long messageASCII, int n, int e)
        {
            long cDouble = (messageASCII^e) % n;
            long c = Convert.ToInt64(cDouble);
            return c;
        }

        public long decryptMessage(int c, int n, int d)
        {
            long m = (c ^ d) % n;
            return m;
        }
    }
}
