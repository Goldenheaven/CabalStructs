using Shared.Character;

class Message {
	Style	Style;
	bool	JoinNoviceGuild;
	byte	u0;
	byte	Slot;
	[LengthFor("Name")]
	byte	NameLength;
	string	Name;
} 