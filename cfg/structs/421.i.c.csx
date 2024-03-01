
enum Result : ushort {
	UserDoesNotExist = 4,
	InvitationTimedOut = 16,
	NotUsed1,
	NotUsed2,
	InvitationCancelled
}

class Message {
	Result	Reason;
	byte    u0;
	int     CharacterId;
	int     u1;
	int     u2;
	ushort  u3;
	ushort  u4;
	byte    u5;
	byte    Channel;
	byte    Map;
	byte    u6;
	int     u7;
	byte    u8;
	byte    u9;
	[LengthFor("Name")]
	ushort   NameLength;
	string   Name;
}