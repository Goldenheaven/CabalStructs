
class Message {
	byte	u0;
	int		CharacterId;
	byte	Channel;
	byte	CharacterType;
	int		Level;
	byte	NameLength;
	[Length(16)]
	string Name;
}