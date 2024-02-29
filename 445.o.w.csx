
class Message {
	int    GuildId;
	int    CharacterId;
	ushort DataLength;
	[LengthFor("GuildName")]
	ushort GuildNameLength;
	string GuildName;
}