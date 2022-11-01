using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
	public class TaiwainStockUtility
	/*題目：
	 * 判斷某一DateTime 是否在股票交易營業日以及時間
	   class TaiwainStockUtility
	   bool IsTradingTime(DateTime dt)
	   日期必需在星期一~星期五
	   時間必需介於9:00 ~ 13:30
	 */
	{

		public bool IsTradingTime(DateTime dt)
		{
			int weekday = Convert.ToInt32(dt.DayOfWeek);//禮拜幾
			DateTime star = new DateTime(dt.Year, dt.Month, dt.Day, 9, 0, 0);
			DateTime end = new DateTime(dt.Year, dt.Month, dt.Day, 13, 30, 0);
			int timesecond = Convert.ToInt32(dt.Second);

			if (weekday >= 1 && weekday <= 5 && dt >= star && dt <= end)
			{
					return true;
			}

			return false;
		}

	}
}
