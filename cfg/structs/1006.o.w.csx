
class Message {
	uint EventIndex;
    uint Unknown1;
    byte NpcID;
    uint ShopSlotIndex;
    [LengthFor("InventorySlots")]
    ushort Count;
    ushort[] InventorySlots;
}
