using Shared;
using Shared.Character;
using Shared.Item;

enum BBType {
	WExp,
	Exp,
	SkillExp,
	PetExp,
	Axp,
	BoxDropRate,
	AlzBombRate,
	BeadSuperior,
	BeadPlus,
	BeadSupreme,
	BeadUltimate
}

enum WorldType : ulong {
	Normal,
	War = 3
}

enum RequestCraftResult : byte {
	Success = 2,
	Failed
}

enum CraftsmanType : byte {
	None,
	CraftsmansOrb,
	CraftsmansCrystal,
	CraftsmansKatana,
	CraftsmanBlade,
	CraftsmansDaikatana,
	CraftsmansGreatsword,
	CraftsmansGauntletsWA,
	CraftsmansGreavesWA,
	CraftsmansVisorWA,
	CraftsmansPlateWA,
	CraftsmansGlovesFA,
	CraftsmansBootsFA,
	CraftsmansHeadgearFA,
	CraftsmansCoatFA,
	CraftsmansHandsBL,
	CraftsmansShoesBL,
	CraftsmansHeadpieceBL,
	CraftsmansSuitBL,
	Ring,
	Amulet,
	MastersOrb,
	MastersCrystal,
	MastersKatana,
	MastersBlade,
	MastersDaikatana,
	MastersGreatsword,
	MastersGauntletsWA,
	MastersGreavesWA,
	MastersVisorWA,
	MastersPlateWA,
	MastersGlovesFA,
	MastersBootsFA,
	MastersHeadgearFA,
	MastersCoatFA,
	MastersHandsBL,
	MastersShoesBL,
	MastersHeadpieceBL,
	MastersSuitBL,
	CraftsmansGauntletsFS,
	CraftsmansGreavesFS,
	CraftsmansVisorFS,
	CraftsmansPlateFS,
	CraftsmansGauntletsGL,
	CraftsmansGreavesGL,
	CraftsmansVisorGL,
	CraftsmansPlateGL,
	CraftsmansGlovesFB,
	CraftsmansBootsFB,
	CraftsmansHeadgearFB,
	CraftsmansCoatFB,
	CraftsmansHandsWI,
	CraftsmansShoesWI,
	CraftsmansHeadpieceWI,
	CraftsmansSuitWI,
	MastersGauntletsFS,
	MastersGreavesFS,
	MastersVisorFS,
	MastersPlateFS,
	MastersGauntletsGL,
	MastersGreaverGL,
	MastersVisorGL,
	MastersPlateGL,
	MastersGlovesFB,
	MastersBootsFB,
	MastersHeadgearFB,
	MastersCoatFB,
	MastersHandsWI,
	MastersShoesWI,
	MastersHeadpieceWI,
	MastersSuitWI,
	CraftsmansChakram,
	MastersChakram,
	MastersGlovesFG,
	MastersBootsFG,
	MastersHeadgearFG,
	MastersCoatFG,
	CraftsmansGlovesFG,
	CraftsmansBootsFG,
	CraftsmansHeadgearFG,
	CraftsmansCoatFG
}

struct CraftsmansTokens {
	byte			Slot;
	CraftsmanType	Type;
	uint			Amity;
}

struct Skill {
	short	Id;
	byte	Level;
	short	Slot;
}

struct Quickslot {
	short	SkillSlot;
	short	Slot;
}

struct Title {
	ushort	Id;
	Period	Period;
}

struct Achievement {
	ushort		Id;
	uint		XP;
	ShortPeriod	AchieveDate;
}

struct Mercenary {
	uint	Id;
	byte	Rank;
	byte	Level;
}

struct AchievementReward {
	ushort	Id;
	uint	XP;
	bool	Completed;
}

class Quest {
	ushort	Id;
	/* Each bit (after the first) represents a separate step/stage of the quest, and is set to 1 when completed */
	ushort	Flag;
	bool	IsTracked;
	bool	IsExpanded;
	byte	Slot;
	[Variant(typeof(ObjectivesType), "GetObjectivesType")]	// TODO: Fix this by adding a way to get the array length from a function (maybe...)
	object	Objectives;

	enum ObjectivesType {
		ZeroObjectives,
		OneObjective,
		TwoObjectives,
		ThreeObjectives,
		FourObjectives
	}

	class ZeroObjectives { }

	struct OneObjective {
		byte	Objective;
	}

	struct TwoObjectives {
		byte	Objective1;
		byte	Objective2;
	}

	struct ThreeObjectives {
		byte	Objective1;
		byte	Objective2;
		byte	Objective3;
	}

	struct FourObjectives {
		byte	Objective1;
		byte	Objective2;
		byte	Objective3;
		byte	Objective4;
	}

	int GetObjectivesType() {
		var enc = ReadEncFile("enc/quest.enc");
		var xml = LoadXml(enc);
		var quest = (from q in xml.Root.Element("cabal_quest").Descendants("quest")
					 where (int)q.Attribute("quest_id") == Id
					 select q
					).First();

		return (from m in quest.Descendants("mission")
				where (int)m.Attribute("type") == 0 || (int)m.Attribute("type") == 1
				select m
				).Count();
	}
}

