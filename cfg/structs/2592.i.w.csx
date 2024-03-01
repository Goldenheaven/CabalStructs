
class Room {
	byte	u1;
	int		u2;
	[Length(42)]
	string	RoomName;
	int		u3;
	int		u4;
	bool	NoItemMode;
	bool	SpectatorMode;
	bool	BattleMode;
	int		u8;
	int		u9;
	int		u10;
	byte	u11;
	ushort	u12;
	byte	u13;
	byte	u14;
	byte	u15;
	
}

class Message {
	[LengthFor("Rooms")]
	int		RoomCount;
	Room	Rooms;
}