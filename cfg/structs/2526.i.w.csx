
class Guild {
	int		u5;
	int		u6; 
	int		GuildScore;
	int		GuildId;
	int		Something;
	string 	GuildName;
	ushort	u0;
	ushort	u1;
	byte	u2;
	byte	u3;
	[Length(16)]
	string 	GuildMasterName;
	byte	u4;
	int		CharacterId;
}

class Message {
	/*unfinished!*/
	[Length(10)]
	Guild[]	Guilds;
}