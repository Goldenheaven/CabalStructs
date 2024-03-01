
enum SlotType {
	Inventory,
	Equipment,
	Warehouse
}

class Message {
	SlotType	FromType;
	int			FromSlot;
	SlotType	ToType;
	int			ToSlot;
	short		u0;
	short		u2;
	int			u3;
	int			u4;
}