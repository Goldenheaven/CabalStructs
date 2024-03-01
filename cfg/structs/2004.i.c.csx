using Shared.Item;

enum ResultType {
	OK,
	Blocked = 2
}


class Message {
	ResultType Result;
	[Length(17)]
	string Name;
	ushort Level;
	ushort u0;
	byte Class;
	uint AttackPower;
	uint DefencePower;
	[LengthFor("Equipment")]
	byte EquipmentCount;
	Item[] Equipment;
}