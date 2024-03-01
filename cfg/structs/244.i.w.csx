
using Shared;

enum WorldType : uint {
	Normal,
	TG,
	Dungeon,
	War = 4,
}

class Message {
	ushort X;
	ushort Y;
	ulong XP;
	ulong OXP;
	ulong Alz;
	ObjectIndexData UserID;
	byte WarpType;
	uint u1;
	uint World;
	uint Dungeon;
	uint u2;
}