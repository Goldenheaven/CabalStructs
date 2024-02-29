using Shared;
using Shared.Item;

class CashItem {
	public ushort Slot;
	public ItemKind Kind;
	public ulong Option;
	public Period Duration;
	public byte MinimumLevel,
	 	MaximumLevel,
		MinimumGuildLevel;
	public sbyte MinimumHonourRank,
		MaximumHonourRank;
	public bool PremiumOnly,
		WinningOnly,
		UnknownOnly;
	public uint Cash, 
		SpecialItemPrice,
		ForceGems,
		Marker;
	[Length(49)]
	public byte[] Reserved;
}

class Message {
	public ushort PageMarker,
		PageNumber;
	[LengthFor("Items")]
	public ushort ItemCount;
	public CashItem[] Items;
}