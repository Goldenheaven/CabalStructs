
struct Shop {
	short	World;
	short	u0;
	byte	NPCId;
	short	ShopId;
	byte	u1;
}

class Message {
	[LengthFor("Shops")]
	short	Count;
	Shop[]	Shops;
}