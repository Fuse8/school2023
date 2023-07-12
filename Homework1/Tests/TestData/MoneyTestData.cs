namespace Fuse8_ByteMinds.SummerSchool.Tests.TestData;

public static class MoneyTestData
{
	public static readonly IEnumerable<object[]> InvalidMoneyData =
		new[]
		{
			new object[] { true, 0, 100 },
			new object[] { false, 0, 100 },
			new object[] { false, 0, 101 },
			new object[] { false, 0, -1 },
			new object[] { false, -1, 0 },
			new object[] { true, 0, 0 },
		};

	public static readonly IEnumerable<object[]> MoneyCreateData =
		new[]
		{
			new object[] { false, 0, 0 },
			new object[] { false, 100, 0 },
			new object[] { false, 120, 25 },
			new object[] { true, 120, 25 },
			new object[] { true, 0, 25 },
			new object[] { true, 0, 01 },
		};

	public static readonly IEnumerable<object[]> AdditionOperatorData =
		new[]
		{
			new object[] { new Money(0, 00), new Money(0, 00), new Money(0, 00) },
			new object[] { new Money(0, 00), new Money(10, 00), new Money(10, 00) },
			new object[] { new Money(0, 10), new Money(0, 00), new Money(0, 10) },
			new object[] { new Money(0, 99), new Money(0, 99), new Money(1, 98) },
			new object[] { new Money(0, 01), new Money(0, 99), new Money(1, 00) },
			new object[] { new Money(isNegative: true, 10, 01), new Money(0, 99), new Money(isNegative: true, 9, 02) },
			new object[] { new Money(isNegative: true, 10, 01), new Money(isNegative: true, 0, 99), new Money(isNegative: true, 11, 00) },
		};

	public static readonly IEnumerable<object[]> SubtractionOperatorData =
		new[]
		{
			new object[] { new Money(0, 00), new Money(0, 00), new Money(0, 00), },
			new object[] { new Money(10, 00), new Money(0, 00), new Money(10, 00), },
			new object[] { new Money(0, 10), new Money(0, 10), new Money(0, 00), },
			new object[] { new Money(1, 98), new Money(0, 99), new Money(0, 99), },
			new object[] { new Money(1, 00), new Money(0, 01), new Money(0, 99), },
			new object[] { new Money(isNegative: true, 9, 02), new Money(isNegative: true, 10, 01), new Money(0, 99), },
			new object[] { new Money(isNegative: true, 11, 00), new Money(isNegative: true, 10, 01), new Money(isNegative: true, 0, 99), },
		};

	public static readonly IEnumerable<object[]> GreaterComparisonData =
		new[]
		{
			new object[] { new Money(0, 00), new Money(0, 00), false, },
			new object[] { new Money(10, 00), new Money(0, 00), true, },
			new object[] { new Money(1, 98), new Money(0, 99), true, },
			new object[] { new Money(1, 98), new Money(isNegative: true, 1, 99), true, },
			new object[] { new Money(1, 00), new Money(0, 01), true, },
			new object[] { new Money(isNegative: true, 9, 02), new Money(isNegative: true, 10, 01), true, },
			new object[] { new Money(isNegative: true, 11, 00), new Money(isNegative: true, 11, 01), true, },
			new object[] { new Money(11, 00), new Money(11, 01), false, },
		};

	public static readonly IEnumerable<object[]> GreaterOrEqualsComparisonData =
		new[]
		{
			new object[] { new Money(0, 00), new Money(0, 00), true, },
			new object[] { new Money(0, 10), new Money(0, 10), true, },
			new object[] { new Money(10, 00), new Money(0, 00), true, },
			new object[] { new Money(1, 98), new Money(0, 99), true, },
			new object[] { new Money(isNegative: true, 1, 00), new Money(1, 00), false, },
			new object[] { new Money(isNegative: true, 9, 02), new Money(isNegative: true, 10, 01), true, },
			new object[] { new Money(isNegative: true, 9, 02), new Money(isNegative: true, 9, 02), true, },
			new object[] { new Money(isNegative: true, 11, 00), new Money(isNegative: true, 11, 01), true, },
			new object[] { new Money(11, 00), new Money(11, 01), false, },
		};

	public static readonly IEnumerable<object[]> LessComparisonData =
		new[]
		{
			new object[] { new Money(0, 00), new Money(0, 00), false, },
			new object[] { new Money(10, 00), new Money(0, 00), false, },
			new object[] { new Money(1, 98), new Money(0, 99), false, },
			new object[] { new Money(1, 00), new Money(0, 01), false, },
			new object[] { new Money(isNegative: true, 19, 02), new Money(isNegative: true, 10, 01), true, },
			new object[] { new Money(isNegative: true, 11, 00), new Money(isNegative: true, 11, 01), false, },
			new object[] { new Money(11, 00), new Money(11, 01), true, },
		};

	public static readonly IEnumerable<object[]> LessOrEqualsComparisonData =
		new[]
		{
			new object[] { new Money(0, 00), new Money(0, 00), true, },
			new object[] { new Money(0, 10), new Money(0, 10), true, },
			new object[] { new Money(10, 00), new Money(0, 00), false, },
			new object[] { new Money(1, 98), new Money(0, 99), false, },
			new object[] { new Money(1, 00), new Money(isNegative: true, 1, 00), false, },
			new object[] { new Money(isNegative: true, 10, 01), new Money(isNegative: true, 9, 02), true, },
			new object[] { new Money(isNegative: true, 9, 02), new Money(isNegative: true, 9, 02), true, },
			new object[] { new Money(isNegative: true, 11, 01), new Money(isNegative: true, 11, 00), true, },
			new object[] { new Money(11, 00), new Money(11, 01), true, },
		};
}