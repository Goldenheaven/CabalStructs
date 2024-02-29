
struct Unk {
	int		u0;
	int		u1;
	int		u2;
	int		u3;
	byte	u4;
	int		u5;
}

class Message {
	[LengthFor("u1")]
	int		Count;
	int		u0;
	Unk[]	u1;
	int		u2;
	int		u3;
	int		u4;
	int		u5;
	int		u6;
}