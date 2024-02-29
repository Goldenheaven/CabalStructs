
enum SlotType : int {
	Inventory,
	Equipment,
	Warehouse
}

class Message {
	SlotType	FromType;
	int		FromSlot;
	ushort	u0;
	ushort 	u1;
	int		u2;
	int		u3;
}