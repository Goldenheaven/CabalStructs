using Shared.Item;

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
	
class MysteryBoxName {
	uint BoxId;
	[Length(21)]
	string BoxName;
	uint u0;
}
	

class Message {
	byte u0;
	uint u1;
	uint EventId;
	byte u2;
	[Length(21)]
	string BoxName;
	[LengthFor("MysteryBoxData")]
	ushort MysteryBoxDataCount;
	[LengthFor("MysteryBoxItems")]
	ushort MysteryBoxItemCount;
	[LengthFor("MysteryBoxNames")]
	ushort MysteryBoxCount;
	MysteryBoxData[] MysteryBoxData;
	MysteryBoxItem[] MysteryBoxItems;
	MysteryBoxName[] MysteryBoxNames;
}