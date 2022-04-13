using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace JustinTsengSharp.BetaLibrary.Helpers
{
	public class HashHelper
	{
		public static string ToMD5(string value)
		{
			using (var crypto = MD5.Create())
			{
				string result = Hashing(value, crypto);
				return result;
			}
		}

		public static string ToSHA1(string value)
		{
			using (var crypto = SHA1.Create())
			{
				string result = Hashing(value, crypto);
				return result;
			}
		}

		public static string ToSHA256(string value)
		{
			using (var crypto = SHA256.Create())
			{
				string result = Hashing(value, crypto);
				return result;
			}
		}

		public static string ToSHA384(string value)
		{
			using (var crypto = SHA384.Create())
			{
				string result = Hashing(value, crypto);
				return result;
			}
		}

		public static string ToSHA512(string value)
		{
			using (var crypto = SHA512.Create())
			{
				string result = Hashing(value, crypto);
				return result;
			}
		}

		private static string Hashing(string value, HashAlgorithm crypto)
		{
			//將字串編碼成 UTF8 位元組陣列
			var bytes = Encoding.UTF8.GetBytes(value);

			//取得雜湊值位元組陣列
			var hash = crypto.ComputeHash(bytes);

			string result = string.Empty;

			result = string.Join(string.Empty, hash.Select(x => x.ToString("X2")));

			return result;
		}
	}
}
