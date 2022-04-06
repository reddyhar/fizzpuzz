using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using WebAppProcess.BusinessLayer;

namespace UnitTestFizzBuzz
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void CheckFizz_Validcase()
		{
			Extract obj = new Extract();
			DataTable dt = obj.FormatInput("3");
			Assert.AreEqual(dt.Rows[0][1].ToString(), "Fizz");
		}
		[TestMethod]
		public void CheckBuzz_validcase()
		{
			Extract obj = new Extract();
			DataTable dt = obj.FormatInput("5");
			Assert.AreEqual(dt.Rows[0][1].ToString(), "Buzz");
		}
		[TestMethod]
		public void CheckBuzzFizz_validcase()
		{
			Extract obj = new Extract();
			DataTable dt = obj.FormatInput("5,3");
			Assert.AreEqual(dt.Rows[0][1].ToString(), "Buzz");
			Assert.AreEqual(dt.Rows[1][1].ToString(), "Fizz");
		}
		[TestMethod]
		public void CheckRandomNumber_validcase()
		{
			Extract obj = new Extract();
			DataTable dt = obj.FormatInput("11");
			Assert.IsTrue(dt.Rows[0][1].ToString().Contains("Divided"));
			
		}
		[TestMethod]
		public void CheckInvalidItem()
		{
			Extract obj = new Extract();
			DataTable dt = obj.FormatInput("A");
			Assert.AreEqual(dt.Rows[0][1].ToString(), "Invalid Item");
			
		}
	}
}
