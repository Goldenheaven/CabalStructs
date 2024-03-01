using Shared;
using Shared.Item;

struct SoldItem {
	ItemKind	Kind;
    uint		u0;
    ulong		Option;
    ulong		Price;
	int			Slot;
	Period		Duration;
	byte		u1;
	/* The date and time (minus seconds) that this item was sold */
	Time64		SellDate;
}

class Message {
	[LengthFor("Items")]
	byte Count;
	SoldItem[] Items;
}