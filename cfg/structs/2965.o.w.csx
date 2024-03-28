
class Message {
	byte SkillIndex;
    uint Unknown1;
    [LengthFor("InventorySlotIndex")]
    ushort InventorySlotCount;
    ushort[] InventorySlotIndex;    
}