
struct Unk  {
	int	u0;
	int	u1;
	int	u2;
}

class Message {
	[LengthFor("u0")]
	short	Count;
	Unk[]	u0;
}