using System;
using System.Collections.Generic;
using System.Text;

namespace JustinTsengSharp.BetaLibrary.Helpers
{
	public class DateTimeHelper
	{
		public static DateTime GetFirstDateInMonth(int year, int month)
			=> new DateTime(year, month, 1);

		public static DateTime GetLastDateInMonth(int year, int month)
			=> new DateTime(year, month, DateTime.DaysInMonth(year, month));

		public static DateTime GetDateInPrevMonth(int year, int month)
			=> new DateTime(year, month, 1).AddMonths(-1);

		public static DateTime GetDateInPrevMonth(int year, int month, int day)
			=> new DateTime(year, month, day).AddMonths(-1);

		public static DateTime GetDateInNextMonth(int year, int month)
			=> new DateTime(year, month, 1).AddMonths(1);

		public static DateTime GetDateInNextMonth(int year, int month, int day)
			=> new DateTime(year, month, day).AddMonths(1);

		public static bool IsBetween(DateTime value, DateTime start, DateTime end)
			=> value >= start && value <= end;
	}
}
