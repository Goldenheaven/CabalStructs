
enum MessageType : byte { 
	Normal,
	LoginDuplicate,
	ForceDisconnect,
	Shutdown,
	ShutdownNoNotice,
	War_Capella,
	War_Procyon,
	Normal2 = 9
}

class Message {
	MessageType	MessageType;
	[LengthFor("Text")]
	ushort	Length;
	string	Text;
}