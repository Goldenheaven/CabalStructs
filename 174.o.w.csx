using Shared;

class Mob {
    ObjectIndexData ID;
    byte Type;
    byte u4;
    byte u5;
}

class Message {
	ushort SkillID;
    byte Slot;
    uint u0;
    ushort PositionX;
    ushort PositionY;
    byte u1;
    uint u2;
	[LengthFor("Mobs")]
    byte MobAmount;
    ushort FromX;
    ushort FromY;
    ushort ToX;
    ushort ToY;
    public Mob[] Mobs;
}