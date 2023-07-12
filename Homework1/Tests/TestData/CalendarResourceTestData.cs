using static Fuse8_ByteMinds.SummerSchool.Domain.Month;

namespace Fuse8_ByteMinds.SummerSchool.Tests.TestData;

public static class CalendarResourceTestData
{
	public static readonly IEnumerable<object[]> MonthNameByEnumData =
		new[]
		{
			new object[] { January, "Январь", },
			new object[] { February, "Февраль", },
			new object[] { March, "Март", },
			new object[] { April, "Апрель", },
			new object[] { May, "Май", },
			new object[] { June, "Июнь", },
			new object[] { July, "Июль", },
			new object[] { August, "Август", },
			new object[] { September, "Сентябрь", },
			new object[] { October, "Октябрь", },
			new object[] { November, "Ноябрь", },
			new object[] { December, "Декабрь", },
		};

	public static readonly IEnumerable<object[]> InvalidMonthEnumData =
		new[]
		{
			new object[] { (Month)1_000_000 },
		};

}