using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TalentHubLab1.Helpers
{

    public abstract class RSA
    {
        private static BigInteger PrivateRecluiterKey;
        private static BigInteger PrivateCompanyKey;
        public static BigInteger p, q, n, phi, e;

        public static BigInteger[] GeneratePublicKey()
        {
            p = GetPrimeNumber();
            q = GetPrimeNumber();
            phi = (p - 1) * (q - 1);
            
            //first part of public key
            n = p * q;

            //second part of public key
            e = GetEncryptExp(); //e

            //creation of public keys
            return new BigInteger[2] { n, e };
        }

        

        public static BigInteger GeneratePrivateKey()
        {
            BigInteger d = 2;
            while (true)
            {
                if (((d * e) % phi) == 1)
                    return d;
                d++;
            }
        }
        
        public static BigInteger Encryption(BigInteger m, BigInteger[] publicKey)
        {
            
            return BigInteger.ModPow(m, publicKey[1], publicKey[0]);
 
        }

        public static BigInteger Decryption(BigInteger c, BigInteger priv, BigInteger[] publicKey)
        {
            return BigInteger.ModPow(c, priv, publicKey[0]);
        }

        public static BigInteger gcd(BigInteger a, BigInteger b)
        {
            BigInteger temp;
            while (true)
            {
                temp = a % b;
                if (temp == 0)
                    return b;
                a = b;
                b = temp;
            }
        }
        
        public static BigInteger GetPrimeNumber()
        {
            BigInteger number;
            Random rnd = new Random();
            //byte[] data = new byte[2];
            //rnd.NextBytes(data);
            number = rnd.Next(10, 50);
            bool isPrime = false;
            int a = 0;

            if (number < 0)
                number = number * -1;

            while (!isPrime)
            {
                a = 0;
                for (int i = 2; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        a++;
                    }

                }

                if (a == 1)
                    isPrime = true;
                else
                    number++;
            }

            return number;
        }

        public static BigInteger GetEncryptExp()
        {
            //e and phi need to be co-primes  2 < e < phi
            BigInteger e = 2;
            while (e < phi)
            {
                if (gcd(e, phi) == 1)
                    break;
                else
                    e++;
            }

            return e;
        }
    }
}
