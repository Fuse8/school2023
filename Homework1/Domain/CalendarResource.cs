namespace Fuse8_ByteMinds.SummerSchool.Domain;

/// <summary>
/// Значения ресурсов для календаря
/// </summary>
public class CalendarResource
{
	public static readonly CalendarResource Instance = new();

	public static readonly string January = GetMonthByNumber(0);
	public static readonly string February = GetMonthByNumber(1);

	private static readonly string[] MonthNames;

	static CalendarResource()
	{
		MonthNames = new[]
		{
			"Январь",
			"Февраль",
			"Март",
			"Апрель",
			"Май",
			"Июнь",
			"Июль",
			"Август",
			"Сентябрь",
			"Октябрь",
			"Ноябрь",
			"Декабрь",
		};
	}

	private static string GetMonthByNumber(int number)
		=> MonthNames[number];

	// ToDo реализовать индексатор для получения названия месяца по енаму Month
}

public enum Month
{
	January,
	February,
	March,
	April,
	May,
	June,
	July,
	August,
	September,
	October,
	November,
	December,
}