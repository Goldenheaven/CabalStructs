using Shared.Character;

class Member {
	int		CharId;
	byte	u2;
	byte	IsOnline;
	byte	u4;
	byte	u5;
	byte	u6;
	byte	u7;
	byte	Channel;
	byte	u9;
	byte	u10;
	byte	Map;
	byte	u12;
	byte	u13;
	ushort	u14;
	ushort	u15;
	byte	Level;
	ushort	u16;
	ushort	u17;
	byte	u18;
	Style	CharacterStyle;
	byte	u20;
	int		u21;
	[LengthFor("CharacterName")]
	ushort	CharacterNameLength;
	string	CharacterName;

}

class Message {
	int		GuildId;
	int		u0;
	byte	u1;
	ushort	DataLength;
	List<Member> GuildMembers;
}