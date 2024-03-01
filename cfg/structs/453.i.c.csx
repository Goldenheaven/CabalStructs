
[Flags]
enum Environment {
	None,
	AllowGuildBoard,
	UseNotifyGuildEmblem = 16
}

class Message {
	public Environment Flags;
}