
class Act {
	int  Id;
	ushort Slot;
}

class Message {
	public  ushort QuestId;
	public  int    SetId;
	public  int    SlotId;
	[LengthFor("Acts")]
	public  byte   ActCount;
	public  Act[]  Acts;
}