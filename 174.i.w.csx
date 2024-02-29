using Shared;

class Mob {
    ObjectIndexData ID;
    byte Type;
    byte AttackResult;
    uint DamageReceived;
    ulong AttackerHP;
    uint HpLeft;
    uint u9;
    byte u10;
}

class Message {
	ushort SkillID;
    int HP;
	int MP;
    ushort SP; 
    long XP;
    uint u0;
	ushort AXP;
    ushort u1;
    ushort MP2;
    [Length(32)]
    byte[] UnknownBytes;
    int u2;
    byte u3;
	int HP2;
    int u4;
    [LengthFor("Mobs")]
	byte MobCount;
    public Mob[] Mobs;
}