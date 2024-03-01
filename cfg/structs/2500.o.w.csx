
class Message {
	byte   u0;
	ushort Slot;
	[LengthFor("Slots")]
	ushort Stacks;
	ushort ItemsPerStack;
	ushort u1;
	ushort SlotsSize;
	ushort[] Slots;
}