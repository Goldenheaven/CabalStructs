
class Message {
	byte	u0;
	int		MailId;
	[Length(28)]
	byte[]	unks;
	[LengthFor("Mail")]
	ushort	TextLength;
	public	string	Mail;
}