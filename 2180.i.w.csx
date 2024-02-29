

class Message {
	ushort PoolID;
	[LengthFor("ItemList")]
	ushort ItemCount;
	Item[] ItemList;	
	
	class Item {
		ushort ServerPoolID;
		ushort SlotID;
		ulong ItemID;
		ulong ItemOption;
		uint DurationID;
		sbyte MinimumLevel;
		sbyte MaximumLevel;
		byte GuildLevel;
		sbyte MinimumReputation;
		sbyte MaximumReputation;
		byte PremiumOnly;
		byte WinningOnly;
		ulong AlzPrice;
		ulong WExpPrice;
		ushort APPrice;
		uint DPPrice;
		uint Cash;
		ushort SpecialItemPrice;
		uint ForceGemPrice;
	}
}