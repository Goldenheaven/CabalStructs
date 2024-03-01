
enum ExpirationDate : byte {
	OneDay = 1,
	ThreeDays,
	SevenDays
}

class Message {
	int		u0;
	int		InventorySlot1stItem;
	int		u1;
	int		InventorySlot2ndItem;
	ExpirationDate Date;
}