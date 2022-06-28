using System;
using System.Linq;

namespace JustinTsengSharp.Beta.ExtensionMethods
{
	public static class StringExtensionMethods
	{
		public static bool IsNullOrEmpty(this string @this)
		{
			return string.IsNullOrEmpty(@this);
		}

		/// <summary>
		/// 此方法參考至微軟 string.IsNullOrWhiteSpace(String value) 的原始碼 
		/// .net framework 3.5 並沒有實作 string.IsNullOrWhiteSpace(String value) 此方法
		/// </summary>
		/// <param name="this"></param>
		/// <returns></returns>
		public static bool IsNullOrWhiteSpace(this string @this)
		{

			if (@this == null) return true;

			for (int i = 0; i < @this.Length; i++)
			{
				if (!Char.IsWhiteSpace(@this[i])) return false;
			}

			return true;
		}

		public static string SubStringOrEmpty(this string @this, int startIndex, int length)
		{
			if (string.IsNullOrEmpty(@this))
			{
				return string.Empty;
			}

			try
			{
#if NET35
				return string.Join(string.Empty, new string[] { new string(@this.Skip(startIndex).Take(length).ToArray()) });
#else
				return string.Join(string.Empty, @this.Skip(startIndex).Take(length));
#endif
			}
			catch
			{
				return string.Empty;
			}
		}
	}
}
