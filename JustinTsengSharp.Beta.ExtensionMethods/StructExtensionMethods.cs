using System;
using System.Collections.Generic;
using System.Text;

namespace JustinTsengSharp.Beta.ExtensionMethods
{
	public static class StructExtensionMethods
	{
		public static bool IsBetween<T>(this T @this, T start, T end) where T :struct
		{
			return Comparer<T>.Default.Compare(@this, start) >= 0 && Comparer<T>.Default.Compare(@this, end) <= 0;
		}
	}
}
