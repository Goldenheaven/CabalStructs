
class Message {
	/* I think this is a bool that specifies whether or not to use a key */
	byte	u0;
	[LengthFor("Key")]
    ushort	Length;
	/* BER-encoded public key */
	byte[]	Key;
}