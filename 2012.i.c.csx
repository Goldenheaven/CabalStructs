
class Message {
	/*buddy = 0, guild 1*/
	int Type;
	uint CharId;
	[LengthFor("Length")]
	ushort Length;
	string Msg;
	short u0;
}