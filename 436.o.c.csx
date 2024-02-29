
class Message {
	int		GroupOption;
	ushort	DataLength;
	[LengthFor("GroupName")]
	ushort	GroupNameLength;
	string	GroupName;
}