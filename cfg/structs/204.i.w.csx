using Shared;
using Shared.Item;

enum ItemContextType : byte {
	None,
	ItemFromMobs,
	ItemFromUser,
	TrapFromMobs,
	TrapFromUser
} 

class Item {
	ObjectIndexData	Id;
	ulong			Option;
	uint			FromId;
	ItemKind		Kind;
	ushort			X;
	ushort			Y;
	ushort			Key;
	ItemContextType	Type;
	byte			u0;

	
}

class Message {
	[LengthFor("Items")]
	byte		Count;
	Item[]		Items;
}