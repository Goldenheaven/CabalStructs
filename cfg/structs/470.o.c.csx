
class Message {
	uint CharId;
	ushort DataLength;
	[LengthFor("Memo")]
	ushort MemoLength;
	string Memo;
}