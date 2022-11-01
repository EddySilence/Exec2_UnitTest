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
		public void �b��~�ɶ���()
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
		public void ���b��~�ɶ����]�����A§���@�줭(string inputDate)
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
		public void ���A��~�ɶ����]���ɶ�����(string inputDate)
		{
			DateTime dateTime = Convert.ToDateTime(inputDate);
			var obj = new TaiwainStockUtility();

			bool salesperson = obj.IsTradingTime(dateTime);

			Assert.AreEqual(salesperson, false);
		}
	}
}