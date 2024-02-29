class DungeonWarp {
	[Comment("Check if its int or smaller")]
	 int Order;
    [Comment("WarpId = WarpIdxForSucess,WarpIdxForFail,WarpIndexForDead"+
			 "depending on result and if insIde dungeon, ?NSetIdx if outsIde?")]
	 int WarpId;	
	[Length(20)]
	 byte[] Padding;
}

class WarpPoint {
	[Comment("Check what this is, padding for now")]
	 uint Padding1;
	[Comment("Check if its int or smaller")]
	 int TargetId;
	[Comment("Probably, but have to check")]
	[Length(20)]
	 byte[] Padding;
}

class PremiumWarpPoint {
	[Comment("Check what this is, padding for now")]
	 ushort Padding1;
	 ushort u0;
	 byte X,
        Y;
	 ushort Padding2;
	 int WorldId;
	[Comment("Probably, but have to check")]
	[Length(20)]
	 byte[] Padding;
}

class GMWarp {
	[Comment("Check what this is, padding for now")]
	 uint Padding1;
	 byte GmX,
        GmY;
	 ushort Padding2;
	 int WorldId;
	[Comment("Probably, but have to check")]
	[Length(16)]
	 byte[] Padding;
}

class UnknownWarp {
	[Comment("Check what this is, padding for now")]
	 uint Padding1;
	 byte X,
        Y;
	[Comment("Probably, but have to check")]
	[Length(22)]
	 byte[] Padding;
}

class Warp {
	[Comment("Not always padding")]
	[Length(24)]
	 byte[] Padding;
}

enum WarpVariant : byte {
	Warp=0,
	Prison=55,
	DungeonWarp = 57,
	WarpPoint = 61,
	UnknownWarp = 69,
	GMWarp = 201,
	PremiumWarpPoint = 202
}

class Message
{
	byte NpcID;
    [Comment("Warp Entry Item Inventory Slot, Inventory Return Stone Slot "+
			 "or Return Stone QuickSlot depending on npc Id")]
    short Slot;
	
	Warp WarpData;
}
