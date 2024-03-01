
class Url {
	[LengthFor("Text")]
    uint	Length;
	string	Text;
}

class Message {
	ushort	Size1;
    [SizeFor("Urls")]
	ushort		Size2;
	List<Url>	Urls;
}