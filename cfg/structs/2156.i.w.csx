using Shared.Item;

class Message {
	bool IsSpecialCharacter;
	[Length(30)]
	ShortItemKind[] items;
}