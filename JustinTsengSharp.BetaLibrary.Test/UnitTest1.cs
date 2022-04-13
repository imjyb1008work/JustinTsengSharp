using System;
using JustinTsengSharp.BetaLibrary.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JustinTsengSharp.BetaLibrary.Test
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var a = new HRDuration(DateTime.Now.Date, new DateTime(2022, 11, 14));
			var b = new HRDuration(DateTime.Now.Date, new DateTime(2022, 11, 14));
			Assert.IsTrue(b == a);
		}
	}
}