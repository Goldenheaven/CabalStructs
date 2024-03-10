class InventorySlot {
    int InventorySlotIndex;
    uint Count;
}

class Message {
    uint RequestCode;
    byte RequestSlotIndex;
    int u2;
    int InventorySlotCount;
    [Length(523)]
    InventorySlot[] InventorySlots;
}