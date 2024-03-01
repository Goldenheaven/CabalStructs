
class Message {
	bool IsLastEntry;
	uint Index;
	uint CharId;
	uint Level;
	byte BattleStyle;
	[Length(17)]
	string CharacterName;
	[LengthFor("Memo")]
	ushort MemoLength;
	string Memo;
	long u1;
	long u2;
	long u3;
	int u4;
}