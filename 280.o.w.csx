
class ForceCoreSlot {
	int	InventorySlot;
}

class Message {
	int		ItemSlot;
	int		RandomOptionScrollSlot;
	int		FixedOptionScrollSlot;
	int		u0;
	byte	u1;
	[Length(10)]
	ForceCoreSlot[]	Slot;
}