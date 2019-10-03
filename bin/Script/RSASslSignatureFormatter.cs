using Mono.Security.Cryptography;
using System;
using System.Security.Cryptography;

namespace Mono.Security.Protocol.Tls
{
	internal class RSASslSignatureFormatter : AsymmetricSignatureFormatter
	{
		private RSA key;

		private HashAlgorithm hash;

		public RSASslSignatureFormatter()
		{
		}

		public RSASslSignatureFormatter(AsymmetricAlgorithm key)
		{
			SetKey(key);
		}

		public override byte[] CreateSignature(byte[] rgbHash)
		{
			if (key == null)
			{
				throw new CryptographicUnexpectedOperationException("The key is a null reference");
			}
			if (hash == null)
			{
				throw new CryptographicUnexpectedOperationException("The hash algorithm is a null reference.");
			}
			if (rgbHash == null)
			{
				throw new ArgumentNullException("The rgbHash parameter is a null reference.");
			}
			return PKCS1.Sign_v15(key, hash, rgbHash);
		}

		public override void SetHashAlgorithm(string strName)
		{
			switch (strName)
			{
			case "MD5SHA1":
				hash = new MD5SHA1();
				break;
			default:
				hash = HashAlgorithm.Create(strName);
				break;
			}
		}

		public override void SetKey(AsymmetricAlgorithm key)
		{
			if (!(key is RSA))
			{
				throw new ArgumentException("Specfied key is not an RSA key");
			}
			this.key = (key as RSA);
		}
	}
}
