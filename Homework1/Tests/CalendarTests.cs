using Fuse8_ByteMinds.SummerSchool.Tests.TestData;

namespace Fuse8_ByteMinds.SummerSchool.Tests;

public class CalendarTests
{
	[Fact(DisplayName = "CalendarResource может получить название месяца 'Январь'")]
	public void JanuaryName()
	{
		Assert.Equal(expected: "Январь", actual: CalendarResource.January);
	}

	[Fact(DisplayName = "CalendarResource может получить название месяца 'Февраль'")]
	public void FebruaryName()
	{
		Assert.Equal(expected: "Февраль", actual: CalendarResource.February);
	}

	[Theory(DisplayName = "CalendarResource Получает название месяца по енаму Month")]
	[MemberData(memberName: nameof(CalendarResourceTestData.MonthNameByEnumData), MemberType = typeof(CalendarResourceTestData))]
	public void CalendarReturnMonthNameByEnum(Month month, string expectedName)
	{
		Assert.Equal(expected: expectedName, actual: GetMonthName(month));
	}

	[Theory(DisplayName = "При попытке получить название месяца для несуществующего Month возникает исключение")]
	[MemberData(memberName: nameof(CalendarResourceTestData.InvalidMonthEnumData), MemberType = typeof(CalendarResourceTestData))]
	public void CalendarThrowsExceptionForInvalidEnum(Month month)
	{
		Assert.Throws<ArgumentOutOfRangeException>(() => GetMonthName(month));
	}

	private static object GetMonthName(Month month) => CalendarResource.Instance[month];
}