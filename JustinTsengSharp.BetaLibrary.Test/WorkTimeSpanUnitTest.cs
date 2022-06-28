using System;
using JustinTsengSharp.BetaLibrary.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JustinTsengSharp.BetaLibrary;

namespace JustinTsengSharp.BetaLibrary.Test
{
	[TestClass]
	public class WorkTimeSpanUnitTest
	{
		[TestMethod]
		public void FromMinutes40()
		{
			var actual = WorkTimeSpan.FromMinutes(40);
			Assert.AreEqual(0, actual.Days);
			Assert.AreEqual(0, actual.Hours);
			Assert.AreEqual(40, actual.Minutes);
			Assert.AreEqual(40, actual.Ticks);
		}

		[TestMethod]
		public void FromMinutes480and65()
		{
			var actual = WorkTimeSpan.FromMinutes(480 + 65);
			Assert.AreEqual(1, actual.Days);
			Assert.AreEqual(1, actual.Hours);
			Assert.AreEqual(5, actual.Minutes);
			Assert.AreEqual(480 + 65, actual.Ticks);
		}

		[TestMethod]
		public void FromMinutes486()
		{
			var actual = WorkTimeSpan.FromMinutes(486);
			Assert.AreEqual(1, actual.Days);
			Assert.AreEqual(0, actual.Hours);
			Assert.AreEqual(6, actual.Minutes);
			Assert.AreEqual(486, actual.Ticks);
		}

		[TestMethod]
		public void FromHours2()
		{
			var actual = WorkTimeSpan.FromHours(2);
			Assert.AreEqual(0, actual.Days);
			Assert.AreEqual(2, actual.Hours);
			Assert.AreEqual(0, actual.Minutes);
			Assert.AreEqual(120, actual.Ticks);
		}

		[TestMethod]
		public void FromHours7()
		{
			var actual = WorkTimeSpan.FromHours(7);
			Assert.AreEqual(0, actual.Days);
			Assert.AreEqual(7, actual.Hours);
			Assert.AreEqual(0, actual.Minutes);
			Assert.AreEqual(7 * 60, actual.Ticks);
		}

		[TestMethod]
		public void FromHours12()
		{
			var actual = WorkTimeSpan.FromHours(12);
			Assert.AreEqual(1, actual.Days);
			Assert.AreEqual(4, actual.Hours);
			Assert.AreEqual(0, actual.Minutes);
			Assert.AreEqual(12 * 60, actual.Ticks);
		}

		[TestMethod]
		public void FromDays1()
		{
			var actual = WorkTimeSpan.FromDays(1);
			Assert.AreEqual(1, actual.Days);
			Assert.AreEqual(0, actual.Hours);
			Assert.AreEqual(0, actual.Minutes);
			Assert.AreEqual(480, actual.Ticks);
		}

		[TestMethod]
		public void FromDays2()
		{
			var actual = WorkTimeSpan.FromDays(2);
			Assert.AreEqual(2, actual.Days);
			Assert.AreEqual(0, actual.Hours);
			Assert.AreEqual(0, actual.Minutes);
			Assert.AreEqual(480 * 2, actual.Ticks);
		}

		[TestMethod]
		public void Zero()
		{
			var actual = WorkTimeSpan.Zero;
			Assert.AreEqual(0, actual.Days);
			Assert.AreEqual(0, actual.Hours);
			Assert.AreEqual(0, actual.Minutes);
			Assert.AreEqual(0, actual.Ticks);
		}

		[TestMethod]
		public void AddMinutes10()
		{
			var actual = new WorkTimeSpan().AddMinutes(10);
			Assert.AreEqual(0, actual.Days);
			Assert.AreEqual(0, actual.Hours);
			Assert.AreEqual(10, actual.Minutes);
			Assert.AreEqual(10, actual.Ticks);
		}

		[TestMethod]
		public void AddMinutes70()
		{
			var actual = new WorkTimeSpan().AddMinutes(70);
			Assert.AreEqual(0, actual.Days);
			Assert.AreEqual(1, actual.Hours);
			Assert.AreEqual(10, actual.Minutes);
			Assert.AreEqual(70, actual.Ticks);
		}

