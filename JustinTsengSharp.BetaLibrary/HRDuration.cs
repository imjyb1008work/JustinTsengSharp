using System;
using System.Collections.Generic;
using System.Text;

namespace JustinTsengSharp.BetaLibrary
{
	//https://blog.opasschang.com/csharp-struct-usage-notes/

	public class HRDuration
	{
		public HRDuration(DateTime start, DateTime end)
		{
			Start = start;
			End = end;

			if (Start >= End)
			{
				Years = 0;
				Months = 0;
				Days = 0;
				return;
			}

			Years = End.Year - Start.Year;
			Months = End.Month - Start.Month;
			Days = End.Day - Start.Day;
		}

		public DateTime Start { get; }

		public DateTime End { get; }

		public int Years { get; }

		public int Months { get; }

		public int Days { get; }

		public static bool operator ==(HRDuration left, HRDuration right)
		{
			return
				left.Years == right.Years
				&& left.Months == right.Months
				&& left.Days == right.Days;
		}

		public static bool operator !=(HRDuration left, HRDuration right)
		{
			return !(left == right);
		}

		public static bool operator >(HRDuration left, HRDuration right)
		{
			if (left.Years > right.Years) { return true; }
			if (left.Months > right.Months) { return true; }
			if (left.Days > right.Days) { return true; }
			return false;
		}

		public static bool operator <(HRDuration left, HRDuration right)
		{
			if (left.Years < right.Years) { return true; }
			if (left.Months < right.Months) { return true; }
			if (left.Days < right.Days) { return true; }
			return false;
		}

		public static bool operator >=(HRDuration left, HRDuration right)
		{
			if (left == right) { return true; }
			if (left > right) { return true; }
			return false;
		}

		public static bool operator <=(HRDuration left, HRDuration right)
		{
			if (left == right) { return true; }
			if (left < right) { return true; }
			return false;
		}
	}
}
