
enum ResultType : byte {
	OK,
	Undefined,
	InvalidUserID,
	InvalidUserPassword,
	BuddyChannelFailure,
	GuildChannelFailure,
	DatabaseFailure,
	ServerNotReady,
	AlreadyAuthorised,
	InvalidRet,
	InvalidParameter
}

class Message {
	int			CharacterId;
	uint		GuildId;
	ResultType	Result;
}