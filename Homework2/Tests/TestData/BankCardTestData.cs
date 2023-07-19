namespace Fuse8_ByteMinds.SummerSchool.Tests.TestData;

public static class BankCardTestData
{
	public static readonly IEnumerable<object[]> UnmaskedNumberData =
		new[]
		{
			new object[] { "4444000011112222" },
			new object[] { "4444123445642227"},
		};

	public static readonly IEnumerable<object[]> MaskedNumberData =
		new[]
		{
			new object[] { "4444000011112222", "4444********2222" },
			new object[] { "4444123445642227", "4444********2227"},
		};
}