using System;
using System.Collections.Generic;
using System.Text;

namespace JustinTsengSharp.BetaLibrary
{
	public struct WorkTimeSpan
	{
		private int _ticks;

		private const int DaysPerMinute = 480;

		private const int HoursPerMinute = 60;

		#region ctors
		public WorkTimeSpan(int days, int hours, int minutes)
		{
			_ticks = TimeToTicks(days, hours, minutes);
		}

		public WorkTimeSpan(int hours, int minutes)
		{
			_ticks = TimeToTicks(0, hours, minutes);
		}

		public WorkTimeSpan(int minutes)
		{
			_ticks = TimeToTicks(0, 0, minutes);
		}
		#endregion

		#region props
		public int Days => _ticks / DaysPerMinute;

		public int Hours => _ticks % DaysPerMinute / HoursPerMinute;

		public int Minutes => _ticks % HoursPerMinute;

		public int Ticks => _ticks;

		public static WorkTimeSpan Zero => new WorkTimeSpan(0, 0, 0);
		#endregion

		#region public static methods
		public static WorkTimeSpan FromDays(int days)
		{
			return new WorkTimeSpan(days, 0, 0);
		}

		public static WorkTimeSpan FromHours(int hours)
		{
			return new WorkTimeSpan(hours, 0);
		}

		public static WorkTimeSpan FromMinutes(int minutes)
		{
			return new WorkTimeSpan(minutes);
		}
		#endregion

		#region public methods
		public override string ToString()
		{
			return string.Format("{0:00}:{1:00}:{2:00}", Days, Hours, Minutes);
		}

		public WorkTimeSpan AddDays(int days)
		{
			return new WorkTimeSpan(Days + days, Hours, Minutes);
		}

		public WorkTimeSpan AddHours(int hours)
		{
			return new WorkTimeSpan(Days, Hours + hours, Minutes);
		}

		public WorkTimeSpan AddMinutes(int minutes)
		{
			return new WorkTimeSpan(Days, Hours, Minutes + minutes);
		}
		#endregion

		#region private static methods
		private static int TimeToTicks(int days, int hours, int minutes)
		{
			return days * DaysPerMinute + hours * HoursPerMinute + minutes;
		}
		#endregion
	}
}
