using Fuse8_ByteMinds.SummerSchool.Tests.TestData;
using static Fuse8_ByteMinds.SummerSchool.Tests.TestData.AnimalTestData;

namespace Fuse8_ByteMinds.SummerSchool.Tests;

public class AnimalTests
{
	[Theory(DisplayName = "Все животные что то говорят")]
	[MemberData(memberName: nameof(AllAnimalData), MemberType = typeof(AnimalTestData))]
	public void AllAnimalsSayAnything(Animal animal)
	{
		Assert.NotEmpty(animal.WhatDoesSay());
	}

	[Theory(DisplayName = "Все собаки говорят 'гав'")]
	[MemberData(memberName: nameof(AllDogData), MemberType = typeof(AnimalTestData))]
	public void AllDogsSayWoof(Dog dog)
	{
		Assert.Equal(expected: "гав", actual: dog.WhatDoesSay());
	}

	[Fact(DisplayName = "Хаски говорят 'ауф'")]
	public void HuskySaysWoo()
	{
		Assert.Equal(expected: "ауф", actual: new Husky().WhatDoesSay());
	}

	[Fact(DisplayName = "Лиса говорит 'ми-ми-ми'")]
	public void FoxSaysMiMiMi()
	{
		Assert.Equal(expected: "ми-ми-ми", actual: new Fox().WhatDoesSay());
	}

	[Theory(DisplayName = "Все собаки являются друзьями людей")]
	[MemberData(memberName: nameof(AllDogData), MemberType = typeof(AnimalTestData))]
	public void AllDogsAraHumanFriends(Dog dog)
	{
		Assert.True(dog.IsHumanFriend);
	}

	[Fact(DisplayName = "Лиса НЕ является другом человека")]
	public void FoxIsNotHumanFriends()
	{
		Assert.False(new Fox().IsHumanFriend);
	}

	[Fact(DisplayName = "У Хаски большой вес")]
	public void HuskyHasBigWeight()
	{
		Assert.True(new Husky().HasBigWeight);
	}

	[Theory(DisplayName = "У всех животных, кроме Хаски, маленький вес")]
	[MemberData(memberName: nameof(AnimalsWithSmallWeight), MemberType = typeof(AnimalTestData))]
	public void AllAnimalsExceptHuskyHasSmallWeight(Animal animal)
	{
		Assert.False(animal.HasBigWeight);
	}
}