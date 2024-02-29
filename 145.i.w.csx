using Shared;
using Shared.Item;

class Item {
    ItemKind Kind;
    uint Serial;
    ulong Option;
    ushort Slot;
    Period Duration;
}

class Message {
	[LengthFor("Items")]
	ushort ItemCount;
	ulong DepositedAlz;
	Item[] Items;
}