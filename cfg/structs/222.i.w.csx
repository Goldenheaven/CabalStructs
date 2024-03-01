using Shared;
using Shared.Character;

class Message {
	ushort SkillID;
	[Variant(typeof(DataType), "GetDataType")]
	object Data;

	enum DataType {
		Group_1		= 1,
		Group_5		= 5,
		Group_31	= 31,
	}

	struct Group_1 {
		byte			EnemyCount;
		uint			CharacterID;
		short			DestinationX;
		short			DestinationY;
		byte			HasReflection;
		uint			AttackerHp;
		uint			ReflectedDamage;
		uint			EnemyID;
		AttackResult	Result;
		uint			EnemyHpLeft;
		BattleFX		Bfx;
		[Comment("Milliseconds")]
		uint			BfxTime;
		byte			u3;
	}

	struct Group_5 {
		uint			CharacterId;
		ObjectIndexData	UserId;
		short			DestinationX;
		short			DestinationY;
	}

	struct Group_31 {
		uint	CharacterId;
		Style	Style;
		short	u0;
		StyleEx	StyleEx;
		/* 1 = Activate, 0 = Deactivate */
		short	State;
		int		u1;
	}

	int GetDataType() {
		var enc = ReadEncFile("enc/skill.enc");
		var xml = LoadXml(enc);
		var group = (int)(from s in xml.Root.Element("new_skill_list").Descendants("skill_main")
					 where (int)s.Attribute("id") == SkillID
					 select s
					).First().Attribute("group");

		return group;
	}
}