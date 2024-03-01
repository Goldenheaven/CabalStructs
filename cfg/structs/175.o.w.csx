using Shared;

class Message {
	ushort SkillID;
	[Variant(typeof(DataType), "GetDataType")]
	object Data;

	enum DataType {
		Group_1		= 1,
		Group_5		= 5,
		Group_31		= 31,
	}
	
	struct Group_1 {
		ushort SkillSlotID;
		byte u0;
		ushort u4;
		ushort FromX;
		ushort FromY;
		uint   AttackerID;
		ushort DeltaY;
		ushort ToX;
		ushort ToY;
		ObjectIndexData EnemyUserID;
		byte u2;
		uint u3;
	}
	
	struct Group_5 {
		byte SkillSlotID;
		ushort FromX;
		ushort FromY;
		ushort ToX;
		ushort ToY;
	}
	
	struct Group_31 {
		byte SkillSlotID;
		ushort FromX;
		ushort FromY;
		ushort ToX;
		ushort ToY;
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