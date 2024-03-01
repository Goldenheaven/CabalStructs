
class Message {
	int		CharacterId;
	int		u0;
	int		u1;
	byte	u2;
	[LengthFor("ShopName")]
	byte	ShopNameLength;
	string	ShopName;
}