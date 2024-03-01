
enum ResultType : byte {
	OK,
	Undefined,
	InvalidParameter,
	NotExist,
	InvalidRet,
	DatabaseFailure,
	TargetOffline,
	Refuse,
	AlreadyMember,
	Inviting,
	InvitingByOther,
	MaxMember,
	MaxMemberTarget
}

[Bitfield("Class", 3, "Nation", 3,"Rank",5,"Reserved",21)]
struct Remark {
	byte Value;
}

enum Switch : ushort {
	Empty = 0,
	Character
}

struct Empty {
	ushort DataLength;
}

struct Character {
	uint CharId;
	uint GroupId;
	byte u8;
	uint u1;
	byte Channel;
	byte World;
	byte u3;
	Remark Remark;
	byte Level;
	byte u9;
	[LengthFor("Name")]
	ushort NameLength;
	string Name;
}

class Message {
	ResultType	Type;
	[TypeFor("Characters")]
	Switch		ASwitch;
	//object		Characters;
}