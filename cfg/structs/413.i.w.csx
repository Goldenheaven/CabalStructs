
class Skill {
	int CharacterId;
	bool IsDead;
	byte SkillRes;
	int  Damage;
	int  TargetRemainingHp;
	int  u0;
	int  u1;
	int  u2;
	byte u4;
}

class Message {
	int    MobId;
	bool   IsDefSkill;
	byte   u5;
	int    TargetHp;
	int    u6;
	[LengthFor("Skills")]
	ushort Count;
	public Skill[]  Skills;
}