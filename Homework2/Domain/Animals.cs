namespace Fuse8_ByteMinds.SummerSchool.Domain;

/// <summary>
/// Животное
/// </summary>
public abstract class Animal
{
	/// <summary>
	/// true - если животное является другом человека
	/// </summary>
	public virtual bool IsHumanFriend => false;

	/// <summary>
	/// true - если у животного большой вес
	/// </summary>
	public abstract bool HasBigWeight { get; }

	/// <summary>
	/// Как говорит животное
	/// </summary>
	/// <returns>Возвращает звук, который говорит животное</returns>
	public abstract string WhatDoesSay();
}
// TODO В наследниках реализовать метод WhatDoesSay и свойство HasBigWeight, а также переопределить IsHumanFriend там, где это нужно

/// <summary>
/// Собака
/// </summary>
public abstract class Dog : Animal
{
}

/// <summary>
/// Лиса
/// </summary>
public class Fox : Animal
{
}

/// <summary>
/// Чихуахуа
/// </summary>
public class Chihuahua : Dog
{
}

/// <summary>
/// Хаски
/// </summary>
public class Husky : Dog
{
}