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

class Event {
	uint EventId;

	int GetEventType(){
		if( EventId==157 || EventId==158 )
			return (int)EventType.CollectEvent;
		else if( EventId == 153 )
			return (int)EventType.PandoraEvent;

		return (int)EventType.Overview;
	}
	
	enum EventType {
		MysteryBox,
		CollectEvent,
		PandoraEvent,
		Overview
	}
	
	class Overview {
	
	}

	class CollectEvent {
		[LengthFor("EventStrings")]
		ushort StringCount;
		EventString[] EventStrings;
		uint u1;	
		[LengthFor("CollectEventItems")]
		ushort ItemCount;
		CollectEventItem[] CollectEventItems;
		uint u2;	
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
	
	[Variant(typeof(EventType), "GetEventType")]
	object EventData;
	
}

class Message {
	byte u0;
	[LengthFor("Events")]
	byte EventCount;
	uint u1;
	Event[] Events;
}