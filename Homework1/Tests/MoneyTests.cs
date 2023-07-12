using Fuse8_ByteMinds.SummerSchool.Tests.TestData;
using static Fuse8_ByteMinds.SummerSchool.Tests.TestData.MoneyTestData;

namespace Fuse8_ByteMinds.SummerSchool.Tests;

public class MoneyTests
{
	[Theory(DisplayName = "Money создается с переданным количеством рублей и копеек")]
	[MemberData(memberName: nameof(MoneyCreateData), MemberType = typeof(MoneyTestData))]
	public void MoneyCreatesWithConstructorData(bool isNegative, int rubles, int kopeks)
	{
		var money = new Money(isNegative: isNegative, rubles: rubles, kopeks: kopeks);
		Assert.Equal(expected: isNegative, actual: money.IsNegative);
		Assert.Equal(expected: rubles, actual: money.Rubles);
		Assert.Equal(expected: kopeks, actual: money.Kopeks);
	}

	[Theory(DisplayName = "Money нельзя создать с кол-вом коп. > 99 и < 0 и с кол-вом руб. < 0")]
	[MemberData(memberName: nameof(InvalidMoneyData), MemberType = typeof(MoneyTestData))]
	public void InvalidMoney(bool isNegative, int rubles, int kopeks)
	{
		Assert.Throws<ArgumentException>(() => new Money(isNegative, rubles: rubles, kopeks: kopeks));
	}

	[Theory(DisplayName = "При сложении двух Money рубли складываются с рублями, копейки - с копейками. При достижении макс. значения копеек - добавляется 1 руб.")]
	[MemberData(memberName: nameof(AdditionOperatorData), MemberType = typeof(MoneyTestData))]
	public void MoneyImplementAdditionOperator(Money money1, Money money2, Money expected)
	{
		var sum = money1 + money2;
		Assert.Equal(expected, sum);
	}

	[Theory(DisplayName = "При отнимании одних Money из других рубли отнимаются от рублей, копейки - от копеек. При достижении мин. значения копеек - отнимается 1 руб.")]
	[MemberData(memberName: nameof(SubtractionOperatorData), MemberType = typeof(MoneyTestData))]
	public void MoneyImplementSubtractionOperator(Money money1, Money money2, Money expected)
	{
		var sum = money1 - money2;
		Assert.Equal(expected, sum);
	}

	[Theory(DisplayName = "Один Money больше второго, если у первого больше рублей и копеек вместе взятых")]
	[MemberData(memberName: nameof(GreaterComparisonData), MemberType = typeof(MoneyTestData))]
	public void MoneyCanBeComparedGreater(Money money1, Money money2, bool firstGreaterThenSecond)
	{
		Assert.Equal(firstGreaterThenSecond, money1 > money2);
	}

	[Theory(DisplayName = "Один Money больше либо равен второму, если у 1 больше рублей и копеек вместе взятых, либо они равны")]
	[MemberData(memberName: nameof(GreaterOrEqualsComparisonData), MemberType = typeof(MoneyTestData))]
	public void MoneyCanBeComparedGreaterOrEquals(Money money1, Money money2, bool firstGreaterOrEqualsThenSecond)
	{
		Assert.Equal(firstGreaterOrEqualsThenSecond, money1 >= money2);
	}

	[Theory(DisplayName = "Один Money меньше второго, если у первого меньше рублей и копеек вместе взятых")]
	[MemberData(memberName: nameof(LessComparisonData), MemberType = typeof(MoneyTestData))]
	public void MoneyCanBeComparedLess(Money money1, Money money2, bool firstGreaterThenSecond)
	{
		Assert.Equal(firstGreaterThenSecond, money1 < money2);
	}

	[Theory(DisplayName = "Один Money меньше либо равен второму, если у 1 меньше рублей и копеек вместе взятых, либо они равны")]
	[MemberData(memberName: nameof(LessOrEqualsComparisonData), MemberType = typeof(MoneyTestData))]
	public void MoneyCanBeComparedLessOrEquals(Money money1, Money money2, bool firstGreaterOrEqualsThenSecond)
	{
		Assert.Equal(firstGreaterOrEqualsThenSecond, money1 <= money2);
	}
}