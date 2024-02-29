
class ChatMacro {
	[LengthFor("Macro")]
	public byte Length;
	public string Macro;
}

class Message {
	int    DataLength;
	[Length(10)]
	ChatMacro[] Text;
}