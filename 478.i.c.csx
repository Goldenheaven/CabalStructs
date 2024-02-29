
class Message {
	ushort u1;
	byte   u6;
	int    CharacterId;
	int    u0;
	byte   u2;
	byte   u3;
	byte   u4;
	byte   u5;
	byte   u7;
	byte   Channel;
	ushort u8;
	int    u9;
	byte   Level;
	byte   u10;
	[LengthFor("Name")]
	ushort  NameLength;
	string Name;
}