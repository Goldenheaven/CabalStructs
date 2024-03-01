
[Flags]
enum CharGameState : ushort {
	None,
	PresenceStatus,
	Channel,
	World			= 0x04,
	CharacterLevel	= 0x08,
	ChatServerID	= 0x10,
	CharacterNation	= 0x20,
	Dungeon			= 0x40
}

class Message {
	uint CharId;
	CharGameState ChangeFlag;
	byte PresenceStatus;
	byte Channel;
	byte World;
	ushort Dungeon;
	ushort Level;
	byte Nation;
	byte u0;
	byte u1;
}