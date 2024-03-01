
enum ChangeType : byte {
	AutoTrap = 2,
	GuildWin,
	NationKill,
	MobKill,
	GuildKill
}


class Message {
	ChangeType Type;
	ulong HonorGained;
}