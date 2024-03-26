
class Message {
	[TypeFor("Data")] 
	DataType Type;
	object Data;

	enum DataType : byte {
		HpPotionData = 1,
		MpPotionData = 2,
		HpData = 3,
		MpData = 4,
        SpData = 5,
        SpIncData = 6,
        SpDecData = 7,
        ExpData = 8,
        RankData = 9,
        LevelData = 10,
        SpDecExData = 11,
        BuffPotionData = 12,
        ReputationData = 13,
        ItemFxData = 14,
        ResurrectionData = 15,
        PenaltyExpData = 16,
        DamageCellData = 17,
        DefficiencyData = 18,
        AutoHpPotionData = 19,
        RageData = 20,
        Unknown1Data = 21,
        OverlordLevelData = 22,
	}
	
	class HpPotionData {
        [Length(34)]
        byte[] Padding0;
        ulong HpAfterPotion;
        [Length(4)]
        byte[] Padding1;
	}

	class MpPotionData {
        [Length(34)]
        byte[] Padding0;
		int		Mp;
        [Length(8)]
        byte[] Padding1;
	}

	class HpData {
        [Length(38)]
        byte[] Padding0;
		ulong Hp;
	}

	class MpData {
        [Length(34)]
        byte[] Padding0;
		int		Mp;
        [Length(8)]
        byte[] Padding1;
	}

	class SpData {
        [Length(34)]
        byte[] Padding0;
		int		Sp;
        [Length(8)]
        byte[] Padding1;
	}

    class SpIncData {
        [Length(46)]
        byte[] Padding0;
    }

    class SpDecData {
        [Length(46)]
        byte[] Padding0;
    }

    class ExpData {
        [Length(46)]
        byte[] Padding0;
    }

    class RankData {
        [Length(46)]
        byte[] Padding0;
    }

	class LevelData {
        [Length(34)]
        byte[] Padding0;
		int		Level;
        [Length(8)]
        byte[] Padding1;
	}
    
    class SpDecExData {
        [Length(46)]
        byte[] Padding0;
    }

    class BuffPotionData {
        [Length(46)]
        byte[] Padding0;
    }

    class ReputationData {
        [Length(46)]
        byte[] Padding0;
    }

    class ItemFxData {
        [Length(46)]
        byte[] Padding0;
    }

    class ResurrectionData {
        [Length(46)]
        byte[] Padding0;
    }

    class PenaltyExpData {
        [Length(46)]
        byte[] Padding0;
    }

    class DamageCellData {
        [Length(46)]
        byte[] Padding0;
    }

    class DefficiencyData {
        [Length(46)]
        byte[] Padding0;
    }

    class AutoHpPotionData {
        [Length(46)]
        byte[] Padding0;
    }

	class RageData {
        [Length(34)]
        byte[] Padding0;
		int		Rage;
        [Length(8)]
        byte[] Padding1;
	}
    
    class Unknown1Data {
        [Length(46)]
        byte[] Padding0;
    }

    class OverlordLevelData {
        [Length(34)]
        byte[] Padding0;
		int		Level;
        [Length(8)]
        byte[] Padding1;
    }
}