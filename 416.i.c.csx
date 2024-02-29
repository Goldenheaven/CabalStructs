
class Message {
	int		GuildId;
	int		GuildMasterId;
	ushort	u0;
	int		u1;
	int		u2;
	ushort	u3;
	ushort	DataLength;
	[LengthFor("GuildName")]
	ushort	GuildNameLength;
	string	GuildName;
	[LengthFor("GuildNotice")]
	ushort	GuildNoticeLength;
	string	GuildNotice;
	[LengthFor("GuildWelcome")]
	ushort	GuildWelcomeLength;
	string	GuildWelcome;
	[LengthFor("GuildWeb")]
	ushort	GuildWebLength;
	string	GuildWeb;
}