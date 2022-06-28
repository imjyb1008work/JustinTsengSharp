using System;

namespace JustinTsengSharp.Beta.ExtensionMethods
{
	public static class DateTimeExtensionMethods
	{
		public static bool IsBetween(this DateTime @this, DateTime start, DateTime end, bool isCompareOnlyDate = false)
		{
			if (isCompareOnlyDate)
			{
				return @this.Date >= start.Date && @this.Date <= end.Date;
			}

			return @this >= start && @this <= end;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="source"></param>
		/// <param name="start"></param>
		/// <param name="end"></param>
		/// <param name="isCompareOnlyDate"></param>
		/// <returns>若source為null,則一定返回false</returns>
		public static bool IsBetween(this DateTime? source, DateTime start, DateTime end, bool isCompareOnlyDate = false)
		{
			if (source == null) { return false; }

			return isCompareOnlyDate ?
				source.Value.Date >= start.Date && source <= end.Date
				: source >= start && source <= end;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="source"></param>
		/// <param name="start"></param>
		/// <param name="end"></param>
		/// <param name="isCompareOnlyDate"></param>
		/// <returns>若任一個參數為null 則一定返回false</returns>
		public static bool IsBetween(this DateTime? source, DateTime? start, DateTime? end, bool isCompareOnlyDate = false)
		{
			if (source == null || start == null || end == null) { return false; }

			return isCompareOnlyDate ?
				source.Value.Date >= start.Value.Date && source <= end.Value.Date
				: source >= start && source <= end;
		}

		public static int PrevYear(this DateTime @this)
		{
			return @this.AddYears(-1).Year;
		}

		public static int NextYear(this DateTime @this)
		{
			return @this.AddYears(1).Year;
		}

		public static int PrevMonth(this DateTime @this)
		{
			return @this.AddMonths(-1).Month;
		}

		public static int NextMonth(this DateTime @this)
		{
			return @this.AddMonths(1).Month;
		}
	}
}
