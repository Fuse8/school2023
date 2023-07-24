namespace Fuse8_ByteMinds.SummerSchool.Tests;

public class LazyTests
{
	[Fact(DisplayName = "Value возвращает правильное значение для типа int")]
	public void ValueWorksForTypeInt()
	{
		var lazy = new Domain.Lazy<int>(() => 256);

		var value = lazy.Value;

		Assert.Equal(expected: 256, actual: value);
	}

	[Fact(DisplayName = "Value возвращает правильное значение для типа string")]
	public void ValueWorksForTypeString()
	{
		var lazy = new Domain.Lazy<string>(() => "я все сделаль правильно");

		var value = lazy.Value;

		Assert.Equal(expected: "я все сделаль правильно", actual: value);
	}

	[Fact(DisplayName = "Value запоминает значение, рассчитанное в первый раз")]
	public void ValueRememberFirstCalculation()
	{
		var random = new Random(10_000);
		var lazy = new Domain.Lazy<int>(CalculateRandomInt);

		var firstValue = lazy.Value;
		var secondValue = lazy.Value;

		Assert.Equal(firstValue, secondValue);

		int CalculateRandomInt()
			=> random.Next();
	}

	[Fact(DisplayName = "Value вызывает экшен для создание значения только один раз")]
	public void ValueCallFuncOnlyOnce()
	{
		// Используем замыкание, чтобы подсчитать кол-во вызовов
		int funcCallCount = 0;
		var lazy = new Domain.Lazy<int>(() => ++funcCallCount);

		_ = lazy.Value;
		_ = lazy.Value;

		Assert.Equal(expected: 1, actual: funcCallCount);
	}

	[Fact(DisplayName = "Если Value не запрошивалось, то экшен для создание значения не вызывается")]
	public void FuncNotCallIfValueNotGet()
	{
		// Используем замыкание, чтобы подсчитать кол-во вызовов
		int funcCallCount = 0;
		var lazy = new Domain.Lazy<int>(() => ++funcCallCount);

		Assert.Equal(expected: 0, actual: funcCallCount);
	}

	[Fact(DisplayName = "Value работает правильно со значением null для типа int")]
	public void ValueWorksForTypeIntThatNull()
	{
		// Используем замыкание, чтобы подсчитать кол-во вызовов
		int funcCallCount = 0;
		var lazy = new Domain.Lazy<int?>(() =>
		{
			funcCallCount++;
			return null;
		});

		var firstValue = lazy.Value;
		var secondValue = lazy.Value;

		Assert.Null(firstValue);
		Assert.Null(secondValue);
		Assert.Equal(expected: 1, actual: funcCallCount);
	}

	[Fact(DisplayName = "Value работает правильно со значением default для типа int")]
	public void ValueWorksForTypeIntThatDefault()
	{
		// Используем замыкание, чтобы подсчитать кол-во вызовов
		int funcCallCount = 0;
		var lazy = new Domain.Lazy<int>(() =>
		{
			funcCallCount++;
			return default;
		});

		var firstValue = lazy.Value;
		var secondValue = lazy.Value;

		Assert.Equal(expected: default, actual: firstValue);
		Assert.Equal(expected: default, actual: secondValue);
		Assert.Equal(expected: 1, actual: funcCallCount);
	}

	[Fact(DisplayName = "Value работает правильно со значением null для типа string")]
	public void ValueWorksForTypeStringThatNull()
	{
		// Используем замыкание, чтобы подсчитать кол-во вызовов
		int funcCallCount = 0;
		var lazy = new Domain.Lazy<string?>(() =>
		{
			funcCallCount++;
			return null;
		});

		var firstValue = lazy.Value;
		var secondValue = lazy.Value;

		Assert.Null(firstValue);
		Assert.Null(secondValue);
		Assert.Equal(expected: 1, actual: funcCallCount);
	}
}