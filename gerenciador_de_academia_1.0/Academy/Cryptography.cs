using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Xml.Serialization;
using System.IO;

namespace Academy
{
    class Cryptography
    {
        private static RSACng Csp = new RSACng(4096);
        private RSAParameters PrivateKey;
        private RSAParameters PublicKey;
        public Cryptography()
        {
            PrivateKey = Csp.ExportParameters(true);
            PublicKey = Csp.ExportParameters(false);
        }
        public string PublicKeyString()
        {
            var S = new StringWriter();
            var X = new XmlSerializer(typeof(RSAParameters));
            X.Serialize(S, PublicKey);
            return S.ToString();
        }
        public string Encrypt(string text)
        {
            Csp = new RSACng();
            Csp.ImportParameters(PublicKey);
            var data = Encoding.Unicode.GetBytes(text);
            var Cypher = Csp.Encrypt(data, RSAEncryptionPadding.OaepSHA512);
            return Convert.ToBase64String(Cypher);
        }
        public string Decrypt(string Cypher)
        {
            var databytes = Convert.FromBase64String(Cypher);
            Csp.ImportParameters(PrivateKey);
            var DecryptedText = Csp.Decrypt(databytes, RSAEncryptionPadding.OaepSHA512);
            return Encoding.Unicode.GetString(DecryptedText);
        }
        public static string GetMD5(string texto)
        {
            MD5 engine = MD5.Create();
            byte[] inputs = Encoding.ASCII.GetBytes(texto);
            byte[] hash = engine.ComputeHash(inputs);
            StringBuilder final = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                final.Append(hash[i].ToString("X2"));
            }
            return final.ToString();
        }
       
    }
}
