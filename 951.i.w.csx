using Shared.Item;

enum UpgradeResult : byte {
	Upgrade_1 = 1,
	Downgrade_1 = 4
}

class Message {
	UpgradeResult	Result;
	ItemKind		ItemKind;
	/* Verify this */
	ulong			ItemOption;
	int				u0;
	byte			u1;
	uint			Serial_Maybe;
	int				u2;
}