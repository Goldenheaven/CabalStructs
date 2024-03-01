using Shared;

struct UnkStruct {
	ushort u0;
	byte WorldIndex;
	ObjectType Type;
}


class Message {
	[LengthFor("Unk")]
	byte Count;
	UnkStruct[] Unk;
}