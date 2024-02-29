using Shared;

enum Result : byte {
	Critical = 1,
	Success = 2,
	Blocked = 27
}

class Message {
	ObjectIndexData	TargetId;
	byte	TargetType;
	int		AttackerHP;
	int		AttackerMP;
	ushort	AttackerSP;
	Result	Result;
	ulong 	XPEarned;
	ulong	OXP;
	int		Damage;
	ulong	TargetHP;
	ushort	AXP;
	bool	AttackerDamaged;
	uint	AttackerNewHP;
	int		AttackerDamageReceived;
}