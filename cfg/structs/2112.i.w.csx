
class Channel {
	byte 	ServerID;
    byte 	ChannelID;
    ushort 	UserCount;
    [Length(18)]
    byte[] u0;
    byte 	MinimumLevel;
    byte 	MaximumLevel;
    byte 	MinimumRank;
    byte 	MaximumRank;
    ushort 	MaxUserCount;
    IPv4 ChannelIP;
    ushort 	ChannelPort;
	uint 	ChannelType;
	byte 	u1;
	byte 	WarMapID;
	byte 	u2;
	byte 	u3;
}

class Message {
	[LengthFor("ChannelList")]
	byte ChannelCount;
	Channel[] ChannelList;
}