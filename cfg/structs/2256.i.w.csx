
class Message {
	int		u0;
	int		CharacterId;
	byte	NameLength;
	[Length(17)]
	string	CharacterName;
	int		DiceResult;
}