
enum ResultType : byte {
	OK,
	Undefined,
	PresenceFail,
	InvalidParameter,
	AlreadyAuthorised,
	VerificationNeeded,
	InvalidRet
}

class Message {
	ResultType Result;
}