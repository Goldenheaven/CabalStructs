
struct Service {
	ushort	u0;
	uint	DurationServiceID;
	uint	Type;
	uint	u1;
	ushort	u2;
	ushort	u3;
	int		XP;
	int		SkillXP;
	int		DropRate;
	int		AlzBomb;
	int		WarXP;
	int		PetXP;
	int		AXP;
	int		TPointUp;
	int		AlzRate;
	int		BoxDropRate;
	int		InventoryIII;
	int		InventoryIV;
	int		Warehouse;
	int		CostumeWarehouse;
	int		ExtendPetSlot;
	int		SkillXPTDummy;
	int		GPSWarp;
	byte	FreeWarp;
	ushort	AuctionHouseItemBonusSlots;
	ushort	AuctionHouseItemBonusQuantity;
	ushort	AuctionHouseItemBonusPeriod;
	int		AuctionHouseFeeExemption;
	ushort	SpecialInventory;
	byte	PremiumDungeonReward;
	short	RemoteShop;
	int		CraftMasteryUp;
	int		RequestAmityUp;
	byte	RequestAmitySlots;
	int		Reserved2;
	int		u4;
}

class Message {
	byte		u0;
	[LengthFor("Services")]
	uint		Count;
	Service[]	Services;
}