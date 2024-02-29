using Shared.Item;

class Player {
	byte	Rank1;
	byte	Rank2;
	int		CharId;
	int		Record;
	ushort	u1;
	byte	NameLength;
	[Length(16)]
	string	Name;
}

class PartyPlayer {
	byte	Rank1;
	byte	Rank2;
	int		CharId;
	int		Record;
	byte	NameLength;
	[Length(16)]
	string Name;
}

class Party {
	[Length(8)]
	public  PartyPlayer[]	PartyMember;
}

class Message {
	int			u0;
	Time32		DungeonRecord;
	[Length(29)]
	byte[] 		unks;
	[Length(30)]
	Player[]	Players;
	[Length(20)]
	Party[]		Parties;
}