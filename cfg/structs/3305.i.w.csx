class BanWord {
	int		ID;
	[Length(50)]
	string	Word;
}


class Message {
	byte	u0;
	int		u1;
	[LengthFor("BannedWords")]
	byte	Count;
	BanWord[] BannedWords;
}