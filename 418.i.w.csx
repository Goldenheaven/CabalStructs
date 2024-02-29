
struct Item {
	ushort	Id;
	/* WTF is going on here? How is this a ushort? O_O Kind is *always* long. */
	ushort	Kind;
	ushort	Option;
	byte	DurationId;
	byte	GiftId;
	int		u0;
	int		u1;
	int		u2;
	byte	u3;	
}

class Message {
	[LengthFor("Items")]
	int		Count;
	Item[]	Items;
}