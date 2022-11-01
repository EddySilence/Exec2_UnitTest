using ClassLibrary1;

namespace TestProject1
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void 在營業時間內()
		{
			var obj = new TaiwainStockUtility();

			DateTime dateTime = new DateTime(2022,11,1,12,20,32);
			bool salesperson = obj.IsTradingTime(dateTime);

			Assert.AreEqual(salesperson, true);
		}
		[TestCase("2022/10/30 12:30:23")]
		[TestCase("2022/10/29 12:30:23")]
		[TestCase("2022/11/5 12:30:23")]
		[TestCase("2022/11/6 12:30:23")]
		public void 不在營業時間內因為不再禮拜一到五(string inputDate)
		{
			DateTime dateTime = Convert.ToDateTime(inputDate);
			var obj = new TaiwainStockUtility();

			bool salesperson = obj.IsTradingTime(dateTime);

			Assert.AreEqual(salesperson, false);
		}

		[TestCase("2022/11/1 16:31:23")]
		[TestCase("2022/11/1 13:31:23")]
		[TestCase("2022/11/2 13:40:23")]
		[TestCase("2022/11/3 18:31:23")]
		[TestCase("2022/11/3 18:30:23")]
		public void 不再營業時間內因為時間不對(string inputDate)
		{
			DateTime dateTime = Convert.ToDateTime(inputDate);
			var obj = new TaiwainStockUtility();

			bool salesperson = obj.IsTradingTime(dateTime);

			Assert.AreEqual(salesperson, false);
		}
	}
}