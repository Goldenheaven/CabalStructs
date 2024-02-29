
class Message {
	ushort	u0;
	int		GuildId;
	int		CharacterId;
	[LengthFor("GuildName")]
	ushort	GuildNameLength;
	string	GuildName;
}