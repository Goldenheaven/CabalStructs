
class Cores {
	ushort	CoreInventorySlot1;
	ushort	CoreInventorySlot2;
}

class SafeGuards  {
	ushort	SafeGuardInventorySlot;
}

class Message {
	byte	CoresUsed;
	ushort	ItemInventorySlot;
	[Length(30)]
	Cores[]	CoresInUse;
	[LengthFor("SafeGuardsInUse")]
	ushort	SafeGuardsUsed;
	SafeGuards[]	SafeGuardsInUse;
}