
enum ResultType : uint {
	Success					= 32,
	PasswordMismatch,
	DualLoginAttempt,
	SubscriptionExpired		= 36,
	IPBlocked,
	AccountBanned,
	AccountUnverified		= 41,
	PasswordAttemptLimit	= 43
}

struct CharCount {
	byte	Server;
	byte	Count;
}

class Message {
	bool		KeepAlive;
	int		u0;
	int		u1;
	int		LoginStatus;
	[TypeFor("SubMessage")]
	VariantType	SubMessageType;
	ResultType	AccountStatus;
	object		SubMessage;

	enum VariantType {
		EmptySubMessage	= 0,
		SubMessage17	= 17,
        SubMessage25    = 25,
	}

	class EmptySubMessage {}

	class SubMessage17 {
		byte		unk1;
		uint		AccountId;
		byte		u0;
		uint		u1;
		byte		u2;
		uint		u3;
		uint		u4;
		ulong		u5;
		uint		u6;
		ulong		PremiumSvcExpireDate;
		[Large]
		bool		HasChars;
		[Length(3)]
		byte[]		BoolPadding;
		int			u7;
		int			u8;
		int			Language;
		[Length(33)]
		string		CashToken;
		byte		u9;
		/* Number of servers with characters on them */
		byte		CharSvrCount;
		[Length(128)]
		CharCount[]	CharCount;
	}

    class SubMessage25 {
        uint        u0;
        ulong        u1;
        uint        u2;
        ulong        u3;
    }
}
