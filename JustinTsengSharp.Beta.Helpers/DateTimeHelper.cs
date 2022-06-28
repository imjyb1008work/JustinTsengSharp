using System;

namespace JustinTsengSharp.Beta.Helpers
{
	public class DateTimeHelper
	{
		public static bool IsBetween(DateTime source, DateTime start, DateTime end, bool isCompareOnlyDate = false)
		{
			if (isCompareOnlyDate)
			{
				return source.Date >= start.Date && source.Date <= end.Date;
			}

			return source >= start && source <= end;
		}

		public static DateTime ToDateTimeOrDefault(string date, string time)
		{
			try
			{
				return Convert.ToDateTime(date + " " + time);
			}
			catch
			{
				return default;
			}
		}
		public static DateTime? ToDateTimeOrNull(string date, string time)
		{
			try
			{
				return Convert.ToDateTime(date + " " + time);
			}
			catch
			{
				return null;
			}
		}
	}
}
