
class Message {
	[LengthFor("data")]
	ushort	length;
	byte[] data;
}