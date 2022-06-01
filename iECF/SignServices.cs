using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Xml;

namespace iECF
{
    public class SignServices
    {
        public static SignServices Current
        {
            get
            {
                return new SignServices();
            }
        }

        public SignServices()
        {
        }

        public XmlDocument FirmarXml(string pathFile, string pathCert, string passCert, bool fhFirma = false, string xml = "")
        {
            XmlDocument xmlDocument;
            try
            {
                XmlDocument xmlDocument1 = new XmlDocument();
                if (xml == "")
                    xmlDocument1.Load(pathFile);
                else
                    xmlDocument1.LoadXml(xml);
                if (fhFirma)
                {
                    XmlElement str = xmlDocument1.CreateElement("FechaHoraFirma");
                    str.InnerText = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
                    xmlDocument1.DocumentElement.AppendChild(str);

                }
                this.Signed(xmlDocument1, pathCert, passCert);
                xmlDocument = xmlDocument1;
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                string[] strArrays = pathFile.Split(new char[] { '\\' });
                string str1 = strArrays[(int)strArrays.Length - 1];
                throw new Exception(string.Concat(new string[] { "Ha ocurrido un error al firmar el archivo '", str1, "' (Error:", exception.Message, ")" }));
            }
            return xmlDocument;
        }

        private void Signed(XmlDocument xmlDoc, string pathCert, string passCert)
        {
            try
            {
                if (!File.Exists(pathCert))
                {
                    throw new Exception("El certificado para firma no existe");
                }
                X509Certificate2 x509Certificate2 = new X509Certificate2(pathCert, passCert, X509KeyStorageFlags.Exportable);
                string xmlString = x509Certificate2.PrivateKey.ToXmlString(true);
                RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(new CspParameters(24))
                {
                    PersistKeyInCsp = false
                };
                rSACryptoServiceProvider.FromXmlString(xmlString);
                SignedXml signedXml = new SignedXml(xmlDoc)
                {
                    SigningKey = rSACryptoServiceProvider
                };
                signedXml.SignedInfo.SignatureMethod = "http://www.w3.org/2001/04/xmldsig-more#rsa-sha256";
                Reference reference = new Reference();
                reference.AddTransform(new XmlDsigEnvelopedSignatureTransform());
                reference.DigestMethod = "http://www.w3.org/2001/04/xmlenc#sha256";
                reference.Uri = "";
                signedXml.AddReference(reference);
                KeyInfo keyInfos = new KeyInfo();
                keyInfos.AddClause(new KeyInfoX509Data(x509Certificate2));
                signedXml.KeyInfo = keyInfos;
                signedXml.ComputeSignature();
                XmlElement xml = signedXml.GetXml();
                xmlDoc.DocumentElement.AppendChild(xmlDoc.ImportNode(xml, true));
            }
            catch (Exception exception)
            {
                throw exception;
            }
        } 
        public partial class Mensaje
        {
            public string valor { get; set; }
            public int codigo { get; set; }
        }
    }



}
