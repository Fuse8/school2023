namespace Fuse8_ByteMinds.SummerSchool.Tests.TestData;

public static class AnimalTestData
{
	public static readonly IEnumerable<object[]> AllDogData =
		new[]
		{
			new object[] { new Husky() },
			new object[] { new Chihuahua() },
		};

	public static readonly IEnumerable<object[]> AnimalsWithSmallWeight =
		new[]
		{
			new object[] { new Fox() },
			new object[] { new Chihuahua() },
		};

	public static readonly IEnumerable<object[]> AllAnimalData =
		new[]
		{
			new object[] { new Husky() },
			new object[] { new Fox() },
			new object[] { new Chihuahua() },
		};
}