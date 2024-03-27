
class Message {
	byte Category;
    byte ConditionValue1;
    byte ConditionValue2;
    byte u1;
    //[LengthFor("InventorySlotIndex")]
    byte InventorySlotCount;
    [Length(50)]
    ushort[] InventorySlotIndex;
}