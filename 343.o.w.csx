using Shared;

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
	ObjectIndexData AttackerUserID;
	uint AttackerID;
	[Comment("PVP::ENDING_RESULT")]
	PKEndResult PkEndResult;
	[Comment("PVP::PK_TYPE")]
	byte PkType;
}