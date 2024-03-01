enum PKEndResult : byte {
	TimeOut,
	Dead,
	Escape,
	Disconnect,
	ScoreWin,
	ScoreLose,
	TimeOutWin,
	TimeOutLose,
	TimeOutDraw,
	DisconnectWin,
	DisconnectLose
}


class Message {
	uint CharacterID;
	PKEndResult Result;
}