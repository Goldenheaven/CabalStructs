
class Message {
	uint CharacterId;
	uint u0;
	ushort Type;
	ushort DataLength;
	[LengthFor("Sender")]
	ushort SenderLength;
	string Sender; 
	[LengthFor("Message1")]
	ushort MessageLength;
	string Message1;
}