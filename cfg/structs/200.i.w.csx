using Shared;
using Shared.Character;
using Shared.Item;

enum NewUserType : byte {
	OtherPlayers = 0,
	NewInit = 48,
	NewWarp,
	NewMove,
	NewResurrect
}

enum EquipmentSlot : byte {
	Helmet,
	Suit,
	Gloves,
	Boots,
	WeaponRight,
	WeaponLeft,
	Epaulet,
	Amulet,
	RingRight1,
	RingLeft1,
	Bike_Board,
	Pet1,
	_NOT_USED_,
	EarringRight,
	EarringLeft,
	BraceletRight,
	BraceletLeft,
	RingRight2,
	RingLeft2,
	Belt,
	Pet2,
	Charm,
	EffectorRight,
	EffectorLeft,
	LinkedWeapon,
	CostumeWeaponLeft,
	CostumeWeaponRight,
	CostumeHeadgear,
	CostumeWithOptions,
	DialogBubble,
	Talisman,
	CostumeClothes,
	Carnelion,
	ArcanaRight,
	ArcanaLeft,
	CostumeBike,
}

struct EquippedItem {
	EquipmentSlot	Slot;
	ItemKind		Kind;
	ulong			Option;
	Period			Duration;
}

struct Buff {
	ushort	ID;
	byte	Level;
	uint	u0;
	uint	u1;
	uint	u2;
}

[Bitfield(
	"PKLevel",		3,
	"ActionFlag",	13
)]
struct PKFlag {
	ushort Value;
}

class Character {
	uint			Id;
	ObjectIndexData	UserId;
	uint			Level;
	ushort			OverlordLevel;
	byte			ForceWingGrade;
	byte			ForceWingLevel;
	int				MaximumHP;
	int				CurrentHP;
	int				MaximumRage;
	int				CurrentRage;
	int				MoveSpeed;
	ushort			PositionX;
	ushort			PositionY;
	ushort			DestinationX;
	ushort			DestinationY;
	PKFlag			PKFlag;
	byte			Nation;
	uint			u0;
	Style			Style;
	LiveStyle		LiveStyle;
	ushort			u1;
	ushort			u111;
	StyleEx			StyleEx;	
	bool			IsDead;
	[LengthFor("Equipment")]
	byte			EquipmentCount;
	bool			GMFlag;
	[TypeFor("PersonalShop")]
	PShopType		PersonalShopType;
	uint			GuildID;
	ushort			u2;
	ushort			u3;
	StyleEtc		StyleEtc;

	enum PShopType : byte {
		NoPShop,
		PShop,
	}

	class NoPShop {}

	class PShop {
		[LengthFor("Message")]
		byte	Length;
		string	Message;
		ulong	u0;
	}

	enum PetType {
		NoPet,
		Pet,
	}

	class NoPet {}

	class Pet {
		[LengthFor("Name", Operator.Mul, 8)]
		byte		Style;
		byte		u0;
		byte		u1;
		byte		u2;
		byte		u3;
		string		Name;
		byte		u4;
		byte		u5;
		byte		u6;
		byte		u7;
	}
	
	int GetPrimaryPetType()
		=> StyleEtc.HasFlag(StyleEtc.PrimaryPetActive) ? (int)PetType.Pet : (int)PetType.NoPet;

	int GetSecondaryPetType()
		=> StyleEtc.HasFlag(StyleEtc.SecondaryPetActive) ? (int)PetType.Pet : (int)PetType.NoPet;
}

class Message {
	[LengthFor("Characters")]
	byte		Count;
	NewUserType	Type;
	Character[]	Characters;
}