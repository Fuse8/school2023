namespace Fuse8_ByteMinds.SummerSchool.Tests.TestData;

public static class ExceptionHandlerTestData
{
	public static readonly IEnumerable<object[]> MoneyExceptionData =
		new[]
		{
			new object[] { new MoneyException("Не хватает денег") },
			new object[] { new UnknownMoneyException() },
		};

	public static readonly IEnumerable<object[]> UnknownExceptionData =
		new[]
		{
			new object[] { new ApplicationException("Сообщение об ошибке") },
			new object[] { new Exception("fox") },
			new object[] { new ArgumentException("kopeks") },
			new object[] { new InvalidOperationException("Что-то пошло не так") },
		};

	private class UnknownMoneyException : MoneyException
	{
		public UnknownMoneyException()
			: base(nameof(UnknownMoneyException))
		{
		}
	}
}