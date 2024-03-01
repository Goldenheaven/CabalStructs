
class Message {
	int    GuildId;
	int    GroupId;
	int    u0;
	ushort u1;
	[LengthFor("GroupName")]
	ushort GroupNameLength;
	string GroupName;
}