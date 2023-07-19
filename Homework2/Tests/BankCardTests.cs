using Fuse8_ByteMinds.SummerSchool.Tests.TestData;
using static Fuse8_ByteMinds.SummerSchool.Tests.TestData.BankCardTestData;

namespace Fuse8_ByteMinds.SummerSchool.Tests;

public class BankCardTests
{
	[Theory(DisplayName = "BankCardHelpers может получать немаскированный номер карты")]
	[MemberData(memberName: nameof(UnmaskedNumberData), MemberType = typeof(BankCardTestData))]
	public void BankCardHelpersGetsUnmaskedNumber(string cardNumber)
	{
		var card = new BankCard(cardNumber, "Feofan Petrov");
		var unmaskedNumber = BankCardHelpers.GetUnmaskedCardNumber(card);
		Assert.Equal(expected: cardNumber, actual: unmaskedNumber);
	}

	[Theory(DisplayName = "BankCard возвращает маскированный номер карты")]
	[MemberData(memberName: nameof(MaskedNumberData), MemberType = typeof(BankCardTestData))]
	public void BankCardReturnsMaskedNumber(string cardNumber, string maskedCardNumber)
	{
		var card = new BankCard(cardNumber, "Feofan Petrov");
		Assert.Equal(expected: maskedCardNumber, actual: card.MaskedCardNumber);
	}
}