
class Mail {
	uint ID;
	Time64 SendDate;
	string Recipient;
	[Length(3)]
	byte[] ItemData;
	string Subject;
	ulong u2;
	ulong u3;
	ulong u4;
	ulong u5;
	byte u6;
}

class Message {
	uint u0;
	byte u1;
	[LengthFor("Mail")]
	byte Count;
	public Mail[] Mail;
}