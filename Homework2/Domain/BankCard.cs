namespace Fuse8_ByteMinds.SummerSchool.Domain;

/// <summary>
/// Банковская карта
/// </summary>
public class BankCard
{
	private readonly string _number;

	public BankCard(string number, string cardHolder)
	{
		if (number.Length != 16)
		{
			throw new ArgumentException(nameof(number));
		}

		if (cardHolder.Length == 0)
		{
			throw new ArgumentException(nameof(cardHolder));
		}

		CardHolder = cardHolder;
		_number = number;
	}

	/// <summary>
	/// Маскированный номер карты
	/// </summary>
	public string MaskedCardNumber =>
		_number[..4] + new string('*', 8) + _number[^4..];

	/// <summary>
	/// Держатель карты
	/// </summary>
	public string CardHolder { get; }
}