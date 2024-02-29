
class Message {
	int		u0;
	[Length(41)]
	public	string	RoomName;
	[Length(5)]
	string	RoomPassword; 
	int		Map;
	int		RoomMode;
	bool	NoItemMode;
	bool	SpectatorMode;
	bool	BattleMode;
	int		TimeMode;
	int		KillCount;
	int		u1;
}