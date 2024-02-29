using Shared.Character;
using Shared.Item;
using Shared;

class AppearenceItem {
	ushort   SlotId;
	uint	 Kind;
	Period   Duration;
}

class Character {
	uint		Id;
	Time64		CreationDate;
	Style		Style;
	uint		Level;
	ushort		OverlordLevel;
	uint		w1;
	uint		w2;
	uint		w3;
	[Comment("Confirm if its skillrank")]
	uint		SkillRank;
	byte		Nation;
	[Length(17)]
	string		Name;
	long		HonorPoint;
	ulong		Alz;
	byte		Map;
	short		Y;
	short		X;
	ushort		EquipmentCount;
	Item	Helmet;
	Item	Suit;
	Item	Gloves;
	Item	Boots;
	Item	RightHand;
    Item    LeftHand;
	Item	Epaulet;
	Item	Amulet;
	Item	Ring1;
	Item	Ring2;
	Item	Bike;
	Item	Pet;
	Item	None;
	Item	Earing1;
	Item	Earing2;
	Item	Bracelet1;
	Item	Bracelet2;
	Item	Ring3;
	Item	Ring4;
	Item	Belt;
	Item	PetEx;
	Item	Charm1;
	Item	Effector1;
	Item	Effector2;
	Item	LinkedWeapon;
	Item	WeaponCostume1;
	Item	WeaponCostume2;
	Item	HeadGear;
	Item	Costume;
	Item	DialogBubble;
	Item	Talisman;
	Item	CostumeNoOptions;
	Item	Carnelian;
	Item	Arcana1;
	Item	Arcana2;
	Item	VehicleCostume;
	Item	VehicleCostumeNoOptions;
	Item	ForceWingCostume;
	Item	ForceWingCostumeNoOptions;
	[Length(8)]
	Item[]	UnknownItems;
	[Length(47)]
	AppearenceItem[] UnknownAppearanceItems;
}

enum SlotOpener : uint
{
    None = 	0x00,
    Slot7 = 0x07,
    Slot8 = 0x08,
    Both = 	0x0F
}

class Message {
	[Large]
	bool			IsPinSet;
	[Length(3)]
	byte[]			IsPinSetPadding;
	ulong			BattlefieldEntryFee;
	byte			u2;
	byte			u3;
	/* Determines which character to highlight */
	uint			LastCharacterId;
	/* Each char is represented by 4 bits. Each 4 bits is equal to the last 4 bits in the character id. So, if we have 2 characters whose last
	   4 bits of their id's are 3 and 4 respectively, and they are in slot 1 and 2, the value here would be 0x034?????. This value starts off
	   as 0x00123456 and gets shuffled about when you move your characters. This results in different values being assigned to each slot. So,
	   if slot 2 is empty, but you have moved characters to and from that slot, it's actual ID (which determines the last 4 bits for the id of
	   the character you make there) might be something completely different. */
	uint			CharacterOrder;
	SlotOpener 		SlotsOpened;
	uint			u4;
	uint			u5;
	uint			u6;
	[Length(16)]
	Character[]		Characters;
}