
class Message {
	int		CharId;
	ushort	DataLength;
	[LengthFor("Name")]
	ushort	NameLength;
	string	Name;
	byte	Level;
	int		u0;
}