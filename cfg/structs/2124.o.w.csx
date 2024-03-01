
class Message {
	int		u0;
	[Length(17)]
	string	RecipientName;
	ulong	AttachedAlz;
	int		AttachedItem;
	[Length(41)]
	string	MailTitle;
	[LengthFor("Message1")]
	ushort	MessageLength;
	string	Message1;
}