struct BlessingBead {
	BBType	Type;
	int		XP;
	Period	Duration;
}

struct PremiumService {
	uint	Id;
	uint	u0;
	byte	u1;
	short	u2;
	byte	u3;
	int		u4;
	int		u5;
	ushort	Order;
	Period	Duration;
}

struct EssenceRune {
	uint	Id;
	ushort	Level;
	ushort	u0;
}

struct BlendedRune {
	uint	Id;
	uint	Level;
	uint	u0;
}

class Pet {
	uint	Serial;
	uint	Id;
	uint	OwnerId;
	ulong	ItemId;
	byte	Level;
	uint	XP;
	byte	SkillCount;
	[Length(17)]
	string	Name;
	[Length(32)]
	byte[]	Skill;
	Time32	DeleteDate;
	uint	Checked;
}

struct OverlordAbility {
	byte	Id;
	byte	Level;
}

struct MeritAbility {
	uint	Id;
	uint	Level;
}

struct ChangeShapeItem {
	ushort	Slot;
	uint	AppearanceItemId;
	Period	Duration;
}

struct RequestCraft {
	byte				Slot;
	uint				RequestCode;
	uint				u0;
	uint				u1;
	RequestCraftResult	Result;
}

struct Buff {
	ushort	SkillId;
	uint	CoolDownTime;
}

class ForceGemConsumable {
	[TypeFor("Data")]
	DataType Type;
	object Data;
	Period Duration;

	enum DataType {
		UnlimitedWarp = 2,
		RegisterCoordinates = 5
	}

	struct UnlimitedWarp {
		uint	DurationId;
	}

	struct RegisterCoordinates {
		byte	PositionX;
		byte	PositionY;
		ushort	WorldId;
	}
}

