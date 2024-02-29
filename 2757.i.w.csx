
class Player {
	int		RankingPlace;
	byte	u3;
	ushort	Level;
	[Length(16)]
	string	Name;
	int		Score;
	
}

class Message {
	byte	u0;
	[LengthFor("PlayerList")]
	byte	PlayerCount;
	Player[]	PlayerList;
}