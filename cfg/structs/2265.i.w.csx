
class Room {
	[Length(42)]
	public	string	RoomName;
	public	int		Members;
	public	byte	Mode;
	public	byte	Map;
	public	int		u5;
}

class Message {
	int		u0;
	int		u1;
	int		u3;
	[LengthFor("Rooms")]
	int		RoomCount;
	public	Room[]	Rooms;
}