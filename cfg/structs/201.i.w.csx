
enum DelType : byte {
    DelDead = 16,
    DelWarp,
    DelLogout,
    DelReturn,
    DelDisappear,
    DelNfsDead
}

class Message {
	int CharacterId;
	DelType Type;
}