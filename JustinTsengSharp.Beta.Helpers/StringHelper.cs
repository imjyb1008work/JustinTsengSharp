using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustinTsengSharp.Beta.Helpers
{
	public class StringHelper
	{
		public static bool IsNullOrEmpty(string source)
		{
			return string.IsNullOrEmpty(source);
		}

		/// <summary>
		/// 此方法參考至微軟 string.IsNullOrWhiteSpace(String value) 的原始碼 
		/// .net framework 3.5 並沒有實作 string.IsNullOrWhiteSpace(String value) 此方法
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		public static bool IsNullOrWhiteSpace(string source)
		{
			if (source == null) return true;

			for (int i = 0; i < source.Length; i++)
			{
				if (!Char.IsWhiteSpace(source[i])) return false;
			}

			return true;
		}
	}
}
