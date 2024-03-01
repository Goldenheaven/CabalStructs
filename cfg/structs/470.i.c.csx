
enum ResultType : byte {
	OK,
	Undefined,
	InvalidParameter,
	InvalidRet,
	AlreadyExist,
	DatabaseFailure
}

class Message {
	uint		CharacterId;
	ResultType 	Result;
	ushort 		DataLength;
	[LengthFor("Memo")]
	ushort 		MemoLength;
	string 		Memo;
}