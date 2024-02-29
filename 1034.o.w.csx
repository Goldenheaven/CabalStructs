
enum SubType {
	Login = 1,
	Warehouse,
	Inventory
}

class Message {
	[Length(11)]
	string	SubPassword;
	SubType	SubPasswordType;
	byte	Hours;
	[Large]
	bool	IsLocked;
}