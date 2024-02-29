
enum EventType : byte {
	LevelUp = 1,
	RankUp
}

class Message {
	EventType Type;
	int    CharacterId;
}