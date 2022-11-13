using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace TalentHub.Algorithm.RSA
{
    public abstract class Signature
    {
       
        public static void VerifySignature(Company company)
        {
            BigInteger decryptedSignature = BigInteger.ModPow(company.signature,company.PublicKey[1], company.PublicKey[0]);
            var hash = decryptedSignature.ToByteArray();
            
            if (hash == company.Hash)
            {
                MessageBox.Show("Firma de la empresa correctamente verificada, proceso finalizado");
            }
            else
            {
                MessageBox.Show("Error en la verificación de la identidad de la empresa");
            }
        }
    }
}
