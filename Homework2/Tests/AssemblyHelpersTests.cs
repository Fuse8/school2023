namespace Fuse8_ByteMinds.SummerSchool.Tests;

public class AssemblyHelpersTests
{
	[Fact(DisplayName = "GetTypesWithInheritors корректно подсчитывает базовые классы и кол-во их наследников")]
	public void GetTypesWithInheritorsReturnsCorrectData()
	{
		var typesWithInheritors = AssemblyHelpers.GetTypesWithInheritors();

		Assert.Single(typesWithInheritors);
		var (baseTypeName, inheritorCount) = typesWithInheritors[0];
		Assert.Equal(expected: nameof(Animal), actual: baseTypeName);
		Assert.Equal(expected: 3, actual: inheritorCount);
	}
}