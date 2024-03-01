using Shared.Item;

enum Result : byte {
	Success = 96,
	NotOwner,
	TooLate,
	SlotAlreadyInUse,
	AntiOnline,
	OutofRange
}

class Message {
	Result		Result;
	ItemKind	Kind;
	ulong		Option;
	int			Slot;
	ushort		u0;
}