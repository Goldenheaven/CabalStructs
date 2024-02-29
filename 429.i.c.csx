
class Message {
	ushort   u0;
	ushort DataLenght;
	[LengthFor("GuildNotify")]
	ushort GuildNotifyLength;
	string GuildNotify;
	[LengthFor("GuildIntro")]
	ushort GuildIntroLength;
	string GuildIntro;
	[LengthFor("GuildHomePage")]
	ushort GuildHomePageLength;
	string GuildHomePage;
}