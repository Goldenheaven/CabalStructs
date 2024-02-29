
using Shared;

enum Result : byte {
	Critical = 1,
	Success = 2,
	Blocked = 27
}

class Message {

	Result	Result;
	uint	CharacterId;
	ObjectIndexData	TargetId; 
	[Comment("Why is this even here? This will always	be 2...")]
	byte	TargetType;
	uint	TargetHP;
	bool	AttackerDamaged;
	uint	AttackerNewHP;
	int	AttackerDamageReceived;
}