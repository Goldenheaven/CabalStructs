
using Shared;
using Shared.Item;

[Bitfield("Padding",4,"Slots1",4)]
struct Slots {
	ushort Value; 
}

class AuctionItem {
	byte RegisterOrder;			
	ItemKind ItemId;
	long u0;
	short u1;
	Slots Slots; 
	short SaleAmount;
	int u2;
	long SalePrice;
	Period u3;
	[LengthFor("Name")]
	byte NameLength;
	string Name;
	[LengthFor("GuildName")]
	byte GuildNameLength;
	string GuildName;
}

class Message {
	int u0;
	byte u1;
	[LengthFor("Sales")]
	short SalesCount;
	AuctionItem[] Sales;
}