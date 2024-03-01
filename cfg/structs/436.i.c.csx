
class Message {
	int		GuildId;
	int		GroupId;
	byte	u0;
	int		GroupOptions;
	ushort	DataLength;
	[LengthFor("GroupName")]
	ushort	GroupNameLength;
	string	GroupName;
}