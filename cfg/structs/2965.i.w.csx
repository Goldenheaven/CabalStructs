
class Message {
	uint Result;
    byte SlotIndex;
    [Length(2)]
    uint[] ForceEffects;
    [Length(2)]
    byte[] ForceEffectGrades;
}