class Message {
	uint					LobbyEntryOrder;
	uint					LobbySecondsLeft;
	uint					LobbyStartTime;
	bool					IsLobbyTimerStarted;
	uint					BattlefieldSecondsLeft;
	uint					BattlefieldStartTime;
	bool					IsBattlefieldTimerStarted;
	uint					CapellaScore;
	uint					ProcyonScore;
	uint					CapellaPoints;
	uint					ProcyonPoints;
	uint					MaxPlayersInWar;
	uint					CapellaBattlefieldEntryCount;
	uint					ProcyonBattlefieldEntryCount;
	uint					WarMap;
	bool					HasWarehousePassword;
	bool					HasInventoryPassword;
	bool					WarehouseLocked;
	bool					InventoryLocked;
	byte					ChannelCount;
	byte					ServerId;
	byte					ChannelId;
	ushort					UserCount;
	ulong					u0;
	ulong					u1;
	ushort					u2;
	byte					MinimumLevel;
	byte					MaximumLevel;
	byte					MinimumRank;
	byte					MaximumRank;
	ushort					MaxUserCount;
	IPv4					ChannelIP;
	ushort					ChannelPort;
	uint					ChannelType;
	byte					u3;
	byte					WarMapId;
	byte					u4;
	byte					u5;
	ObjectIndexData			UserId;
	uint					World;
	uint					Dungeon;
	ushort					PositionX;
	ushort					PositionY;
	ulong					XP;
	ulong					Alz;
	ulong					WarXP;
	uint					Level;
	uint					u6;
	uint					Strength;
	uint					Dexterity;
	uint					Intelligence;
	uint					StatPoints;
	uint					SkillRank;
	uint					Reserved;
	uint					CurrentHP;
	uint					MaximumHP;
	uint					CurrentMP;
	uint					MaximumMP;
	ushort					MaximumSP;
	ushort					CurrentSP;
	int						Rage;
	int						DungeonPoints;
	/* This is not a DateTime... Why would you set it as such? */
	long					DungeonPointsLifetime;
	int						SkillXP;
	int						SkillXPLevel;
	int						SkillPoints;
	ulong					RestXP;
	ulong					Honour;
	ulong					DeathPenaltyXP;
	uint					DeathPenaltyHP;
	uint					DeathPenaltyMP;
	short					PKPenalty;
	IPv4					ChatIP;
	ushort					ChatPort;
	IPv4					AgentShopIP;
	ushort					AgentShopPort;
	/* I think this might be used for party voice chat */
	IPv4					PartyIP;
	ushort					PartyPort;
	ushort					UnknownPort;
	byte					Nation;
	int						u7;
	int						Warps;
	int						Maps;
	Style					Style;
	/* Dancing 'n' shit */
	LiveStyle				LiveStyle;
	[Length(240)]
	byte[]					u8;
	[LengthFor("Equipment")]
	byte					EquipmentCount;
	[LengthFor("LockedEquipment")]
	byte					LockedEquipmentCount;
	[LengthFor("Inventory")]
	ushort					InventoryCount;
	[LengthFor("PW5Inventory")]
	ushort					PW5InventoryCount;
	[LengthFor("Skills")]
	ushort					SkillCount;
	[LengthFor("Quickslots")]
	ushort					QuickslotCount;
	[LengthFor("Mercenaries")]
	ushort					MercenaryCount;
	ushort					u9;
	ushort					APTotal;
	ushort					AP;
	int						AXP;
	[LengthFor("EssenceRunes")]
	byte					EssenceRuneCount;
	/* 16 + EssenceRuneSlots */
	byte					EssenceRuneSlots;
	[LengthFor("BlendedRunes")]
	byte					BlendedRuneCount;
	/* 3 + BlendedRuneCount */
	byte					BlendedRuneSlots;
	[LengthFor("BlessingBeads")]
	byte					BlessingBeadCount;
	[LengthFor("PremiumServices")]
	byte					PremiumServiceCount;
	[LengthFor("Quests")]
	ushort					QuestCount;
	[Length(256)]
	byte[]					QuestFlags;
	[Length(256)]
	byte[]					CompletedQuestFlags;
	[Length(512)]
	byte[]					DeletedQuestFlags;
	[Length(128)]
	byte[]					QuestDungeonFlags;
	[Length(128)]
	byte[]					MissionDungeonFlags;
	int						u10;
	int						HelpWindow;
	Pet						Pet;
	Pet						PetExtended;
	/* Number of ChangeShapeItems Equipped */
	[LengthFor("ChangeShapeEquipped")]
	byte					ChangeShapeEquippedCount;
	/* Number of ChangeShapeInventory Equipped */
	[LengthFor("ChangeShapeInventory")]
	byte					ChangeShapeInventoryCount;
	byte					u11;
	uint					TotalAchievementPoints;
	uint					GeneralAchievementPoints;
	uint					QuestAchievementPoints;
	uint					DungeonAchievementPoints;
	uint					ItemAchievementPoints;
	uint					PvPAchievementPoints;
	uint					MissionWarAchievementPoints;
	uint					HuntingAchievementPoints;
	uint					CraftingAchievementPoints;
	uint					CommunityAchievementPoints;
	uint					SharedAchievementPoints;
	uint					SpecialAchievementPoints;
	ushort					DisplayedTitle;
	ushort					EventTitle;
	ushort					WarTitle;
	ushort					AbilityTitle;
	[LengthFor("Achievements")]
	ushort					AchievementCount;
	ushort					u12;
	[LengthFor("Titles")]
	ushort					TitleCount;
	ushort					u13;
	ushort					u14;
	ushort					u15;
	[LengthFor("Crafts")]
	ushort					CraftCount;
	ushort					u16;
	byte					u17;
	uint					CraftEnergy;
	ulong					u18;
	[LengthFor("RequestCrafts")]
	byte					RequestCraftCount;
	uint					RequestAmity;
	[Length(114)]
	byte[]					RequestRecipeFlags;
	[Length(910)]
	byte[]					u19;
	[Length(118)]
	byte[]					RequestFavoriteFlags;
	[Length(910)]
	byte[]					u20;
	[LengthFor("Buffs")]
	byte					BuffCount;
	int						SPBuffLifeTime;
	byte					u21;
	uint					UpgradePoints;
	long					UpgradePointsLifeTime;
	[LengthFor("MeritAbilities")]
	int						MeritAbilityCount;
	int						MeritXP;
	int						MeritPoints;
	[LengthFor("AchievementRewards")]
	ushort					AchievementRewardCount;
	ushort					u22;
	int						ForceGems;
	[LengthFor("ForceGemConsumables")]
	int						ForceGemConsumableCount;
	short					OverlordLevel;
	ulong					OverlordXP;
	short					OverlordPoints;
	[LengthFor("OverlordAbilities")]
	byte					OverlordAbilityCount;
	byte					u23;
	int						u24;
	[LengthFor("Name", Operator.Add, 1)]
	byte					NameLength;
	string					Name;
	Item[]					Equipment;
	ushort[]				LockedEquipment;
	Item[]					Inventory;
	Skill[]					Skills;
	Quickslot[]				Quickslots;
	EssenceRune[]			EssenceRunes;
	BlendedRune[]			BlendedRunes;
	BlessingBead[]			BlessingBeads;
	PremiumService[]		PremiumServices;
	Quest[]					Quests;
	Mercenary[]				Mercenaries;
	/* ChangeShape Items Equipped */
	ChangeShapeItem[]		ChangeShapeEquipped;
	/* ChangeShape Items In Inventory */
	ChangeShapeItem[]		ChangeShapeInventory;
	Achievement[]			Achievements;
	Title[]					Titles;
	AchievementReward[]		AchievementRewards;
	CraftsmansTokens[]		Crafts;
	RequestCraft[]			RequestCrafts;
	Buff[]					Buffs;
	Item[]					PW5Inventory;
	MeritAbility[]			MeritAbilities;
	ForceGemConsumable[]	ForceGemConsumables;
	OverlordAbility[]		OverlordAbilities;
}