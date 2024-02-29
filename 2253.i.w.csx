class Achievement{
	int u1;
	int u2;
	int CharacterID;
	ushort AchievementID;
	Time64 AchievedOn;
	string CharacterName;
}

class Achievement2{
	int u1;
	int CharacterID;
	ushort AchievementID;
	Time64 AchievedOn;
	string CharacterName;
}


class Message {
	ulong u0;
	[LengthFor("Achievements2",Operator.Sub,12)]
	int Count;
	int BestCharacterID;
	int BestCharacterPoints;
	[Comment("?")]
	int MyPoints;
	[Length(12)]
	Achievement[] Achievements;
	Achievement2[] Achievements2;
}