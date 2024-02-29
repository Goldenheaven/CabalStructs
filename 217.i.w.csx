using Shared;

enum MsgType : byte {
	Normal = 160,
	Trade
}

class Message {
	int  CharacterId;
	byte Remark;
	short MessageBlockLength;
	short MessageLength;
	short MessageData;
	MsgType MessageType;
	public string Message1;
	
	[LengthFor("Memo")]
	public byte MemoCount;
	public LinkedMemo[] Memo;

	[LengthFor("Item")]
	public byte ItemCount;
	public LinkedItem[] Item;

	
}