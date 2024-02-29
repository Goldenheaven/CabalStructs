
struct Unk {
	short	Id;
	int		ItemId;
	int		Option;
	byte	u0;
	byte	u1;
	ushort	u2;
	int		u3;
	int		u4;
	byte	u5;
	ushort	u6;
}

class Message {
	[LengthFor("u0")]
	ushort	Count;
	Unk[]	u0;
}