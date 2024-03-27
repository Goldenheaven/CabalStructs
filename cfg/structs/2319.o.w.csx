
class Message {
	byte RewardPageIndex;
    ushort RewardGrade;
    byte u1;
    //[LengthFor("InventorySlotIndex")]
    byte InventorySlotCount;
    [Length(50)]
    ushort[] InventorySlotIndex;
}