namespace Fuse8_ByteMinds.SummerSchool.Domain;

/// <summary>
/// Контейнер для значения, с отложенным получением
/// </summary>
public class Lazy<TValue>
{
	// TODO Реализовать ленивое получение значение при первом обращении к Value

	public TValue? Value { get; }
}