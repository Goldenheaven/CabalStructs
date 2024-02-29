
class Message {	
	[LengthFor("Name")]
	int		NameLength;
	[LengthFor("GuildName")]
	int		GuildNameLength;
	string	Name;
	string	GuildName;
}