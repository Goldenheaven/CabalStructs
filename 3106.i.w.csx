
class Message {
	bool	RecipientExists;
	[Length(3)]
	byte[]	Padding;
	int		CharacterId;
	int		Level;
	ushort	u0;
	ushort	u1;
}