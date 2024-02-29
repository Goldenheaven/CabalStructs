
class SearchParty {
	int  PartyLeaderId;
	ushort Level;
	ushort u0;
	byte   Map;
	byte   Channel;
	byte   NameLength;
	[Length(16)]
	string Name;
	byte  PartyMembers;
	[Length(39)]
	string Message1;
	ushort u1;
	ushort u2;
	byte   u3;
	
}

class Message {
	[LengthFor("Parties")]
	int    Count;
	SearchParty[] Parties;
}