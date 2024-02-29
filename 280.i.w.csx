
enum AddOptionResult : byte {
	Success = 1,
	Fail = 4
}

class Message {
	AddOptionResult		Result;
	int		Option;
}