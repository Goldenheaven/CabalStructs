
class User {
	[Length(17)]
	string		CharacterName;
	Time32		Time;
	byte		u3;
}


class Message {
	byte	u0;
	[LengthFor("Users")]
	byte	UserAmount;
	ulong	u1;
	User[]	Users;
}