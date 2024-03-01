[Custom]
struct Duration {
	int Seconds;

	// Return value in the format XhXmXs
	public override string ToString()
		=> 
		$"{( Seconds - ( Seconds % 3600 ) ) / 3600:d2}:"+
		$"{( ( Seconds % 3600 ) - ( Seconds % 60 )) / 60:d2}:"+
		$"{Seconds % 60:d2}";
}

class Message {
	ushort DungeonID;
	ushort u0;
	int u13;
	int u14;
	byte u2;
	int    u3;
	ushort u4;
	ushort u41;
	byte    u5;
	int    u6;
	Duration RemainingTime;
	ulong u7;
	ulong u8;
	ulong u9;
	int u10;
	byte TotalEntries;
	byte EntryCount;
	ushort u11;
	int u12;
}