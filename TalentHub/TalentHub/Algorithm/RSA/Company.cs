using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Security.Cryptography;


namespace TalentHub.Algorithm.RSA
{
    public class Company
    {
        public string Name;
        private SHA256 alg = SHA256.Create(); // Hash
        public byte[] Hash;
        public BigInteger signature;
        public BigInteger[] PublicKey;
        private BigInteger PrivateKey;
        public BigInteger p, q, n, phi, e;
        //public BigInteger


        public Company(string name)
        {
            Name = name;
            p = GetPrimeNumber();
            System.Threading.Thread.Sleep(10);
            q = GetPrimeNumber();
            n = p * q;
            phi = (p - 1) * (q - 1);
            
            
            PublicKey = GeneratePublicKey();
            PrivateKey = GeneratePrivateKey();
            signature = GenerateSignature();
        }

        

        private BigInteger GenerateSignature()
        {
            byte[] data = Encoding.UTF8.GetBytes(Name);
            Hash = alg.ComputeHash(data);
            
            string a = "";
            for (int i = 0; i < Hash.Length; i++)
            {
                a += Hash[i];
            }

            BigInteger hashAux = BigInteger.Parse(a);

            return BigInteger.ModPow(hashAux, PrivateKey, PublicKey[0]);
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

            BigInteger d = 2;

            while (true)
            {
                if (((d * e) % phi) == 1)
                    return d;
                d++;
            }
            return d;
        }

        public static BigInteger GetPrimeNumber()
        {
            BigInteger number;
            Random rnd = new Random();
            number = rnd.Next(100, 9000);
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

        /*
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
        }*/

        public BigInteger GetEncryptExp()
        {
            //e and phi need to be co-primes  2 < e < phi
            BigInteger e = phi;
            while (e > 0)
            {
                if (gcd(e, phi) == 1)
                    break;
                else
                    e--;
            }

            return e;
        }
    }
}


/*
 public BigInteger[] PublicKey;
        private BigInteger PrivateKey;
        private int[] firstPrimesList = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29,
                                         31, 37, 41, 43, 47, 53, 59, 61, 67,
                                         71, 73, 79, 83, 89, 97, 101, 103,
                                         107, 109, 113, 127, 131, 137, 139,
                                         149, 151, 157, 163, 167, 173, 179,
                                         181, 191, 193, 197, 199, 211, 223,
                                         227, 229, 233, 239, 241, 251, 257,
                                         263, 269, 271, 277, 281, 283, 293,
                                         307, 311, 313, 317, 331, 337, 347, 349};


        public Company()
        {
            PublicKey = new BigInteger[2];
            GenerateKeys();
        }

        private void GenerateKeys()
        {
            BigInteger p;
            BigInteger q;
            
            do
            {
                p = GetPrimeNumber(GetLowLevelPrime());
                //System.Threading.Thread.Sleep(100);
                q = GetPrimeNumber(GetLowLevelPrime());
            }
            while (p == 0 && q == 0);

            
             
            int hola = 2;
        }

        private BigInteger RandomNumber()
        {
            Random rand = new Random();

            //BigInteger max = BigInteger.Pow(2, 1024) - 1;
            //BigInteger min = BigInteger.Pow(2, 1023) + 1;
            byte[] data = new byte[1]; 
            rand.NextBytes(data);
            return new BigInteger(data);
        }

        private BigInteger GetLowLevelPrime()
        {
            //Generates a prime candidate
            //low level primality test
            while (true)
            {
                BigInteger primeCandidate = RandomNumber();
                //divide prime candidate by the first prime numbers
                foreach (int divisor in firstPrimesList)
                {
                    if (primeCandidate % divisor == 0 && divisor * divisor <= primeCandidate)
                        break;
                    //if no divisor is found, return value
                    else
                        return primeCandidate;
                }
            }
        }

        private BigInteger GetPrimeNumber(BigInteger primeCandidate)
        {
            //Primality test - Miller Rabin
            if (primeCandidate < 0)
                primeCandidate = primeCandidate * -1;

            BigInteger k = 0;
            while ((primeCandidate - 1) % (BigInteger)(Math.Pow(2, (double)k+1)) == 0)
            {
                k++;
            }

            

            BigInteger m = primeCandidate/((BigInteger)Math.Pow(2,(double)k));

            BigInteger a = 2;

            BigInteger x = BigInteger.ModPow(a, m, primeCandidate);

            if (x == 1 || x == -1)
                return primeCandidate;
            else
            {
                int r = 0;
                while(x != 1 && x != -1 && r <= (k-2))
                {
                    x = BigInteger.ModPow(x, 2, primeCandidate);
                }

                if (x == -1)
                    return primeCandidate;
                
                return 0;
                
                    
            }
        }
 
 
 
 */