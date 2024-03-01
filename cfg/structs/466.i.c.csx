
enum ResultType : byte {
	OK,
	Undefined,
	AlreadyExists,
	InvalidParameter,
	InvalidRet,
	DatabaseFailure
}

class Message {
	int GroupId;
	ResultType Result;
	ushort DataLength;
	[LengthFor("Name")]
	ushort NameLength;
	public string Name;
}