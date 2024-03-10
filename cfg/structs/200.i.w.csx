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

class EquippedItem {
	EquipmentSlot	Slot;
	ItemKind		Kind;
	ulong			Option;
	Period			Duration;
}

class Buff {
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
	uint			un0;
	uint			un1;
	uint			un2;
	byte			ForceWingGrade;
	byte			ForceWingLevel;
	ulong			MaximumHP;
	ulong			CurrentHP;
	int				MaximumRage;
	int				CurrentRage;
	uint			un3;
	uint			un4;
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
	[LengthFor("UnknownBuffs")]
	byte			UnkBuffCount;
	bool			GMFlag;
	[TypeFor("PersonalShop")]
	PShopType		PersonalShopType;
	uint			GuildID;
	ushort			u2;
	ushort			u3;
	StyleEtc		StyleEtc;
	[LengthFor("ActiveBuffs")]
	byte			ActiveBuffCount;
	[LengthFor("Debuffs")]
	byte			DeBuffCount;
	[LengthFor("GMBuffs")]
	byte			GMBuffCount;
	[LengthFor("PassiveBuffs")]
	byte			PassiveBuffCount;
	byte			Bringer;
	uint			u4;
	ushort			UnkTitle1;
	ushort			UnkTitle2;
	ushort			DisplayedTitle;
	ushort			EventTitle;
	ushort			WarTitle;
	ushort			AbilityTitle;
	[LengthFor("Name", Operator.Add, 1)]
	byte			NameLength;
	string			Name;
	[LengthFor("GuildName")]
	byte			GuildNameLength;
	string			GuildName;
	EquippedItem[]	Equipment; 
	object			PersonalShop;
	Buff[]			ActiveBuffs;
	Buff[]			PassiveBuffs;
	Buff[]			GMBuffs;
	

	
	enum PShopType : byte {
		NoPShop,
		PShop,
	}

	class NoPShop {}

	class PShop {
		[LengthFor("Message")]
		byte	Length;
		string	Message;
		ulong	psu0;
	}
	
	

	enum PetType {
		NoPet,
		Pet,
	}

	struct NoPet {}

	struct Pet {
		[LengthFor("Name", Operator.Mul, 8)]
		byte		PetStyle;
		byte		ptu0;
		byte		ptu1;
		byte		ptu2;
		byte		ptu3;
		string		PetName;
		byte		ptu4;
		byte		ptu5;
		byte		ptu6;
		byte		ptu7;
	}
	
	int GetPrimaryPetType()
		=> StyleEtc.HasFlag(StyleEtc.PrimaryPetActive) ? (int)PetType.Pet : (int)PetType.NoPet;

	int GetSecondaryPetType()
		=> StyleEtc.HasFlag(StyleEtc.SecondaryPetActive) ? (int)PetType.Pet : (int)PetType.NoPet;
}

class Message {
	byte		Count;
	NewUserType	Type;
	Character	Characters;
}