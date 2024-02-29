
class Player {
	int		CharacterId;
	byte	u4;
	byte	u5;
	byte	u6;
	byte	u7;
	byte	u8;
	int		Rating;
	int		Level;
	ushort	u9;
	byte	u10;
	byte	NameLength;
	[Length(16)]
	string	CharacterName;
	int		WinCount;
	int		DeathCount;
}


class Message {
	int		u0;
	[Length(100)]
	Player[]	Players;
}