
struct Reward {
	int		SpecialInventorySlot;
	ushort	ItemId;
	ushort	u6;
	int		u7;
	ulong	ItemAmount;
	byte	u9;
}

class Message {
	int			u0;
	int			u1;
	[LengthFor("Rewards")]
	int			RewardCount;
	Reward[]	Rewards;
	[LengthFor("NextRewards")]
	int			NextRewardCount;
	Reward[]	NextRewards;
}