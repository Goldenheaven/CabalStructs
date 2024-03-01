using Shared;

public enum Target {
		Player = 1,
		Mob = 2
	}

class Message {
	Target TargetType;
	ObjectIndexData Type;
	int 	u1;
	int u2;
	int SkillId;
}