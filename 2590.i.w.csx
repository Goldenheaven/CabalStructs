
class Player {
	byte	Server;
	int		CharacterId;
	int		u3;
	int		u4;
	int		WeeklyPoints;
	byte	Level;
	int		WeeklyPoints1;
	byte	Nation;
	byte	u9;
	byte	NameLength;
	[Length(16)]
	string	CharacterName;
	int		WinCount;
	int		DeathCount;
}

class Message {
	int		u0;
	[Length(4)]
	Player[]	Players;
}