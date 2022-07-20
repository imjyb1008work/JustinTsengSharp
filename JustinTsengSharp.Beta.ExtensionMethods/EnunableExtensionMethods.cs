using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustinTsengSharp.Beta.ExtensionMethods
{
	public static class EnunableExtensionMethods
	{
		/// <summary>
		/// 判斷集合物件是否有資料
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="this"></param>
		/// <returns>source本身若為null則回傳false,否則傳回 source.Any()的結果</returns>
		public static bool IsAnyOrFalse<T>(this IEnumerable<T> @this)
		{
			return @this == null ? false : @this.Any();
		}

		public static bool HasValue<T>(this IEnumerable<T> @this)
		{
			return @this != null;
		}

		public static bool IsNullOrEmpty<T>(this IEnumerable<T> @this)
		{
			return @this == null || !@this.Any();
		}

		public static int CountOrZero<T>(this IEnumerable<T> @this)
		{
			return @this == null ? 0 : @this.Count();
		}

		public static List<T> ToPagedList<T>(this IEnumerable<T> @this, int pageNumber, int pageSize)
		{
			return ToPaged(@this, pageNumber, pageSize).ToList();
		}

		public static IEnumerable<T> ToPaged<T>(this IEnumerable<T> @this, int pageNumber, int pageSize)
		{
			return @this.Skip((pageNumber - 1) * pageSize).Take(pageSize);
		}

		public static T[] ToPagedArray<T>(this IEnumerable<T> @this, int pageNumber, int pageSize)
		{
			return ToPaged(@this, pageNumber, pageSize).ToArray();
		}
	}
}
