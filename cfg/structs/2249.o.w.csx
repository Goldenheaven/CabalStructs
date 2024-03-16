class InventorySlot {
    int InventorySlotIndex;
    uint Count;
}

class Message {
    uint RequestCode;
    [LengthFor("InventorySlots")]
    int InventorySlotCount;
    InventorySlot[] InventorySlots;
    [Length(4168)]
    byte[] u3;
}