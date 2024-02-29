
class Target {
	int u0;
	int u1;
	int TargetId;
	byte TargetType;
	int Result;
}

class Message {
	int    CharacterId;
	ushort SkillId;
	ushort u0;
	byte   SkillLevel;
	byte   u1;
	int    u2;
	byte   u3;
	int    u4;
	[LengthFor("Targets")]
	byte   TargetCount;
	int    u5;
	int    u6;
	Target[] Targets;
}