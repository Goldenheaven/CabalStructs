
class Item {
	byte	ShopSlot;
	byte	InventorySlot;
	byte	u3;
	ulong	Price;
	byte	Id;
	[Length(15)]
	byte[]	unks;
}

class Message {
	ushort	u0;
	byte	u1;
	[LengthFor("Items")]
	byte	ItemAmount;
	[LengthFor("ShopName")]
	byte	ShopNameLength;
	public	Item[]	Items;
	string	ShopName;
}