
class Item {
    ulong ItemID;
    ulong ItemOption;
    ushort SlotIndex;
    uint ItemDuration;
}

class Message {
	uint EventIndex;
    uint Unknown1;
    byte Unknown2;
    [LengthFor("InventorySlots")]
    ushort Count;
    Item[] InventorySlots;
}