
struct DungeonEntryException {
	int		DungeonId;
	byte	PCRoomEntryOnly;
	byte	BeadLevelException;
	byte	PCRoomLevelException;
}

class Message {
	[LengthFor("Entries")]
	short					Count;
	DungeonEntryException[]	Entries;
}