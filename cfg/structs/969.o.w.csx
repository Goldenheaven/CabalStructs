
class Message {
	int		SellerId;
	byte	ItemAmount;
	byte	u2;
	[Length(23)]
	byte[]	Padding;
	ulong	Price;
	string	ItemName;
	[Length(45)]
	byte[]	unks;
	int		u4;
	ushort	u3;
	ushort	InventorySlot;
}