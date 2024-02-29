
class Mail {
	uint ID;
	byte u1;
	Time32 SendDate;
	uint u2;
	bool Read;
	string Sender;
	byte u0;
	uint u4;
	string Subject;
	uint u5;
}

class Message {
	uint u0;
	byte u1;
	[LengthFor("Mail")]
	byte Count;
	Mail[] Mail;
}