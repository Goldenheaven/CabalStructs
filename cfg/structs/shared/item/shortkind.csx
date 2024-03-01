
[Bitfield(
	"IdLow",				12,
	"BindToAccount",		1,
	"UpgradeLevel", 		5,
	"PremiumPcOnly",		1,
	"BindToCharacter",		1,
	"BindOnEquip",			1,
	"Reserved0",			3,
	"SpecialInventoryItem",	1,
	"IdHigh",				1,
	"SpecialBit",			1,
	"IsBroken",				1,
	"IsSealed",				1,
	"u0",					3
)]
struct ShortItemKind {
	uint Value;
}