namespace Fuse8_ByteMinds.SummerSchool.InternalApi.Contracts;

interface ICurrencyAPI
{
	/// <summary>
	/// Получает текущий курс для всех валют
	/// </summary>
	/// <param name="baseCurrency">Базовая валюта, относительно которой необходимо получить курс</param>
	/// <param name="cancellationToken">Токен отмены</param>
	/// <returns>Список курсов валют</returns>
	Task<Currency[]> GetAllCurrentCurrenciesAsync(string baseCurrency, CancellationToken cancellationToken);

	/// <summary>
	/// Получает курс для всех валют, актуальный на <paramref name="date"/>
	/// </summary>
	/// <param name="baseCurrency">Базовая валюта, относительно которой необходимо получить курс</param>
	/// <param name="date">Дата, на которую нужно получить курс валют</param>
	/// <param name="cancellationToken">Токен отмены</param>
	/// <returns>Список курсов валют на дату</returns>
	Task<CurrenciesOnDate> GetAllCurrenciesOnDateAsync(string baseCurrency, DateOnly date, CancellationToken cancellationToken);
}

// Данные модели использовать не обязательно, можно реализовать свои

/// <summary>
/// Курс валюты
/// </summary>
/// <param name="Code">Код валюты</param>
/// <param name="Value">Значение курса валют, относительно базовой валюты</param>
record Currency(string Code, decimal Value);

/// <summary>
/// Курсы валют на конкретную дату
/// </summary>
/// <param name="LastUpdatedAt">Дата обновления данных</param>
/// <param name="Currencies">Список курсов валют</param>
record CurrenciesOnDate(DateTime LastUpdatedAt, Currency[] Currencies);