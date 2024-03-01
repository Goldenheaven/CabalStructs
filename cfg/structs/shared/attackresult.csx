enum AttackResult : byte {
	CriticalAttack = 1,
	NormalAttack = 2,
	MissingAttack = 3,
	MobDead = 4,
	BuffSuccess = 5,
	FailBuff = 16,
	CriticalFailBuff = 17,
	NormalAttackFailBuff = 18,
	MissingAttackFailBuff = 19,
	FailBuffEnchantMode = 20,
	FailDuestunning = 21,
	FailureDueHP = 22,
	DiffWorld = 23,
	TargetError = 24,
	DamageAbsorbed = 25,
	Miss = 26,
	Block = 27
}