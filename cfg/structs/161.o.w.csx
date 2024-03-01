using Shared.Item;

class Message {
	byte		NPCId;
	int			ShopId;
	ushort		SlotId;
	ItemKind	Kind;
	long		Option;
	/* Why is this here twice? */
	ushort		SlotId2;
	int			u1;
	int			u2;
	int			u3;
	[Length(533)]
	int[]		Junk;
	int			DestinationSlot;
}