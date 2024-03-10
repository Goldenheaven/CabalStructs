
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
	int		InventoryV;
	int		InventoryVI;
	int		InventoryVII;
	int		InventoryVIII;
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
	int		u5;
	int		u6;
	int		u7;
	int		u8;
	int		u9;
	int		u10;
	int		u11;
	int		u12;
	int		u13;
}

class Message {
	byte		u0;
	[LengthFor("Services")]
	uint		Count;
	Service[]	Services;
}