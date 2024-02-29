using Shared;

class Target {
	int  TargetId;
	ObjectType Type;
	byte u1;
	int  u2;
	ushort u4;
	byte   u5;
	[Length(18)]
	byte[] u6;
}

class Message {
	ushort SkillId;
	ushort u7;
	byte   SkillLevel;
	ushort u8;
	[LengthFor("Targets")]
	byte   TargetCount;
	byte   u9;
	int    u10;
	ushort u11;
	byte   u12;
	int    HpAfterBuff;
	int    MpAfterBuff;
	int    u6;
	Target[] Targets;
}