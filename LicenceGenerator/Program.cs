using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Xml;
using System.Xml.Serialization;
using PizzaDelivery;

namespace LicenceGenerator
{
    class Program
    {
        private static void GenerateNewKeyPair()
        {

            string withSecret;

            string woSecret;

            using (var rsaCsp = new RSACryptoServiceProvider())
            {
                withSecret = rsaCsp.ToXmlString(true);
                woSecret = rsaCsp.ToXmlString(false);
            }
            File.WriteAllText("private.xml", withSecret);
            File.WriteAllText("public.xml", woSecret);
        }
        static void Main(string[] args)
        {
            if (args.Any(a => a == "--generate"))
            {
                GenerateNewKeyPair();
            }

            var dto = new PizzaDelivery.Licence()
            {
                ValidUntil = DateTime.Now.AddDays(31)
            };

            var fileName = string.Join("", DateTime.Now.ToString().Where(c => char.IsDigit(c)));
            new LicenceGenerator().CreateLicenseFile(dto, fileName + ".pz_licence");
        }

        class LicenceGenerator
        {
            private static string PrivateKey = @"<RSAKeyValue>
<Modulus>p7GVJs8IIPxVsg4Bg3sH/r5sE0E/UYieTVFqWrH9OrIJulxfSo3BCUYXynlOORxhFKcNKQyn9Rm+drmQEs1ATQ6K+Bcd+7bAWW4GxF7V2A5Chwl5A0HS8uPupSO0dRdYuteFgqwiAxFFip0ejfHOfcnWf9cWYCQNGJaKWcBKSIE=</Modulus>
<Exponent>AQAB</Exponent>
<P>xtieXPpOFq9xFhFjCToHPUneLfgWx2Iy658o7lSbLGz6bgNTaqRfa8UUPfjESh/3OelMgXSJoplPCKXuhHOw+w==</P>
<Q>1+S4ZGZvhMgraw0gxbCQzRl43JgSHyq97D2iXpFyV6yuoS7f4ZqszPsRBP+v/qMwMT81i+G/CNtj3RTGreRLsw==</Q>
<DP>GZ3wkPPiOYPyorAsvRSPuDKa//sVHCyneLlxcXrO3uNPQ/sDtRpl/KFQIUe6Kf6CQCCxLYBQ9vSfPPL7jm7FHw==</DP>
<DQ>ahIWwkVNzzgllOALVPWN/ybfqcoRRTzTuSkDCGF/gzH1Tn3gQ1CiS8eisgkJqBr3R4rdvQ85s5lOtEVL5A3BXw==</DQ>
<InverseQ>jORGaENWSfnaeLsLEQD2LKaM650r0oreUkFS+e3I2uh5F8hgrn93TCDv1ez7PcOFH2tu1obm6NvTR9RtBXdkTg==</InverseQ>
<D>kXsmgnyp+LPxRH+SIJbj4MUizbGVVQ7JBxrSwcwYfItolRz+Lpe8GGeOzEFg83sDXf9vE2W/cIvdCPMDYsxeMxPTuVvAydixyfVdqGUzGl5BikoDiSwWGECQXARXHNRJqwu3+uyc4roFQGBtHWXiSBPrrnkRBUvCKrax7XiX8+E=</D>
</RSAKeyValue>";
            public void CreateLicenseFile(Licence dto, string fileName)
            {

                var ms = new MemoryStream();

                new XmlSerializer(typeof(PizzaDelivery.Licence)).Serialize(ms, dto);

                // Create a new CspParameters object to specify
                // a key container.

                // Create a new RSA signing key and save it in the container.
                RSACryptoServiceProvider rsaKey = new RSACryptoServiceProvider();
                rsaKey.FromXmlString(PrivateKey);

                // Create a new XML document.
                XmlDocument xmlDoc = new XmlDocument();

                // Load an XML file into the XmlDocument object.
                xmlDoc.PreserveWhitespace = true;
                ms.Seek(0, SeekOrigin.Begin);
                xmlDoc.Load(ms);

                // Sign the XML document.
                SignXml(xmlDoc, rsaKey);

                // Save the document.
                xmlDoc.Save(fileName);
            }

            // Sign an XML file.
            // This document cannot be verified unless the verifying
            // code has the key with which it was signed.
            public static void SignXml(XmlDocument xmlDoc, RSA Key)
            {
                // Check arguments.
                if (xmlDoc == null)
                    throw new ArgumentException("xmlDoc");
                if (Key == null)
                    throw new ArgumentException("Key");

                // Create a SignedXml object.
                SignedXml signedXml = new SignedXml(xmlDoc);

                // Add the key to the SignedXml document.
                signedXml.SigningKey = Key;

                // Create a reference to be signed.
                Reference reference = new Reference();
                reference.Uri = "";

                // Add an enveloped transformation to the reference.
                XmlDsigEnvelopedSignatureTransform env = new XmlDsigEnvelopedSignatureTransform();
                reference.AddTransform(env);

                // Add the reference to the SignedXml object.
                signedXml.AddReference(reference);

                // Compute the signature.
                signedXml.ComputeSignature();

                // Get the XML representation of the signature and save
                // it to an XmlElement object.
                XmlElement xmlDigitalSignature = signedXml.GetXml();

                // Append the element to the XML document.
                xmlDoc.DocumentElement.AppendChild(xmlDoc.ImportNode(xmlDigitalSignature, true));
            }
        }
    }
}

