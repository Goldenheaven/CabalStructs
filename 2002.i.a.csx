
class Bookmark {
	string BookmarkName;
}

class Message {
	byte   	u0;
	ushort 	u1;
	ushort 	u2;
	uint    u3;
	ushort  u4;
	ushort  u5;
	//Temporary...
	[LengthFor("Bookmarks")]
	byte    u6;
	Bookmark[] Bookmarks;
}