using Shared;

class Mob {
	ObjectIndexData ID;
	ushort			FromX;
	ushort			FromY;
	ushort			ToX;
	ushort			ToY;
	Specie			Species;
	int				MaximumHP;
	int				CurrentHP;
	bool			IsChasing;
	ushort			Level;
	byte			Nation;
	ushort			u0;
	ushort			u01;
	byte			u1;
	//byte			u2; u2 is now u3???
	ulong			u3;
	int				Aggressive;
	int				u5;

	
	[Custom]
	class Specie {
		ushort SpecieID;

		public override string ToString()
		{
			var enc = ReadEncFile("enc/mobnames.enc");
			var xml = LoadXml(enc);

			var group = (string)(from s in xml.Root.Element("mob_msg").Descendants("msg")
						 where ((string)s.Attribute("id")).Equals($"monster{SpecieID}")
						 select s
						).First().Attribute("cont");
						
			return group;
		}
	}
}

class Message {
	[LengthFor("Mobs")]
	byte	Count;
	Mob[]	Mobs;
}