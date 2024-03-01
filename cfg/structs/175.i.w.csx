using Shared;
using Shared.Character;

class Message {
	ushort ID;
	[Variant(typeof(DataType), "GetDataType")]
	object Data;

	enum DataType {
		Group_1		= 1,
		Group_5		= 5,
		Group_31	= 31,
	}

	struct Group_1 {
		uint			AttackerCurHp;
		uint			AttackerCurMp;
		
		ulong 			UnkownData1;
		ulong 			UnkownData2;
		ulong 			UnkownData3;
		ushort	 		UnkownData4;
		int 			UnkownData5;
		byte			HasReflection;	
		uint			AttackerMaxHp;
		uint			ReflectedDamage;
		byte			TargetCount;
		Target			TargetPlayer;

		struct Target{
			uint ID;
			AttackResult Result;
			uint Damage1;
			uint Damage2;
			uint u3;
			uint CurrentHp;
			[Comment("Bfx")]
			BattleFX BattleFX;
			uint u4;
			byte u7;
		}
	}

	struct Group_5 {
		uint			u0;
		uint			Mp;
	}

	struct Group_31 {
		uint			CurrentMp;
		uint			u0;
	}

	int GetDataType() {
		var enc = ReadEncFile("enc/skill.enc");
		var xml = LoadXml(enc);
		var group = (int)(from s in xml.Root.Element("new_skill_list").Descendants("skill_main")
					 where (int)s.Attribute("id") == ID
					 select s
					).First().Attribute("group");

		return group;
	}
}