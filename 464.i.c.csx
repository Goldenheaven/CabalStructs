
enum ResultType : byte {
	OK,
	Undefined,
	InvalidParameter,
	NotExist,
	DatabaseFailure,
	InvalidRet
}


class Message {
	ResultType	Result;
	uint		CharacterID;
	uint 		DataLength;
	byte 		u0;
	public string Name;
	[Length(38)]
	byte[] u1;
}