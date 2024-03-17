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

enum DungeonBoxType : uint {
    Easy = 1,
    Normal = 2,
    Hard = 3,
    Heroic = 4,
    Awakened = 5
}

enum CollectionType : byte {
    Dungeon = 1,
    World = 2
}

class CraftsmansTokens {
	byte			Slot;
	CraftsmanType	Type;
	uint			Amity;
}

class Skill {
	short	Id;
	byte	Level;
	short	Slot;
}

class Quickslot {
	short	SkillSlot;
	short	Slot;
}

class Title {
	ushort	Id;
	Period	Period;
}

class Achievement {
	ushort		Id;
	uint		XP;
	ShortPeriod	AchieveDate;
}

class Mercenary {
	uint	Id;
	byte	Rank;
	byte	Level;
}

class AchievementReward {
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

	class OneObjective {
		byte	Objective;
	}

	class TwoObjectives {
		byte	Objective1;
		byte	Objective2;
	}

	class ThreeObjectives {
		byte	Objective1;
		byte	Objective2;
		byte	Objective3;
	}

	class FourObjectives {
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

class BlessingBead {
	BBType	Type;
	int		XP;
	Period	Duration;
}

class PremiumService {
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

class EssenceRune {
	uint	Id;
	ushort	Level;
	ushort	u0;
}

class BlendedRune {
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

class OverlordAbility {
	byte	Id;
	byte	Level;
}

class MeritAbility {
	uint	Id;
	uint	Level;
}

class ChangeShapeItem {
	ushort	Slot;
	uint	AppearanceItemId;
	Period	Duration;
}

class RequestCraft {
	byte				Slot;
	uint				RequestCode;
	uint				u0;
	uint				u1;
	RequestCraftResult	Result;
}

class Buff {
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

	class UnlimitedWarp {
		uint	DurationId;
	}

	class RegisterCoordinates {
		byte	PositionX;
		byte	PositionY;
		ushort	WorldId;
	}
}

class GiftBox {
	byte	ID;
	int		OpenCount;
	[Comment("InSeconds")]
	ulong	CurrentTime;
	[Comment("InSeconds")]
	ulong	TimeLeft;
	bool	Enabled;
}

class DungeonRewardBoxList {
    DungeonBoxType BoxType;
    [Comment("Next Box : Time Seconds")]
    uint Status;
    Time32 TimeLeft;
}

class CollectionList {
    CollectionType Type;
    byte ID;
    ushort MissionID;
    bool Reclaimed;
    [Length(6)]
    ushort[] Slot;
}

class CostumeWarehouseItem{
	ulong	u1;
	ulong	u2;
	ulong	u3;
	ulong	u4;
	ulong	u5;
	ulong	u6;
	ulong	u7;
	ulong	u8;
	uint	u9;
	byte	u10;
	byte	u11;
	byte	u12;
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
	[Length(65)]
	string					ChannelIP;
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
	uint					MagicSkillRank; /* Not in use */
	ulong					MaximumHP;
	ulong					CurrentHP;
	uint					MaximumMP;
	uint					CurrentMP;
	ushort					MaximumSP;
	ushort					CurrentSP;
	uint					MaximumRage;
	uint					CurrentRage;
	int						MaximumBP;
	int						CurrentBP;
	int						DungeonPoints;
	int						DungeonPointsLifetime;
	int						CharacterID;
	int						SkillXP;
	int						SkillXPLevel;
	int						SkillPoints;
	ulong					RestXP;
	ulong					Honour;
	ulong					DeathPenaltyXP;
	ulong					DeathPenaltyHP;
	uint					DeathPenaltyMP;
	short					PKPenalty;
	[Length(65)]
	string					ChatIP;
	ushort					ChatPort;
	[Length(65)]
	string					AgentShopIP;
	ushort					AgentShopPort;
	/* I think this might be used for party voice chat */
	[Length(65)]
	string					PartyIP;
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
	[Length(42)]
	byte[]					u81;
	[LengthFor("Equipment")]
	ushort					EquipmentCount;
	[LengthFor("LockedEquipment")]
	byte					LockedEquipmentCount;
	[LengthFor("Inventory")]
	ushort					InventoryCount;
	[LengthFor("VehicleWarehouse")]
	ushort					VehicleWarehouseItemCount;
	[LengthFor("Skills")]
	ushort					SkillCount;
	[LengthFor("Quickslots")]
	ushort					QuickslotCount;
	[LengthFor("Mercenaries")]
	ushort					MercenaryCount;
	[Comment("?")]
	ushort					PeriodItemCount;
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
	byte					UnknownCount;
	byte					UnknownCount1;
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
	[Length(4097)]
	byte[]					UnknownFlags;
	[LengthFor("DailyQuests")]
	uint					DailyQuestCount;
	int						HelpWindow;
	Pet						Pet;
	Pet						PetExtended;
	Pet						PetDisplayed;
	/* Number of ChangeShapeItems Equipped */
	[LengthFor("ChangeShapeEquipped")]
	byte					ChangeShapeEquippedCount;
	/* Number of ChangeShapeInventory Equipped */
	[LengthFor("ChangeShapeInventory")]
	ushort					ChangeShapeInventoryCount;
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
	uint					AchievementCount;
	[LengthFor("Titles")]
	uint					TitleCount;
	uint					UnknownCount2;
	[LengthFor("Crafts")]
	uint					CraftCount;
	byte					u17;
	uint					CraftEnergy;
	[Length(6)]
	byte[]					u18;
    byte 					SortingOrderMask;
    byte                    u181;
	[LengthFor("RequestCrafts")]
	byte					RequestCraftCount;
	ushort					RequestCraftExp;
	[Length(114)]
	byte[]					RequestRecipeFlags;
	[Length(910)]
	byte[]					u19;
	[Length(118)]
	byte[]					RequestFavoriteFlags;
	[Length(922)]
	byte[]					u20;
    uint GoldMeritCount;
    uint GoldMeritExp;
    uint GoldMeritPoint;
    byte PlatinumMeritCount;
    uint PlatinumMeritExp;
	[Length(2)]
    uint PlatinumMeritPoint;
	[LengthFor("Buffs")]
	byte					BuffCount;
	uint					u21;
	int						SPBuffLifeTime;
	uint					UpgradePoints;
	Time64					UpgradePointsLifeTime;
	byte					w1;
	[LengthFor("MeritAbilities")]
	int						MeritAbilityCount;
	//int						MeritXP;
	int						MeritPoints;
	[LengthFor("AchievementRewards")]
	ushort					AchievementRewardCount;
	ushort					u22;
	int						ForceGems;
	[LengthFor("ForceGemConsumables")]
	int						ForceGemConsumableCount;
	[Length(32)]
	byte[]					UnkXX11;
    byte 					ForceWingRank;
    byte 					ForceWingLevel;
    ulong 					ForceWingExp;
	[Length(9)]
	byte[]					ForceWingUnk1;
	[Length(5)]
	byte[]					ForceWingPresetFlags;
	uint					ForceWingPoints;
	[Length(16)]
	byte[]					ForceWingUnk2;
	byte					ForceWingSkillSlotCount;
	byte					ForceWingTrainingSlotCount;
	[Length(77)]
	byte[]					UnkXX12;
	[Length(12)]
	byte[]					ForceWingAbilities;
}