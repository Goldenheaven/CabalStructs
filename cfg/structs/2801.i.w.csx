class Unk {
	int ID;
	[LengthFor("Data")]
	int Count;
	int[] Data;
}


class Message {
	[LengthFor("Unknown")]
	int Count;
	Unk[]	Unknown;
}