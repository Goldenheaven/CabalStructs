using Shared.Item;

struct SpecialCost {
	short		Id;
	ItemKind	Kind;
	long		Option;
	int			Count;
}

class Message {
	[LengthFor("Costs")]
	ushort			Count;
	SpecialCost[]	Costs;
}