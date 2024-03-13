using Shared;
using Shared.Character;
using Shared.Item;
using Shared.Pet;

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

class OldBuff {
	ushort	ID;
	byte	Level;
	uint	u0;
	uint	u1;
	uint	u2;
	uint	u3;
	byte	u4;
}

class Buff {
	ushort	ID;
	byte	Level;
	uint	u0;
	uint	u1;
	uint	u2;
	uint	u3;
	uint	u4;
	uint	u5;
	uint	u6;
	uint	u7;
	uint	u8;
	uint	u9;
	uint	u10;
	uint	u11;
	uint	u12;
	uint	u13;
	uint	u14;
	uint	u15;
	uint	u16;
	uint	u17;
	uint	u18;
	uint	u19;
	ushort	u20;
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
	uint			HolyPower;
	uint			Rebirth;
	uint			MythLevel;
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
	uint			Reserved;
	Style			Style;
	LiveStyle		LiveStyle;
	ushort			u1;
	ushort			u111;
	StyleEx			StyleEx;	
	bool			IsDead;
	[LengthFor("Equipment")]
	byte			EquipmentCount;
	[LengthFor("Costumes")]
	byte			CostumeCount;
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
    EquippedItem[]  Costumes;
	object			PersonalShop;
	Buff[]			ActiveBuffs;
	Buff[]			PassiveBuffs;
	Buff[]			GMBuffs;
	[Variant(typeof(PetType), "GetPrimaryPetType")]
	object			PrimaryPet;
	[Variant(typeof(PetType), "GetSecondaryPetType")]
	object			SecondaryPet;
	
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

	class NoPet {}

	class Pet {
		[LengthFor("Name", Operator.Mul, 8)]
		PetStyle Style;
		byte		u0;
		byte		u1;
		byte		u2;
		byte		u3;
		string		Name;
		byte		u4;
		byte		u5;
		byte		u6;
	}
	
	int GetDisplayPetType()
		=> (StyleEtc.HasFlag(StyleEtc.PrimaryPetActive) || StyleEtc.HasFlag(StyleEtc.SecondaryPetActive)) ? (int)PetType.Pet : (int)PetType.NoPet;
	
	int GetPrimaryPetType()
		=> (StyleEtc.HasFlag(StyleEtc.PrimaryPetActive) || StyleEtc.HasFlag(StyleEtc.SecondaryPetActive)) ? (int)PetType.Pet : (int)PetType.NoPet;

	int GetSecondaryPetType()
		=> StyleEtc.HasFlag(StyleEtc.SecondaryPetActive) ? (int)PetType.Pet : (int)PetType.NoPet;
}

class Message {
	[LengthFor("Characters")]
	byte		Count;
	NewUserType	Type;
	Character[]	Characters;
}