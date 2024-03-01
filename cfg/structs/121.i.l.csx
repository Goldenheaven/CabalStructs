[Bitfield(
	"unk0",	4,
	"Hot",	4
)]
struct ServerFlag {
	byte	Value;
}

class Channel {
	byte	ServerId;
	byte	ChannelId;
	ushort	UserCount;
	ushort	UsersInWarLobby;
	ushort	u2;
	ushort	CapellasInWar;
	ushort	ProcyonsInWar;
	uint	u3;
	ushort	CapellasInWar2;
	ushort	ProcyonsInWar2;
	ushort	u4;
	byte	MinimumLevel;
	byte	MaximumLevel;
	byte	MinimumRank;
	byte	MaximumRank;
	ushort	MaximumUserCount;
	[Length(65)]
	byte[]	ChannelIP;
	ushort 	Port;
	ulong	Type;
}

class Server {
	byte		Id;
	ServerFlag	Flag;
	uint		Language;
	byte		u0;
	byte		u1;
	[LengthFor("Channels")]
	byte		ChannelCount;
	Channel[]	Channels;
}

class Message {
	[LengthFor("Servers")]
	byte Count;
	Server[] Servers;
}