		[TestMethod]
		public void AddMinutes480and126()
		{
			var actual = new WorkTimeSpan().AddMinutes(480 + 126);
			Assert.AreEqual(1, actual.Days);
			Assert.AreEqual(2, actual.Hours);
			Assert.AreEqual(6, actual.Minutes);
			Assert.AreEqual(480 + 126, actual.Ticks);
		}

		[TestMethod]
		public void AddHours7()
		{
			var actual = new WorkTimeSpan().AddHours(7);
			Assert.AreEqual(0, actual.Days);
			Assert.AreEqual(7, actual.Hours);
			Assert.AreEqual(0, actual.Minutes);
			Assert.AreEqual(7 * 60, actual.Ticks);
		}

		[TestMethod]
		public void AddHours12()
		{
			var actual = new WorkTimeSpan().AddHours(12);
			Assert.AreEqual(1, actual.Days);
			Assert.AreEqual(4, actual.Hours);
			Assert.AreEqual(0, actual.Minutes);
			Assert.AreEqual(12 * 60, actual.Ticks);
		}

		[TestMethod]
		public void AddDays1()
		{
			var actual = new WorkTimeSpan().AddDays(1);
			Assert.AreEqual(1, actual.Days);
			Assert.AreEqual(0, actual.Hours);
			Assert.AreEqual(0, actual.Minutes);
			Assert.AreEqual(480, actual.Ticks);
		}

		[TestMethod]
		public void AddDays3()
		{
			var actual = new WorkTimeSpan().AddDays(3);
			Assert.AreEqual(3, actual.Days);
			Assert.AreEqual(0, actual.Hours);
			Assert.AreEqual(0, actual.Minutes);
			Assert.AreEqual(3 * 480, actual.Ticks);
		}

		[TestMethod]
		public void NewWorkTimeSpan50()
		{
			var actual = new WorkTimeSpan(50);
			Assert.AreEqual(0, actual.Days);
			Assert.AreEqual(0, actual.Hours);
			Assert.AreEqual(50, actual.Minutes);
			Assert.AreEqual(50, actual.Ticks);
		}

		[TestMethod]
		public void NewWorkTimeSpan70()
		{
			var actual = new WorkTimeSpan(70);
			Assert.AreEqual(0, actual.Days);
			Assert.AreEqual(1, actual.Hours);
			Assert.AreEqual(10, actual.Minutes);
			Assert.AreEqual(70, actual.Ticks);
		}

		[TestMethod]
		public void NewWorkTimeSpan1and70()
		{
			var actual = new WorkTimeSpan(1, 70);
			Assert.AreEqual(0, actual.Days);
			Assert.AreEqual(2, actual.Hours);
			Assert.AreEqual(10, actual.Minutes);
			Assert.AreEqual(60 + 70, actual.Ticks);
		}

		[TestMethod]
		public void NewWorkTimeSpan1and480()
		{
			var actual = new WorkTimeSpan(1, 480);
			Assert.AreEqual(1, actual.Days);
			Assert.AreEqual(1, actual.Hours);
			Assert.AreEqual(0, actual.Minutes);
			Assert.AreEqual(480 + 60, actual.Ticks);
		}

		[TestMethod]
		public void NewWorkTimeSpan0and1and480()
		{
			var actual = new WorkTimeSpan(0, 1, 480);
			Assert.AreEqual(1, actual.Days);
			Assert.AreEqual(1, actual.Hours);
			Assert.AreEqual(0, actual.Minutes);
			Assert.AreEqual(480 + 60, actual.Ticks);
		}

		[TestMethod]
		public void NewWorkTimeSpan1and12and60()
		{
			var actual = new WorkTimeSpan(1, 12, 60);
			Assert.AreEqual(2, actual.Days);
			Assert.AreEqual(5, actual.Hours);
			Assert.AreEqual(0, actual.Minutes);
			Assert.AreEqual(2 * 480 + 5 * 60, actual.Ticks);
		}


		[TestMethod]
		public void NewWorkTimeSpan1and40and740()
		{
			var actual = new WorkTimeSpan(1, 40, 740);
			Assert.AreEqual(1 + 5 + 1, actual.Days);
			Assert.AreEqual(4, actual.Hours);
			Assert.AreEqual(20, actual.Minutes);
			Assert.AreEqual(1 * 480 + 40 * 60 + 740, actual.Ticks);
		}
	}
}