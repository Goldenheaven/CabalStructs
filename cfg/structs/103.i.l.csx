
enum Result : int {
	Success,
	Maintenance,
	Steam_unk
}

class Message {
	Result	Result;
    uint    u0;
    uint    u1;
}