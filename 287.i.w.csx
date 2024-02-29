
class Message {
	[TypeFor("Data")] 
	DataType Type;
	object Data;

	enum DataType : byte {
		HpPotion = 1,
		MpPotion,
		HpRegen,
		MpRegen,
		XPGain,
		// SpInc,
		// SpDec,
		// Exp, 
		// Rank,
		// Level,
		// SpDecEx,
		// BuffPotion,
		// Reputation,
		// ItemFx,
		// Ressurection,
		// PenaltyExp,
		// DamageCell,
		// Deficiency,
		// AutoHpPotion,
		// Rage
	}
	
	struct HpPotion {
		int		u0;
		int		u1;
		int		u2;
		ushort	u3;
		int		CurrentHp;
		byte	u4;
	}

	struct MpPotion {
		int		u0;
		int		u1;
		int		u2;
		ushort	u3;
		int		CurrentMp;
		int		u4;
	}

	struct HpRegen {
		ulong	u0;
		ulong	u1;
		int		u2;
		ushort	u3;
		int		u4;
		int		u5;
		int		RegenHp;
	}

	struct MpRegen {
		ulong	u0;
		ulong	u1;
		int		u2;
		ushort	u3;
		int		u4;
		int		RegenMp;
		int		u5;
	}

	struct XPGain {
		int		u0;
		int		u1;
		int		u2;
		ushort	u3;
		int		CurrentXP;
		int		u4;
	}
}