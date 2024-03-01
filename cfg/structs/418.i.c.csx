
class Group {
	int    GroupId;
	int    u2;
	int    GroupOptions;
	[LengthFor("GroupName")]
	short  GroupNameLength;
	string GroupName;
}


class Message {
	uint GuildID;
	uint u0;
	byte u1;
	ushort u3;
	List<Group> Group;
}