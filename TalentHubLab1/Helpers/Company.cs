using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace TalentHubLab1.Helpers
{
    public class Company
    {
        public string Name { get; set; }
        public BigInteger[] PublicKey;
        public BigInteger PrivateKey;
        public BigInteger p, q, n, phi, e;

        public Company(string name)
        {
            Name = name;
            PublicKey = GeneratePublicKey();
            PrivateKey = GeneratePrivateKey();
        }


        public BigInteger[] GeneratePublicKey()
        {
            p = GetPrimeNumber();
            System.Threading.Thread.Sleep(10);
            q = GetPrimeNumber();
            phi = (p - 1) * (q - 1);

            //first part of public key
            n = p * q;

            //second part of public key
            e = GetEncryptExp(); //e

            //creation of public keys
            return new BigInteger[2] { n, e };
        }
        public BigInteger GeneratePrivateKey()
        {
            //BigInteger d = (1 / PublicKey[1]) % phi ;
            //   return d;

            BigInteger d = 2;
           
            while (true)
            {
                if (((d * e) % phi) == 1)
                    return d;
                d++;
            }
            return d;
        }

        public BigInteger gcd(BigInteger a, BigInteger b)
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
            number = rnd.Next(10, 900);
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

        public BigInteger GetEncryptExp()
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
