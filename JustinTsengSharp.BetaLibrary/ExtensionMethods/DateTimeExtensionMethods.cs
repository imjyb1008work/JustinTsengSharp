using System;
using System.Collections.Generic;
using System.Text;
using JustinTsengSharp.BetaLibrary.Helpers;

namespace JustinTsengSharp.BetaLibrary.ExtensionMethods
{
	public static class DateTimeExtensionMethods
	{
		public static bool IsBetween(this DateTime source, DateTime start, DateTime end)
		{
			return DateTimeHelper.IsBetween(source, start, end);
		}
	}
}
