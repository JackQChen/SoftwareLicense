using System;
using System.Text;
using System.Security.Cryptography;

namespace Register
{
    /// <summary> 
    /// RSA加密解密及RSA签名和验证
    /// </summary> 
    public class RSACryption
    {
        public RSACryption()
        {
        }

        #region RSA 的密钥产生

        /// <summary>
        /// RSA 的密钥产生 产生私钥 和公钥 
        /// </summary>
        /// <param name="xmlKeys"></param>
        /// <param name="xmlPublicKey"></param>
        public void RSAKey(out string xmlKeys, out string xmlPublicKey)
        {
            System.Security.Cryptography.RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            xmlKeys = rsa.ToXmlString(true);
            xmlPublicKey = rsa.ToXmlString(false);
        }

        #endregion

        #region RSA的加解密

        /// <summary>
        /// RSA加密
        /// </summary>
        /// <param name="xmlPublicKey">公钥</param>
        /// <param name="m_strEncryptString">需要加密的数据</param>
        /// <returns>RSA公钥加密后的数据</returns>
        public string RSAEncrypt(string xmlPublicKey, string m_strEncryptString)
        {
            string str2;
            try
            {
                RSACryptoServiceProvider provider = new RSACryptoServiceProvider();
                provider.FromXmlString(xmlPublicKey);
                byte[] bytes = new UnicodeEncoding().GetBytes(m_strEncryptString);
                str2 = Convert.ToBase64String(provider.Encrypt(bytes, false));
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return str2;
        }

        /// <summary>
        /// RSA解密
        /// </summary>
        /// <param name="xmlPrivateKey">私钥</param>
        /// <param name="m_strDecryptString">需要解密的数据</param>
        /// <returns>解密后的数据</returns>
        public string RSADecrypt(string xmlPrivateKey, string m_strDecryptString)
        {
            string str2;
            try
            {
                RSACryptoServiceProvider provider = new RSACryptoServiceProvider();
                provider.FromXmlString(xmlPrivateKey);
                byte[] rgb = Convert.FromBase64String(m_strDecryptString);
                byte[] buffer2 = provider.Decrypt(rgb, false);
                str2 = new UnicodeEncoding().GetString(buffer2);
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return str2;
        }

        #endregion

        #region RSA数字签名

        //获取Hash描述表 
        public string GetHash(string m_strSource)
        {
            //从字符串中取得Hash描述 
            byte[] Buffer;
            byte[] HashData;
            HashAlgorithm MD5 = HashAlgorithm.Create("MD5");
            Buffer = Encoding.Default.GetBytes(m_strSource);
            HashData = MD5.ComputeHash(Buffer);
            return Convert.ToBase64String(HashData);
        }

        /// <summary>
        /// 签名
        /// </summary>
        /// <param name="p_strKeyPrivate">私钥</param>
        /// <param name="m_strHashbyteSignature">需签名的数据</param>
        /// <returns>签名后的值</returns>
        public string SignatureFormatter(string p_strKeyPrivate, string m_strHashbyteSignature)
        {
            byte[] rgbHash = Convert.FromBase64String(m_strHashbyteSignature);
            RSACryptoServiceProvider key = new RSACryptoServiceProvider();
            key.FromXmlString(p_strKeyPrivate);
            RSAPKCS1SignatureFormatter formatter = new RSAPKCS1SignatureFormatter(key);
            formatter.SetHashAlgorithm("MD5");
            byte[] inArray = formatter.CreateSignature(rgbHash);
            return Convert.ToBase64String(inArray);
        }

        /// <summary>
        /// 签名验证
        /// </summary>
        /// <param name="p_strKeyPublic">公钥</param>
        /// <param name="p_strHashbyteDeformatter">待验证的用户名</param>
        /// <param name="p_strDeformatterData">注册码</param>
        /// <returns>签名是否符合</returns>
        public bool SignatureDeformatter(string p_strKeyPublic, string p_strHashbyteDeformatter, string p_strDeformatterData)
        {
            try
            {
                byte[] rgbHash = Convert.FromBase64String(p_strHashbyteDeformatter);
                RSACryptoServiceProvider key = new RSACryptoServiceProvider();
                key.FromXmlString(p_strKeyPublic);
                RSAPKCS1SignatureDeformatter deformatter = new RSAPKCS1SignatureDeformatter(key);
                deformatter.SetHashAlgorithm("MD5");
                byte[] rgbSignature = Convert.FromBase64String(p_strDeformatterData);
                if (deformatter.VerifySignature(rgbHash, rgbSignature))
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        #endregion

    }
}
