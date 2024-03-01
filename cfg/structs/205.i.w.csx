using Shared;

enum DeleteType : byte {
	Dead = 0x10,
	Warp,
	Logout,
	Return,
	Disappear,
	NfsDead
}

class Message {
	ObjectIndexData	Id;
	DeleteType		Type;
}