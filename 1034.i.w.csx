
enum SubType {
	Login = 1,
	Warehouse,
	Inventory
}

class Message {
	uint	Success;
	byte	FailureCount;
	[Large]
	bool	IsLocked;
	[Length(3)]
	byte[] IsLockedPadding;
	SubType	SubPasswordType;
}