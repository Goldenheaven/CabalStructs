
class Message {
	ushort DataLength;
	[LengthFor("Name")]
	ushort NameLength;
	string Name;
}