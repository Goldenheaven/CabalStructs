using Shared.Item;

class EventItem {
	ItemKind	ItemKind;
	ulong		ItemOption;
	uint		ExternalID;
	uint		TextureItemID;
	string		ItemName;
	string		ItemDescription;
}

class Event {
	uint			EventID;
	uint			EventType;
	uint			UseFlag;
	Time64			StartDate;
	Time64			EndDate;
	uint			u0;
	uint			u1;
	uint			WorldID;
	uint			NpcID;
	[Length(32)]
	uint[]			u2;
    ushort          u3;
    uint            u4;
    ulong           u5;
	string			EventName;
	[LengthFor("Items")]
	ushort			Count;
	EventItem[]		Items;
	uint			u6;
}

class Message {
	[TypeFor("Data")]
	DataType	Type;
	object		Data;

	enum DataType : byte {
		NoEvent,
		ActiveEvent
	}

	class NoEvent {}

	class ActiveEvent {
		[LengthFor("Events")]
		byte	Count;
		Event[]	Events;
	}
}
