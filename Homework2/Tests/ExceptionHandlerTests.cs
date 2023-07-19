using System.Net;
using Fuse8_ByteMinds.SummerSchool.Tests.TestData;
using static Fuse8_ByteMinds.SummerSchool.Tests.TestData.ExceptionHandlerTestData;

namespace Fuse8_ByteMinds.SummerSchool.Tests;

public class ExceptionHandlerTests
{
	[Fact(DisplayName = "Если Action отработал без исключений, возвращает null")]
	public void NullIfHasNoError()
	{
		var errorMessage = ExceptionHandler.Handle(() => { });
		Assert.Null(errorMessage);
	}

	[Theory(DisplayName = "При возникновении MoneyException, возвращает сообщение из эксепшена")]
	[MemberData(memberName: nameof(MoneyExceptionData), MemberType = typeof(ExceptionHandlerTestData))]
	public void UnknownMoneyExceptionMessage(MoneyException moneyException)
	{
		var errorMessage = ExceptionHandler.Handle(() => throw moneyException);
		Assert.Equal(moneyException.Message, errorMessage);
	}

	[Theory(DisplayName = "При возникновении неизвестного исключения, возвращает сообщение 'Произошла непредвиденная ошибка'")]
	[MemberData(memberName: nameof(UnknownExceptionData), MemberType = typeof(ExceptionHandlerTestData))]
	public void UnknownExceptionMessage(Exception unknownException)
	{
		var errorMessage = ExceptionHandler.Handle(() => throw unknownException);
		Assert.Equal("Произошла непредвиденная ошибка", errorMessage);
	}

	[Fact(DisplayName = "При возникновении NotValidKopekCountException, возвращает 'Количество копеек должно быть больше 0 и меньше 99'")]
	public void NotValidKopekCountExceptionMessage()
	{
		var errorMessage = ExceptionHandler.Handle(() => throw new NotValidKopekCountException());
		Assert.Equal("Количество копеек должно быть больше 0 и меньше 99", errorMessage);
	}

	[Fact(DisplayName = "При возникновении NegativeRubleCountException, возвращает 'Число рублей не может быть отрицательным'")]
	public void NegativeRubleCountExceptionMessage()
	{
		var errorMessage = ExceptionHandler.Handle(() => throw new NegativeRubleCountException());
		Assert.Equal("Число рублей не может быть отрицательным", errorMessage);
	}

	[Fact(DisplayName = "При возникновении HttpRequestException, возвращает значение StatusCode")]
	public void HttpRequestExceptionMessage()
	{
		var errorMessage = ExceptionHandler.Handle(() => throw CreateHttpRequestException(HttpStatusCode.BadRequest));
		Assert.Equal("BadRequest", errorMessage);
	}

	[Fact(DisplayName = "При возникновении HttpRequestException, у которого StatusCode=404, возвращает значение 'Ресурс не райден'")]
	public void HttpRequestExceptionNotFoundMessage()
	{
		var errorMessage = ExceptionHandler.Handle(() => throw CreateHttpRequestException(HttpStatusCode.NotFound));
		Assert.Equal("Ресурс не райден", errorMessage);
	}

	private static HttpRequestException CreateHttpRequestException(HttpStatusCode statusCode) => new("Произошла ошибка http-запроса", null, statusCode);
}