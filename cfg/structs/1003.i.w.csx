using Shared.Item;

class EventString {
	public string String;
}

class PandoraRewardItem {
	uint Slot;
    ItemKind ItemKind;
    ulong ItemOption;
    byte DurationID;
	ulong AlzPrice;
	ushort TPointPrice;
	ushort FGPrice;
}

class UnknownData {
	uint u1;  
	uint u2;
	uint u3;
}

class SpecialItem
{
    ItemKind ItemKind;
	ulong ItemOption;
    uint Required;
}

class CollectEventItem {    
	uint Slot;
    ItemKind ItemKind;
    ulong ItemOption;
    byte DurationID;
	ulong AlzPrice;
	ushort TPointPrice;
	
	[LengthFor("SpecialItemList")]
	ushort SpecialItemPrice;
	SpecialItem[] SpecialItemList;
}

class MysteryBoxData {
	uint Slot;
	ulong AlzPrice;
	uint FGPrice;
	uint BoxType;
	uint PriceType;
	uint u0;
	ulong u1;
	[Length(24)]
	string Text;
}

class MysteryBoxItem {
	uint BoxId;
	ItemKind ItemKind;
	ulong Option;
	uint Serial;
	uint DurationId;
	double Rate;
	byte u0;
	uint u1,u2,u3;
}


	
class Overview {
	[LengthFor("EventStrings")]
	byte TextCount;
	byte PageCount;
	EventString[] EventStrings;
	uint u1;
	[LengthFor("CollectEventItems")]
	ushort ItemCount;
	CollectEventItem
	CollectEventItems;
}

class CollectEvent {
	uint SlotId;
	CollectEventItem IITem;
}

class PandoraEvent {
	[LengthFor("EventStrings")]
	ushort StringCount;
	EventString[] EventStrings;
	uint u1;	
	[LengthFor("CollectEventItems")]
	ushort ItemCount;
	CollectEventItem[] CollectEventItems;
	byte u2;
	string EventName;
	uint u3;
	byte u4;
	ushort u5;
	uint u6;
	[LengthFor("UnkData")]
	ushort UnkCount;
	[LengthFor("RewardItems")]
	ushort RewardCount;
	UnknownData[] UnkData;
	PandoraRewardItem[] RewardItems;
	ushort u7;
	byte u8;
}

	
class MysteryBoxName {
		uint BoxId;
		[Length(21)]
		string BoxName;
		uint u0;
}

class MysteryBox {
	byte u0;
	string BoxName;
	ushort u1;
	[LengthFor("MysteryBoxData")]
	ushort MysteryBoxDataCount;
	[LengthFor("MysteryBoxItems")]
	ushort MysteryBoxItemCount;
	[LengthFor("MysteryBoxNames")]
	ushort MysteryBoxCount;
	MysteryBoxData[] MysteryBoxData;
	MysteryBoxItem[] MysteryBoxItems;
	MysteryBoxName[] MysteryBoxNames;
	ushort u2;
	byte u3;
}

class ExchangeItem{
	ItemKind	UnkId1;
	ulong		UnkItemOption;
	byte		Nation;
	uint		ExternalID;
	uint		TextureID;
	ulong		Price;
	uint		PriceTPoint;
	ushort		PriceCash;
}

class ItemCost {
    ulong ItemID;
    ulong ItemOption;
    uint ItemCount;
}

class ItemShopItem {
	uint			SlotId;
	ItemKind		ItemID;
	ulong			ItemOption;
	byte			Nation;
	uint			LinkID;
	uint			TextureID;
	ulong			AlzPrice;
    ushort          u0;
    [LengthFor("ItemCost")]
	uint			ItemCostCount;
    ushort          u1;
	[Length(0)]
	ExchangeItem[]	ExchangeItems;
    ItemCost[]      ItemCost;
}

class Event {
	uint 			EventId;
	[LengthFor("EventStrings")]
	ushort 			StringCount;
	EventString[]	EventStrings;
	ushort			EventCounter1;
	ushort			EventCounter2;
	[LengthFor("ItemShopData")]
	ushort			ItemShopCounter;
	ItemShopItem[]	ItemShopData;
	byte			EventCounter3;
	ushort			BingoCounter;
    byte            BingoCounter2;
    byte            PeriodCounter;
    ushort          DungeonCount;
}

class Message {
	byte u0;
    [LengthFor("Events")]
	byte EventCount;
	uint u1;
	Event[] Events;
}