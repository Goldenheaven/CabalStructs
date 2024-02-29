
class AuctionItem {
	byte Slot;
	ulong ItemId;
	ulong ItemOpt;
	int u3;
	ushort RegistrationQuantity;
	int u4;
	long Price;
	ushort SoldAmount;
	Time64 ExpireDate;
	Time64 RegDate;
}


class Message {
	byte u0;
	[LengthFor("Auctions")]
	byte SalesCount;
	public AuctionItem[] Auctions;
}