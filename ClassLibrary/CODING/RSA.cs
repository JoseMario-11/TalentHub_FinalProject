using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CODING
{
    public class RSA
    {
        //Método para cifrar un mensaje mediante las llaves públicas de RSA
        public static int Cipher(int M, int k, int n)
        {
            return Convert.ToInt32(Convert.ToInt64(Math.Pow(M, k)) % n);
        }

        //Método para descifrar mediante una llave pública y otra privada
        public static int Descipher(int C, int j, int n)
        {
            return Convert.ToInt32(Math.Pow(C, j)) % n;
        }

        // Método para la generación de llaves públicas y privada
        // Devuelve un arreglo con las llaves { n, k, j }
        public static int[] getKeys()
        {
            
            int n, p, q, z, k, j;
            Random rand = new Random();
            p = rand.Next(7,64);
            while (!PrimeNumber(p))
            {
                p = rand.Next(7, 64);
            }

            q = rand.Next(7, 64);
            while (!PrimeNumber(q))
            {
                q = rand.Next(7, 64);
            }

            n = p * q; //k *j
            z = (p - 1) * (q - 1); // mod

            k = rand.Next(63, 256);
            while (!AreCoprime(k, z))
            {
                k = rand.Next(63, 256);
            }

            //Encontrar el inverso de k módulo z
            j = getPrivateKey(k, z);

            //Las primeras dos llaves son las públicas y la última es la privada
            int[] keys = { n, k, j };

            return keys;
        }

        // Métodos para obtener la llave privada
        static int getPrivateKey(int k, int z)
        {
            for (int i = z - 1; i >= 0; i--)
            {
                if ((k * i) % z == 1)
                {
                    return i;
                }
            }
            return 0;
        }

        //Método para determinar si dos números son coprimos entre sí
        static bool AreCoprime(int a, int b)
        {
            //Intercambio entre "a" y "b" si "b" es mayor que "a"
            if (a < b)
            {
                int aux = a;
                a = b;
                b = aux;
            }

            int r = a % b;

            // Todos par de números a lo que se aplica el módulo terminan siendo como resultado 0, así que si no son
            // primos relativos entonces se el último residuo es 0, de lo contrario el residuo es 1
            while (r != 0)
            {
                a = b;
                b = r;
                r = a % b;

                if (r == 1)
                {
                    return true;
                }
            }
            return false;
        }

        // Método para determinar si un número es primo
        static bool PrimeNumber(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if ((n % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
